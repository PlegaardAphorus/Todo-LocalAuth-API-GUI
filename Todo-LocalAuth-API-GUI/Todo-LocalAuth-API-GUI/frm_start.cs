namespace Todo_LocalAuth_API_GUI
{
    public partial class frm_start : Form
    {
        public frm_start()
        {
            InitializeComponent();
            CenterToScreen();
            pbr_loading.Minimum = 0;
            pbr_loading.Maximum = 100;
            pbr_loading.Step = 1;
        }

        public void startProgramm(string type)
        {
            Random random = new Random();
            int zufall = random.Next(3, 8);
            int zufall2;
            for (int i = 0; i < zufall; i++)
            {
                zufall2 = random.Next(0, 100);
                for (int j = 0; j < zufall2; j++)
                {
                    pbr_loading.PerformStep();
                }
                Thread.Sleep(random.Next(30) + 1000);
                if (i == zufall - 1)
                {
                    pbr_loading.Value = 100;
                }
            }

            frm_LoginRegister loginRegister = new frm_LoginRegister(type);
            loginRegister.Show();
            loginRegister.Focus();
            Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            startProgramm("login");
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            startProgramm("register");
        }
    }
}