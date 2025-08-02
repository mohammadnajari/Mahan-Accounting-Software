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
    public partial class frmListUsers : AlborzBook.frmTemplateTable
    {
        alborzBookDataContext db = new alborzBookDataContext();

        public frmListUsers()
        {
            InitializeComponent();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            frmNewUser newUser = new frmNewUser();

            newUser.lblPass.Text = "رمز عبور";
            newUser.lblRePass.Text = "تکرار رمز عبور";
            newUser.btnSave.Text = "ثبت کاربر";
            newUser.Text = "کاربر جدید";

            newUser.lblRePass2.Hide();
            newUser.txtReNewPass.Hide();


            newUser.Show();
            this.Close();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            dGridUsers.AutoGenerateColumns = false;

            var result = from u in db.tblUsers select u;

            dGridUsers.DataSource = result;
        }

        private void dGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //--------------- edit user ------------//

            if (e.ColumnIndex == dGridUsers.Columns["clmEdit"].Index)  
            {
                string name = dGridUsers.Rows[e.RowIndex].Cells["clmUserName"].Value.ToString();

                var result = (from u in db.tblUsers where u.userName == name select u).SingleOrDefault();

                frmNewUser edit = new frmNewUser();

                edit.txtUserName.Text = result.userName;

                if (result.roles == "کاربر ارشد") 
                {
                    edit.rBtnSenior.Checked = true;
                }
                else if(result.roles == "کاربر عمومی")
                {
                    edit.rBtnNormal.Checked = true;
                }

                edit.txtUserName.ReadOnly = true;
                edit.btnSave.Text = "ویرایش کاربر";
                edit.Text = "ویرایش کاربر";
                
                edit.Show();
                this.Close();

            }

            //--------------- delete user ------------//

            else if (e.ColumnIndex == dGridUsers.Columns["clmDelete"].Index)
            {
                DialogResult x = new DialogResult();
                x = MessageBox.Show("آیا مطمئن هستید که می خواهید این کاربر را حذف کنید؟",
                    "حذف حذف کاربر", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);

                if (x == DialogResult.Yes)
                {

                    string name = dGridUsers.Rows[e.RowIndex].Cells["clmUserName"].Value.ToString();

                    var result = (from u in db.tblUsers where u.userName == name select u).SingleOrDefault();

                    db.tblUsers.DeleteOnSubmit(result);
                    db.SubmitChanges();

                    MessageBox.Show("حذف با موفقیت انجام شد", "", MessageBoxButtons.OK);

                    frmListUsers_Load(null, null);
                }

            }
        }
    }
}
