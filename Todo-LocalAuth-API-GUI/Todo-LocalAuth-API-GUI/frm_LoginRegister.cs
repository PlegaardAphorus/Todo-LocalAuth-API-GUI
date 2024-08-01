using System.Text;
using System.Text.Json;
using Todo_LocalAuth_API_GUI.models;
using Todo_LocalAuth_API_GUI.utility;

namespace Todo_LocalAuth_API_GUI
{
    public partial class frm_LoginRegister : Form
    {
        string authType;
        string url = URL.GetURL();
        string jwt;
        public frm_LoginRegister(string loginRegister)
        {
            InitializeComponent();
            CenterToScreen();
            authType = loginRegister;
            switch (loginRegister)
            {
                default:
                case "register":
                    btn_submit.Text = "Registrieren";
                    lbl_email.Show();
                    tbx_email.Show();
                    btn_submit.Location = new Point(135, 415);
                    break;
                case "login":
                    btn_submit.Text = "Login";
                    lbl_email.Hide();
                    tbx_email.Hide();
                    btn_submit.Location = new Point(135, 336);
                    break;
            }
        }

        public HttpResponseMessage response;
        public async void registerUser()
        {
            HttpClient http = new HttpClient();

            User user = new User { Username = tbx_username.Text, Email = tbx_email.Text, Password = HashPassword.PasswordHash(tbx_password.Text) };

            string json = JsonSerializer.Serialize(user);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                response = await http.PostAsync(url + @"auth/register", content);
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
                string responseBody = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Erfolgreich registierert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_LoginRegister LoginRegister = new frm_LoginRegister("login");
                LoginRegister.Show();
                LoginRegister.Focus();
                Close();
            }
            else if (response.StatusCode.ToString() == "Conflict")
            {
                MessageBox.Show("Es gibt bereits einen Benutzer mit diesen Daten", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten: " + response.StatusCode, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void loginUser()
        {
            HttpClient http = new HttpClient();

            User user = new User { Username = tbx_username.Text, Password = HashPassword.PasswordHash(tbx_password.Text) };

            string json = JsonSerializer.Serialize(user);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                response = await http.PostAsync(url + @"auth/login", content);
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
                string responseBody = await response.Content.ReadAsStringAsync();
                responseBody = responseBody.Remove(0, 10);
                responseBody = responseBody.Remove(responseBody.Length - 2, 2);
                jwt = responseBody;
                frm_todo todos = new frm_todo(jwt);
                todos.Show();
                todos.Focus();
                Close();
            }
            else
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten: " + response.StatusCode, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_submit_Click(object sender, EventArgs e)
        {
            if (authType == "register")
            {
                registerUser();
            }
            else
            {
                loginUser();
            }
        }

        private void tbx_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                btn_submit_Click(sender, e);
            }
        }

        private void tbx_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                btn_submit_Click(sender, e);
            }
        }

        private void tbx_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                btn_submit_Click(sender, e);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_start start = new frm_start();
            start.Show();
            start.Focus();
            Close();
        }
    }
}