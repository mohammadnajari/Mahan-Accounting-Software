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
    public partial class frmBookSearch : AlborzBook.frmTemplateTable
    {
        public frmBookSearch()
        {
            InitializeComponent();

            dGridBook.AutoGenerateColumns = false;

            alborzBookDataContext alborzBook = new alborzBookDataContext();
            var result = from u in alborzBook.tblBooks select u;

            dGridBook.DataSource = result;
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

        private void frmBookSearch_Load(object sender, EventArgs e)
        {
            
           


        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            alborzBookDataContext alborzBook = new alborzBookDataContext();
            var result = from u in alborzBook.tblBooks
                         where u.bookName.IndexOf(txtBookName.Text) > -1
                         select u;

            dGridBook.DataSource = result;
                        
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            frmNewBook newBook = new frmNewBook();
            newBook.Show();
            this.Close();
        }

        private void dGridBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            alborzBookDataContext db = new alborzBookDataContext();

            //--------------- edit product ------------//

            if (e.ColumnIndex==dGridBook.Columns["clmEdit"].Index)
            {

                int id = int.Parse(dGridBook.Rows[e.RowIndex].Cells["clmBookId"].Value.ToString());

                var result = (from u in db.tblBooks where u.bookId == id select u).SingleOrDefault();

                frmNewBook newBook = new frmNewBook();

                newBook.txtBookId.Text = result.bookId.ToString();
                newBook.txtBookName.Text = result.bookName;
                newBook.cmbCategory.Text = result.categoryId.ToString();
                newBook.cmbPublishers.Text = result.publishersId.ToString();
                newBook.txtPrice.Text = result.price.ToString();
                newBook.txtNumber.Text = result.number.ToString();
                newBook.btnBookN.Text = "ویرایش";

                newBook.Show();
                this.Close();

            }

            //--------------- delete product ------------//

            else if (e.ColumnIndex == dGridBook.Columns["clmDelete"].Index)
            {
                DialogResult x = new DialogResult();
                x = MessageBox.Show("آیا مطمئن هستید که می خواهید این کتاب را حذف کنید؟",
                    "حذف کتاب", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);

                if (x == DialogResult.Yes)
                {
                    
                    
                    int id = int.Parse(dGridBook.Rows[e.RowIndex].Cells["clmBookId"].Value.ToString());

                    var result=(from u in db.tblBooks where u.bookId==id select u).SingleOrDefault();

                    db.tblBooks.DeleteOnSubmit(result);
                    db.SubmitChanges();

                    MessageBox.Show("حذف با موفقیت انجام شد", "", MessageBoxButtons.OK);

                    txtBookName_TextChanged(null, null);
                        
                }

            }
        }
    }
}
