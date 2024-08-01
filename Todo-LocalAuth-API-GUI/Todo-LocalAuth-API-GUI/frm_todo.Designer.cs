namespace Todo_LocalAuth_API_GUI
{
    partial class frm_todo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_todo));
            lbx_todo = new ListBox();
            tbx_name = new TextBox();
            lbl_name = new Label();
            lbl_status = new Label();
            gbx_status = new GroupBox();
            rbtn_done = new RadioButton();
            rbtn_notDone = new RadioButton();
            lbl_desc = new Label();
            cal_date = new MonthCalendar();
            lbl_date = new Label();
            tbx_desc = new TextBox();
            cbx_deadline = new CheckBox();
            btn_add = new Button();
            btn_remove = new Button();
            btn_back = new Button();
            btn_edit = new Button();
            gbx_status.SuspendLayout();
            SuspendLayout();
            // 
            // lbx_todo
            // 
            lbx_todo.FormattingEnabled = true;
            lbx_todo.Location = new Point(12, 14);
            lbx_todo.Name = "lbx_todo";
            lbx_todo.Size = new Size(246, 404);
            lbx_todo.TabIndex = 0;
            lbx_todo.SelectedIndexChanged += lbx_todo_SelectedIndexChanged;
            // 
            // tbx_name
            // 
            tbx_name.Location = new Point(274, 35);
            tbx_name.Name = "tbx_name";
            tbx_name.Size = new Size(153, 27);
            tbx_name.TabIndex = 2;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(274, 12);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(52, 20);
            lbl_name.TabIndex = 1;
            lbl_name.Text = "Name:";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(442, 12);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(52, 20);
            lbl_status.TabIndex = 5;
            lbl_status.Text = "Status:";
            // 
            // gbx_status
            // 
            gbx_status.Controls.Add(rbtn_done);
            gbx_status.Controls.Add(rbtn_notDone);
            gbx_status.Location = new Point(442, 35);
            gbx_status.Name = "gbx_status";
            gbx_status.Size = new Size(144, 89);
            gbx_status.TabIndex = 6;
            gbx_status.TabStop = false;
            // 
            // rbtn_done
            // 
            rbtn_done.AutoSize = true;
            rbtn_done.Location = new Point(6, 56);
            rbtn_done.Name = "rbtn_done";
            rbtn_done.Size = new Size(82, 24);
            rbtn_done.TabIndex = 1;
            rbtn_done.TabStop = true;
            rbtn_done.Text = "Erledigt";
            rbtn_done.UseVisualStyleBackColor = true;
            rbtn_done.CheckedChanged += rbtn_status_CheckedChanged;
            // 
            // rbtn_notDone
            // 
            rbtn_notDone.AutoSize = true;
            rbtn_notDone.Location = new Point(6, 26);
            rbtn_notDone.Name = "rbtn_notDone";
            rbtn_notDone.Size = new Size(124, 24);
            rbtn_notDone.TabIndex = 0;
            rbtn_notDone.TabStop = true;
            rbtn_notDone.Text = "Nicht erledigt:";
            rbtn_notDone.UseVisualStyleBackColor = true;
            rbtn_notDone.CheckedChanged += rbtn_status_CheckedChanged;
            // 
            // lbl_desc
            // 
            lbl_desc.AutoSize = true;
            lbl_desc.Location = new Point(274, 81);
            lbl_desc.Name = "lbl_desc";
            lbl_desc.Size = new Size(101, 20);
            lbl_desc.TabIndex = 3;
            lbl_desc.Text = "Beschreibung:";
            // 
            // cal_date
            // 
            cal_date.Location = new Point(439, 211);
            cal_date.MaxSelectionCount = 1;
            cal_date.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            cal_date.Name = "cal_date";
            cal_date.ShowToday = false;
            cal_date.TabIndex = 9;
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Location = new Point(439, 182);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(70, 20);
            lbl_date.TabIndex = 8;
            lbl_date.Text = "Fällig bis:";
            // 
            // tbx_desc
            // 
            tbx_desc.Location = new Point(274, 104);
            tbx_desc.Multiline = true;
            tbx_desc.Name = "tbx_desc";
            tbx_desc.Size = new Size(153, 244);
            tbx_desc.TabIndex = 4;
            // 
            // cbx_deadline
            // 
            cbx_deadline.AutoSize = true;
            cbx_deadline.Location = new Point(439, 142);
            cbx_deadline.Name = "cbx_deadline";
            cbx_deadline.Size = new Size(91, 24);
            cbx_deadline.TabIndex = 7;
            cbx_deadline.Text = "Deadline";
            cbx_deadline.UseVisualStyleBackColor = true;
            cbx_deadline.CheckedChanged += cbx_deadline_CheckedChanged;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(274, 354);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(76, 29);
            btn_add.TabIndex = 10;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_remove
            // 
            btn_remove.Location = new Point(351, 354);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(76, 29);
            btn_remove.TabIndex = 11;
            btn_remove.Text = "-";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(603, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(52, 31);
            btn_back.TabIndex = 13;
            btn_back.Text = "X";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(274, 389);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(153, 29);
            btn_edit.TabIndex = 12;
            btn_edit.Text = "Bearbeiten";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // frm_todo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 437);
            Controls.Add(btn_edit);
            Controls.Add(btn_back);
            Controls.Add(btn_remove);
            Controls.Add(btn_add);
            Controls.Add(cbx_deadline);
            Controls.Add(tbx_desc);
            Controls.Add(lbl_date);
            Controls.Add(cal_date);
            Controls.Add(lbl_desc);
            Controls.Add(gbx_status);
            Controls.Add(lbl_status);
            Controls.Add(lbl_name);
            Controls.Add(tbx_name);
            Controls.Add(lbx_todo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(685, 484);
            MinimumSize = new Size(685, 484);
            Name = "frm_todo";
            Text = "Todo";
            gbx_status.ResumeLayout(false);
            gbx_status.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbx_todo;
        private TextBox tbx_name;
        private Label lbl_name;
        private Label lbl_status;
        private GroupBox gbx_status;
        private RadioButton rbtn_done;
        private RadioButton rbtn_notDone;
        private Label lbl_desc;
        private MonthCalendar cal_date;
        private Label lbl_date;
        private TextBox tbx_desc;
        private CheckBox cbx_deadline;
        private Button btn_add;
        private Button btn_remove;
        private Button btn_back;
        private Button btn_edit;
    }
}