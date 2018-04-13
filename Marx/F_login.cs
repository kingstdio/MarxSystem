using System;
using System.Windows.Forms;

namespace Marx
{
    public partial class F_login : DevComponents.DotNetBar.OfficeForm
    {
        private string userName = "user";
        private string password = "user";
        public F_login()
        {
            InitializeComponent();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            userName = tb_userName.Text.Trim();
            password = tb_password.Text.Trim();
            if (userName == string.Empty)
            {
                MessageBox.Show("请输入用户名","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if(password==string.Empty)
            {
                MessageBox.Show("请输入密码", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (doLogin(this.userName, this.password))
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }

        }

        private bool doLogin(string userName, string password)
        {
            if(userName=="user" && password =="user")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}