namespace Marx
{
    partial class F_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_login));
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.reflectionLabel2 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.tb_userName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bt_submit = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Location = new System.Drawing.Point(52, 26);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(117, 52);
            this.reflectionLabel1.TabIndex = 1;
            this.reflectionLabel1.TabStop = false;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>用户</i><font color=\"#B02B2C\">账号：</font></font></b>";
            // 
            // reflectionLabel2
            // 
            // 
            // 
            // 
            this.reflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel2.Location = new System.Drawing.Point(52, 80);
            this.reflectionLabel2.Name = "reflectionLabel2";
            this.reflectionLabel2.Size = new System.Drawing.Size(129, 52);
            this.reflectionLabel2.TabIndex = 1;
            this.reflectionLabel2.TabStop = false;
            this.reflectionLabel2.Text = "<b><font size=\"+6\"><i>用户</i><font color=\"#B02B2C\">口令：</font></font></b>";
            // 
            // tb_userName
            // 
            this.tb_userName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_userName.Border.Class = "TextBoxBorder";
            this.tb_userName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_userName.DisabledBackColor = System.Drawing.Color.White;
            this.tb_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_userName.ForeColor = System.Drawing.Color.Black;
            this.tb_userName.Location = new System.Drawing.Point(151, 38);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.PreventEnterBeep = true;
            this.tb_userName.Size = new System.Drawing.Size(247, 29);
            this.tb_userName.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_password.Border.Class = "TextBoxBorder";
            this.tb_password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_password.DisabledBackColor = System.Drawing.Color.White;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_password.ForeColor = System.Drawing.Color.Black;
            this.tb_password.Location = new System.Drawing.Point(151, 92);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.PreventEnterBeep = true;
            this.tb_password.Size = new System.Drawing.Size(247, 29);
            this.tb_password.TabIndex = 2;
            // 
            // bt_submit
            // 
            this.bt_submit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_submit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_submit.Location = new System.Drawing.Point(52, 138);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(346, 46);
            this.bt_submit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_submit.TabIndex = 3;
            this.bt_submit.Text = " 登录系统";
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // F_login
            // 
            this.AcceptButton = this.bt_submit;
            this.ClientSize = new System.Drawing.Size(446, 203);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.reflectionLabel2);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录-马克思主义学院办公系统";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel2;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_userName;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_password;
        private DevComponents.DotNetBar.ButtonX bt_submit;


    }
}