using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlborzBook
{
    public partial class frmLoginListUsers : Form
    {

        

        public frmLoginListUsers()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();
            errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;

            Boolean flag = false;

            if (txtUserName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtUserName, "نام کاربری را وارد کنید");
                flag = true;

            }
            if (txtPassword.Text.Trim() == "")
            {
                errorProvider1.SetError(txtPassword, "رمز عبور را وارد کنید");
                flag = true;
            }
            if (cbRoles.Checked==false)
            {
                errorProvider1.SetError(cbRoles, "نقش کاربر را انتخاب کنید");
                flag = true;
            }
            if (flag == true)
            {
                return;
            }
            else
            {
                alborzBookDataContext db = new alborzBookDataContext();
                var result = (from u in db.tblUsers
                              where u.userName == txtUserName.Text
                              && u.password == txtPassword.Text 
                              select u).SingleOrDefault();

                if (result == null)
                {

                    txtPassword.Text = "";
                    txtUserName.Text = "";
                    txtUserName.Focus();

                    MessageBox.Show("!نام کاربری یا رمز عبور اشتباه است"
                        , "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    var result1 = (from u in db.tblUsers
                                   where u.userName == txtUserName.Text
                                   && u.password == txtPassword.Text &&
                                   u.roles == cbRoles.Text
                                   select u).SingleOrDefault();

                    if (result1 == null)
                    {

                        MessageBox.Show("ورود فقط برای کاربر ارشد مجاز می باشد"
                            , "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error
                            , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                        this.Close();


                    }
                    else
                    {
                        frmListUsers listUsers = new frmListUsers();
                        listUsers.Show();
                        this.Close();
                    }
                }
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '!' || e.KeyChar == '?' || e.KeyChar == '@'
                || e.KeyChar == '#' || e.KeyChar == '$' || e.KeyChar == '%' || e.KeyChar == '*'
                || e.KeyChar == '^' || e.KeyChar == '&' || e.KeyChar == '(' || e.KeyChar == ')'
                || e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == '+' || e.KeyChar == '،'
                || e.KeyChar == '=' || e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == '|'
                || e.KeyChar == '{' || e.KeyChar == '}' || e.KeyChar == '[' || e.KeyChar == ']'
                || e.KeyChar == '~' || e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '/'
                || e.KeyChar == '`' || e.KeyChar == '"' || e.KeyChar == ':' || e.KeyChar == ';')
            {
                e.Handled = true;
            }
        }

        private void frmLoginListUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
