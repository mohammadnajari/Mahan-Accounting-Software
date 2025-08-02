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
    public partial class frmNewBook : Form
    {
        public frmNewBook()
        {
            InitializeComponent();
        }

        private void txtBookName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar==' ')
            {
                e.Handled = true;
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmNewBook_Load(object sender, EventArgs e)
        {
            alborzBookDataContext alborz = new alborzBookDataContext();

            //
            var category = from c in alborz.tblCategoryBooks select c;

            cmbCategory.DataSource = category;
            cmbCategory.DisplayMember = "categoryName";
            cmbCategory.ValueMember = "categoryId";
            //
            var publisher = from p in alborz.tblPublishers select p;

            cmbPublishers.DataSource = publisher;
            cmbPublishers.DisplayMember = "publishersName";
            cmbPublishers.ValueMember = "publishersId";
            
        }

        private void btnBookN_Click(object sender, EventArgs e)
        {
            alborzBookDataContext alborz = new alborzBookDataContext();

            ErrorProvider errorProvider1 = new ErrorProvider();
            errorProvider1.Clear();
            errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
            Boolean flag = false;

            //--------------- new product ------------//

            if (btnBookN.Text == "ثبت")
            {

                if (txtBookName.Text == "")
                {
                    errorProvider1.SetError(txtBookName, "نام کتاب را وارد کنید");
                    flag = true;
                }
                if (txtPrice.Text == "")
                {
                    errorProvider1.SetError(txtPrice, "قیمت کتاب را وارد کنید");
                    flag = true;
                }
                if (txtNumber.Text == "")
                {
                    errorProvider1.SetError(txtNumber, "تعداد را وارد کنید");
                    flag = true;
                }
                if (flag == true)
                {
                    return;
                }
                else
                {

                    var result = (from u in alborz.tblBooks
                                  where txtBookName.Text == u.bookName
                                  select u).SingleOrDefault();


                    if (result != null)
                    {
                        MessageBox.Show("نام کتاب تکراری می باشد", "", MessageBoxButtons.OK,
                            MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    else
                    {

                        tblBook book = new tblBook();
                        book.bookName = txtBookName.Text;

                        if (cmbCategory.Text != "")
                        {
                            book.categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                        }
                        if (cmbPublishers.Text != "")
                        {
                            book.publishersId = Convert.ToInt32(cmbPublishers.SelectedValue);
                        }
                        if (txtPrice.Text != "")
                        {
                            book.price = long.Parse(txtPrice.Text.Replace(",", ""));
                        }
                        if (txtNumber.Text != "")
                        {
                            book.number = int.Parse(txtNumber.Text);
                        }
                        alborz.tblBooks.InsertOnSubmit(book);
                        alborz.SubmitChanges();

                        frmBookSearch frmBook = new frmBookSearch();
                        frmBook.Show();
                        this.Close();

                    }

                }

            }

            //--------------- edit product ------------//

            else if (btnBookN.Text == "ویرایش")
            {
                int id = int.Parse(txtBookId.Text);

                var result = (from u in alborz.tblBooks where u.bookId == id select u).SingleOrDefault();

                result.bookName = txtBookName.Text;
                if (cmbCategory.Text != "")
                {
                    result.categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                }
                if (cmbPublishers.Text != "")
                {
                    result.publishersId = Convert.ToInt32(cmbPublishers.SelectedValue);
                }
                if (txtPrice.Text != "")
                {
                    result.price = long.Parse(txtPrice.Text.Replace(",", "").Replace(".", ""));
                }
                if (txtNumber.Text != "")
                {
                    result.number = int.Parse(txtNumber.Text);
                }

                alborz.SubmitChanges();

                MessageBox.Show("تغییرات با موفقیت انجام شد");

                frmBookSearch frmBook = new frmBookSearch();
                frmBook.Show();
                this.Close();
            }
            


        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text != "")
            {
                
                string text = txtPrice.Text.Replace(".", "").Replace(",", "");

                
                if (long.TryParse(text, out long value))
                {
                    
                    txtPrice.Text = value.ToString("N0", new System.Globalization.CultureInfo("fa-IR"));
                    txtPrice.SelectionStart = txtPrice.Text.Length;
                }
            }
        }
    }
}
