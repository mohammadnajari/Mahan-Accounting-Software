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
    public partial class frmCategoruBooks : AlborzBook.frmTemplateTable
    {
        alborzBookDataContext db = new alborzBookDataContext();

        public frmCategoruBooks()
        {
            InitializeComponent();

            
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            frmNewEdit newEdit = new frmNewEdit();
            var result = (from u in db.tblCategoryBooks
                          where u.categoryId.ToString() == newEdit.txtId.Text
                          select u).SingleOrDefault();
            //
            newEdit.lblId.Text = "کد نوع دسته بندی";
            newEdit.lblName.Text = "نام دسته بندی";
            newEdit.btnSabt.Text = "ثبت";
            newEdit.Text = "افزودن دسته بندی";

            newEdit.Show();

            this.Close();

        }

        private void frmCategoryBooks_Load(object sender, EventArgs e)
        {
            dGridCategory.AutoGenerateColumns = false;

            var result = (from u in db.tblCategoryBooks select u);

            dGridCategory.DataSource = result;
        }

        private void dGridCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            alborzBookDataContext db = new alborzBookDataContext();

            //--------------- edit category books ------------//

            if (e.ColumnIndex == dGridCategory.Columns["clmEdit"].Index)
            {

                int id = int.Parse(dGridCategory.Rows[e.RowIndex].Cells["clmCategoryId"].Value.ToString());

                var result = (from u in db.tblCategoryBooks where u.categoryId == id select u).SingleOrDefault();

                frmNewEdit edit = new frmNewEdit();

                edit.txtId.Text = result.categoryId.ToString();
                edit.txtName.Text = result.categoryName;
                edit.btnSabt.Text = "ویرایش";
                edit.Text = "ویرایش دسته بندی";

                edit.Show();
                this.Close();

            }

            //--------------- delete category books ------------//

            else if (e.ColumnIndex == dGridCategory.Columns["clmDelete"].Index)
            {
                DialogResult x = new DialogResult();
                x = MessageBox.Show("آیا مطمئن هستید که می خواهید این دسته بندی را حذف کنید؟",
                    "حذف دسته بندی", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);

                if (x == DialogResult.Yes)
                {

                    int id = int.Parse(dGridCategory.Rows[e.RowIndex].Cells["clmCategoryId"].Value.ToString());

                    var result = (from u in db.tblCategoryBooks where u.categoryId == id select u).SingleOrDefault();

                    db.tblCategoryBooks.DeleteOnSubmit(result);
                    db.SubmitChanges();

                    MessageBox.Show("حذف با موفقیت انجام شد", "", MessageBoxButtons.OK);

                    frmCategoryBooks_Load(null, null);
                }

            }
        }
    }
}
