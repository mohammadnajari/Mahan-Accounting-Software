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
    public partial class frmNewEdit : Form
    {
        alborzBookDataContext db = new alborzBookDataContext();

        public frmNewEdit()
        {
            InitializeComponent();
        }

        private void btnSabt_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            errorProvider1.Clear();
            errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
            Boolean flag = false;

            //--------------- new publishers ------------//

            if (btnSabt.Text == "ثبت انتشارات")
            {
 
                if (txtName.Text == "")
                {
                    errorProvider1.SetError(txtName, "نام انتشارات را وارد کنید");
                    flag = true;
                }
                if (flag == true)
                {
                    return;
                }
                else
                {
                    
                    tblPublisher publisher = new tblPublisher();

                    var result = (from u in db.tblPublishers
                                  where txtName.Text == u.publishersName
                                  select u).SingleOrDefault();

                    if (result != null)
                    {
                        MessageBox.Show("! نام انتشارات تکراری می باشد", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    else
                    {
                        publisher.publishersName = txtName.Text;

                        db.tblPublishers.InsertOnSubmit(publisher);
                        db.SubmitChanges();

                        frmPublisher frmPublisher = new frmPublisher();
                        frmPublisher.Show();

                        this.Close();
                    }

                }

            }

            //--------------- edit publishers ------------//

            else if (btnSabt.Text == "ویرایش انتشارات")
            {
                int id = int.Parse(txtId.Text);

                var result = (from u in db.tblPublishers where u.publishersId == id select u).SingleOrDefault();

                if (txtName.Text == "")
                {
                    errorProvider1.SetError(txtName, "نام انتشارات را وارد کنید");
                    flag = true;
                }
                if (flag == true)
                {
                    return;
                }
                else
                {
                    var result1 = (from u in db.tblPublishers
                                   where txtName.Text == u.publishersName
                                   select u).SingleOrDefault();

                    if (result1 != null)
                    {
                        MessageBox.Show("! نام انتشارات تکراری می باشد", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    else
                    {
                        result.publishersName = txtName.Text;

                        db.SubmitChanges();

                        MessageBox.Show("تغییرات با موفقیت انجام شد");


                        frmPublisher publisher = new frmPublisher();
                        publisher.Show();
                        this.Close();
                    }
                }
            }

            //--------------- new category books ------------//

            else if (btnSabt.Text=="ثبت")
            {
                

                if (txtName.Text == "")
                {
                    errorProvider1.SetError(txtName, "نام دسته بندی را وارد کنید");
                    flag = true;
                }
                if (flag == true)
                {
                    return;
                }
                else
                {
                    
                    tblCategoryBook categoryBook = new tblCategoryBook();

                    var result = (from u in db.tblCategoryBooks
                                  where txtName.Text == u.categoryName
                                  select u).SingleOrDefault();

                    if (result != null)
                    {
                        MessageBox.Show("! نام دسته بندی تکراری می باشد", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        categoryBook.categoryName = txtName.Text;

                        db.tblCategoryBooks.InsertOnSubmit(categoryBook);
                        db.SubmitChanges();

                        frmCategoruBooks frmCategoru = new frmCategoruBooks();
                        frmCategoru.Show();

                        this.Close();
                    }
                }

            }

            //--------------- edit category books ------------//

            else if (btnSabt.Text == "ویرایش")
            {

                int id = int.Parse(txtId.Text);

                var result = (from u in db.tblCategoryBooks where u.categoryId == id select u).SingleOrDefault();

                if (txtName.Text == "")
                {
                    errorProvider1.SetError(txtName, "نام دسته بندی را وارد کنید");
                    flag = true;
                }
                if (flag == true)
                {
                    return;
                }
                else
                {
                    var result1 = (from u in db.tblCategoryBooks
                                  where txtName.Text == u.categoryName
                                  select u).SingleOrDefault();

                    if (result1 != null)
                    {
                        MessageBox.Show("! نام دسته بندی تکراری می باشد", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {

                        result.categoryName = txtName.Text;

                        db.SubmitChanges();

                        MessageBox.Show("تغییرات با موفقیت انجام شد");


                        frmCategoruBooks frmCategoru = new frmCategoruBooks();
                        frmCategoru.Show();
                        this.Close();
                    }
                }
            }
            //
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
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
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmNewEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
