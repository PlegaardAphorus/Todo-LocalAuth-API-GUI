namespace Todo_LocalAuth_API_GUI
{
    partial class frm_start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_start));
            btn_login = new Button();
            btn_register = new Button();
            pbx_logo = new PictureBox();
            pbr_loading = new ProgressBar();
            lbl_headline = new Label();
            ((System.ComponentModel.ISupportInitialize)pbx_logo).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(69, 242);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(145, 29);
            btn_login.TabIndex = 1;
            btn_login.Text = "Anmelden";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(69, 287);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(145, 29);
            btn_register.TabIndex = 2;
            btn_register.Text = "Registieren";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // pbx_logo
            // 
            pbx_logo.Image = Properties.Resources.icon;
            pbx_logo.Location = new Point(89, 64);
            pbx_logo.Name = "pbx_logo";
            pbx_logo.Size = new Size(145, 108);
            pbx_logo.TabIndex = 9;
            pbx_logo.TabStop = false;
            // 
            // pbr_loading
            // 
            pbr_loading.Location = new Point(69, 198);
            pbr_loading.Name = "pbr_loading";
            pbr_loading.Size = new Size(145, 29);
            pbr_loading.TabIndex = 0;
            // 
            // lbl_headline
            // 
            lbl_headline.AutoSize = true;
            lbl_headline.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_headline.Location = new Point(69, 9);
            lbl_headline.Name = "lbl_headline";
            lbl_headline.Size = new Size(145, 41);
            lbl_headline.TabIndex = 10;
            lbl_headline.Text = "Todo API";
            // 
            // frm_start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 364);
            Controls.Add(lbl_headline);
            Controls.Add(pbr_loading);
            Controls.Add(pbx_logo);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(298, 411);
            MinimumSize = new Size(298, 411);
            Name = "frm_start";
            Text = "Start";
            ((System.ComponentModel.ISupportInitialize)pbx_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_login;
        private Button btn_register;
        private PictureBox pbx_logo;
        private ProgressBar pbr_loading;
        private Label lbl_headline;
    }
}
