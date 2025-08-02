using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace AlborzBook
{
    public partial class frmNewUser : AlborzBook.frmTemplateNewEdit
    {
        alborzBookDataContext db = new alborzBookDataContext();
        
        
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            DialogResult x;
            x = MessageBox.Show("آیامیخواهید خارج شوید ؟", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (x == DialogResult.Yes)
            {
                frmListUsers frmList = new frmListUsers();
                frmList.Show();
                this.Close();

            }
        }

        private void txtReNewPass_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            tblUser user = new tblUser();

            errorProvider1.Clear();
            errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
            Boolean flag = false;

            //--------------- new user ------------//

            if (btnSave.Text=="ثبت کاربر")
            {
                if (txtUserName.Text == "")
                {
                    errorProvider1.SetError(txtUserName, "نام کاربری را وارد کنید");
                    flag = true;
                }
                if (txtCurentPass.Text == "")
                {
                    errorProvider1.SetError(txtCurentPass, "رمز عبور را وارد کنید");
                    flag = true;
                }
                if (txtNewPass.Text == "")
                {
                    errorProvider1.SetError(txtNewPass, "تکرار رمز عبور را وارد کنید");
                    flag = true;
                }
                if (flag == true)
                {
                    return;
                }
                else if (txtCurentPass.Text != txtNewPass.Text) 
                {
                    MessageBox.Show("! رمز عبور و تکرار آن یکسان نیست", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                    txtCurentPass.Text = "";
                    txtNewPass.Text = "";

                    txtCurentPass.Focus();

                }
                else
                {
                    var result = (from u in db.tblUsers where txtUserName.Text == u.userName select u).SingleOrDefault();

                    if (result != null)
                    {
                        MessageBox.Show("!نام کاربر تکراری می باشد", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                        txtUserName.Focus();
                    }
                    else
                    {
                        user.userName = txtUserName.Text;
                        user.password = txtCurentPass.Text;

                        if (rBtnSenior.Checked == true)
                        {
                            user.roles = "کاربر ارشد";

                        }
                        else if(rBtnNormal.Checked==true)
                        {
                            user.roles = "کاربر عمومی";
                        }
                        else
                        {
                            MessageBox.Show("! نقش کاربر را انتخاب کنید", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                            return;
                        }

                    }
                    db.tblUsers.InsertOnSubmit(user);
                    db.SubmitChanges();

                    frmListUsers frmList = new frmListUsers();
                    frmList.Show();
                    this.Close();
                }
            }

            //--------------- edit user ------------//

            else if (btnSave.Text == "ویرایش کاربر")
            {
                if (txtUserName.Text == "")
                {
                    errorProvider1.SetError(txtUserName, "نام کاربری را وارد کنید");
                    flag = true;
                }
                if (txtCurentPass.Text == "")
                {
                    errorProvider1.SetError(txtCurentPass, "رمز عبور فعلی را وارد کنید");
                    flag = true;
                }
                if (txtNewPass.Text == "")
                {
                    errorProvider1.SetError(txtNewPass, "رمز عبور جدید را وارد کنید");
                    flag = true;
                }
                if (txtReNewPass.Text == "")
                {
                    errorProvider1.SetError(txtReNewPass, "تکرار رمز عبور جدید را وارد کنید");
                    flag = true;
                }
                if (flag == true)
                {
                    return;
                }
                else
                {
                    var result = (from u in db.tblUsers where u.password == txtCurentPass.Text select u).SingleOrDefault();

                    if (result == null)
                    {
                        MessageBox.Show("! رمز عبور صحیح نیست ", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                        txtCurentPass.Text = "";
                        txtCurentPass.Focus();

                        return;
                    }
                    else if (txtNewPass.Text != txtReNewPass.Text) 
                    {
                        MessageBox.Show("! رمز عبور و تکرار آن یکسان نیست", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                        txtNewPass.Text = "";
                        txtReNewPass.Text = "";

                        txtNewPass.Focus();

                        return;
                    }
                    string name = txtUserName.Text;

                    var resultEdit = (from u in db.tblUsers where u.userName == name select u).SingleOrDefault();

                    resultEdit.userName = txtUserName.Text;
                    resultEdit.password = txtNewPass.Text;
                    if (rBtnSenior.Checked == true)
                    {
                        resultEdit.roles = "کاربر ارشد";
                    }
                    else if (rBtnNormal.Checked == true)
                    {
                        resultEdit.roles = "کاربر عمومی";
                    }

                    db.SubmitChanges();

                    MessageBox.Show("تغییرات با موفقیت انجام شد");

                    frmListUsers frmList = new frmListUsers();
                    frmList.Show();
                    this.Close();
                }
            }
        }
    }
}
