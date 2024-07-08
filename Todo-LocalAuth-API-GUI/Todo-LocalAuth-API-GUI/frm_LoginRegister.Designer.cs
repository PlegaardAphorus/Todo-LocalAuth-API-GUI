namespace Todo_LocalAuth_API_GUI
{
    partial class frm_LoginRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LoginRegister));
            tbx_email = new TextBox();
            tbx_password = new TextBox();
            tbx_username = new TextBox();
            lbl_email = new Label();
            lbl_password = new Label();
            lbl_username = new Label();
            btn_submit = new Button();
            lbl_headline = new Label();
            pbx_logo = new PictureBox();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pbx_logo).BeginInit();
            SuspendLayout();
            // 
            // tbx_email
            // 
            tbx_email.Location = new Point(135, 363);
            tbx_email.Name = "tbx_email";
            tbx_email.Size = new Size(125, 27);
            tbx_email.TabIndex = 12;
            tbx_email.KeyPress += tbx_email_KeyPress;
            // 
            // tbx_password
            // 
            tbx_password.Location = new Point(135, 285);
            tbx_password.Name = "tbx_password";
            tbx_password.PasswordChar = '*';
            tbx_password.Size = new Size(125, 27);
            tbx_password.TabIndex = 11;
            tbx_password.KeyPress += tbx_password_KeyPress;
            // 
            // tbx_username
            // 
            tbx_username.Location = new Point(135, 212);
            tbx_username.Name = "tbx_username";
            tbx_username.Size = new Size(125, 27);
            tbx_username.TabIndex = 10;
            tbx_username.KeyPress += tbx_username_KeyPress;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(135, 340);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(49, 20);
            lbl_email.TabIndex = 9;
            lbl_email.Text = "Email:";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(135, 262);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(69, 20);
            lbl_password.TabIndex = 8;
            lbl_password.Text = "Passwort:";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(135, 189);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(107, 20);
            lbl_username.TabIndex = 7;
            lbl_username.Text = "Benutzername:";
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(135, 415);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(125, 29);
            btn_submit.TabIndex = 15;
            btn_submit.Text = "TEMP";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // lbl_headline
            // 
            lbl_headline.AutoSize = true;
            lbl_headline.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_headline.Location = new Point(135, 19);
            lbl_headline.Name = "lbl_headline";
            lbl_headline.Size = new Size(145, 41);
            lbl_headline.TabIndex = 17;
            lbl_headline.Text = "Todo API";
            // 
            // pbx_logo
            // 
            pbx_logo.Image = Properties.Resources.icon;
            pbx_logo.Location = new Point(153, 63);
            pbx_logo.Name = "pbx_logo";
            pbx_logo.Size = new Size(145, 108);
            pbx_logo.TabIndex = 16;
            pbx_logo.TabStop = false;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 19);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(52, 31);
            btn_back.TabIndex = 18;
            btn_back.Text = "X";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // frm_LoginRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 476);
            Controls.Add(btn_back);
            Controls.Add(lbl_headline);
            Controls.Add(pbx_logo);
            Controls.Add(btn_submit);
            Controls.Add(tbx_email);
            Controls.Add(tbx_password);
            Controls.Add(tbx_username);
            Controls.Add(lbl_email);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(429, 523);
            MinimumSize = new Size(429, 523);
            Name = "frm_LoginRegister";
            Text = "LoginRegister";
            ((System.ComponentModel.ISupportInitialize)pbx_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_email;
        private TextBox tbx_password;
        private TextBox tbx_username;
        private Label lbl_email;
        private Label lbl_password;
        private Label lbl_username;
        private Button btn_submit;
        private Label lbl_headline;
        private PictureBox pbx_logo;
        private Button btn_back;
    }
}