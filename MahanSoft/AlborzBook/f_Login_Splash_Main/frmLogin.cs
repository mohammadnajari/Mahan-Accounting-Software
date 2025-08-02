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
    public partial class frmLogin : Form
    {
        
        int count = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtUserName.Text.Trim() == "" && txtPassword.Text.Trim() == "")
            {
                txtUserName.Focus();
                lblCheckUser.Text = "نام کاربری را وارد کنید";
                lblCheckPass.Text = "رمز عبور را وارد کنید";
               

            }
            else if (txtUserName.Text.Trim() == "")
            {
                txtUserName.Focus();
                lblCheckUser.Text = "نام کاربری را وارد کنید";
                lblCheckPass.Text = "";
            }
            else if (txtPassword.Text.Trim() == "")
            {
                txtPassword.Focus();
                lblCheckPass.Text = "رمز عبور را وارد کنید";
                lblCheckUser.Text = "";
            }

            //--------------- Connecting to the database and checking ------------//
            
            else
            {
                lblCheckUser.Text = "";
                lblCheckPass.Text = "";


                alborzBookDataContext db = new alborzBookDataContext();
                var result = (from u in db.tblUsers
                              where u.userName == txtUserName.Text
                              && u.password == txtPassword.Text
                              select  u).SingleOrDefault();

                

                if (result==null)
                {
                    txtPassword.Text = "";
                    txtUserName.Text = "";
                    txtUserName.Focus();

                    MessageBox.Show("!نام کاربری یا رمز عبور اشتباه است"
                        , "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    count++;
                    if(count==3)
                    {
                        MessageBox.Show("ورود نامعتبر! با مدیر سیستم تماس بگیرید","خطای ورود"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
               
                }
                else
                {

                    frmMain fMain = new frmMain();
                    fMain.Show();
                    this.Close();
                    
                }

                
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult x = new DialogResult();

            x = MessageBox.Show("آیا می خواهید خارج شوید ؟", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.None, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign |
                MessageBoxOptions.RtlReading);
            

            if (x == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
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

        
    }
}
