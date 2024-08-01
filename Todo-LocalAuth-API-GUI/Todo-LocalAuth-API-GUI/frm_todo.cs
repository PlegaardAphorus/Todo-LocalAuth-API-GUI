using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Todo_LocalAuth_API_GUI.models;
using Todo_LocalAuth_API_GUI.utility;

namespace Todo_LocalAuth_API_GUI
{
    public partial class frm_todo : Form
    {
        public List<Todo> todos = new List<Todo>();
        public bool status = false;
        public HttpClient http = new HttpClient();
        public HttpResponseMessage response = new HttpResponseMessage();
        public string url = URL.GetURL();

        public frm_todo(string jwt)
        {
            InitializeComponent();
            CenterToScreen();
            cbx_deadline.Checked = true;

            http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

            gbx_status.Controls.Add(rbtn_done);
            gbx_status.Controls.Add(rbtn_notDone);

            LoadAllTodos();
        }

        public async void LoadAllTodos()
        {
            HttpResponseMessage response = await http.GetAsync(url + @"todo/list");
            string responseBody = await response.Content.ReadAsStringAsync();

            using (JsonDocument doc = JsonDocument.Parse(responseBody))
            {
                JsonElement resultElement = doc.RootElement.GetProperty("result");

                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                List<Todo> allTodos = JsonSerializer.Deserialize<List<Todo>>(resultElement.GetRawText(), options);

                todos.Clear();

                foreach (Todo todo in allTodos)
                {
                    todos.Add(todo);
                }

                UpdateLBX();
            }
        }

        private void UpdateLBX()
        {            
            lbx_todo.DataSource = null;
            lbx_todo.DataSource = todos;

            lbx_todo.DisplayMember = "AnzeigeName";
        }

        private async void addTodoToList(int index = -2)
        {
            if (index == -2)
            {
                index = todos.Count;
            }
            Todo newTodo = new Todo();
            newTodo.Name = tbx_name.Text;
            newTodo.Description = tbx_desc.Text;
            newTodo.Completed = status;

            if (cbx_deadline.Checked)
            {
                newTodo.Deadline = cal_date.SelectionStart.ToString();
            }
            else
            {
                newTodo.Deadline = "NO DATE ADDED";
            }
            string json = JsonSerializer.Serialize(newTodo);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                response = await http.PostAsync(url + @"todo/add", content);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte überprüfen sie ob die URL korrekt ist und der Port in der Config richtig angegeben wurde.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (response == null)
            {
                return;
            }
            else if (response.IsSuccessStatusCode)
            {
                LoadAllTodos();
                UpdateLBX();
            }
            else
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten: " + response.StatusCode, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteTodoFromList()
        {
            if (lbx_todo.SelectedIndex >= 0)
            {
                try
                {
                    response = await http.DeleteAsync(url + @$"todo/delete/{todos[lbx_todo.SelectedIndex].Id}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bitte überprüfen sie ob die URL korrekt ist und der Port in der Config richtig angegeben wurde.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (response == null)
                {
                    return;
                }
                else if (response.IsSuccessStatusCode)
                {
                    LoadAllTodos();
                    todos.RemoveAt(lbx_todo.SelectedIndex);
                    UpdateLBX();
                }
                else
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten: " + response.StatusCode, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cbx_deadline_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_deadline.Checked == true)
            {
                cal_date.Show();
                lbl_date.Show();
            }
            else
            {
                cal_date.Hide();
                lbl_date.Hide();
            }
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            addTodoToList();
        }

        private async void btn_remove_Click(object sender, EventArgs e)
        {
            deleteTodoFromList();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_LoginRegister registerLogin = new frm_LoginRegister("login");
            registerLogin.Show();
            registerLogin.Focus();
            Close();
        }

        private void rbtn_status_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_done.Checked)
            {
                status = true;
            }
            else
            {
                status = false;
            }
        }

        private void lbx_todo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbx_todo.SelectedIndex;
            if (index >= 0)
            {
                tbx_name.Text = todos[index].Name.ToString();
                tbx_desc.Text = todos[index].Description.ToString();
                if (todos[index].Completed)
                {
                    rbtn_done.Select();
                }
                else
                {
                    rbtn_notDone.Select();
                }
                if (todos[index].Deadline == "NO DATE ADDED")
                {
                    cbx_deadline.Checked = false;
                    cal_date.Hide();
                }
                else
                {
                    cbx_deadline.Checked = true;
                    cal_date.Show();
                    cal_date.SelectionStart = DateTime.Parse(todos[index].Deadline);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int index = lbx_todo.SelectedIndex;
            if (index >= 0)
            {
                deleteTodoFromList();
                addTodoToList(index);
            }
        }
    }
}
