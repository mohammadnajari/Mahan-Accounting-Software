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
    public partial class frmPublisher : AlborzBook.frmTemplateTable
    {
        alborzBookDataContext db = new alborzBookDataContext();
        public frmPublisher()
        {
            InitializeComponent();
            
        }

        private void frmPublisher_Load(object sender, EventArgs e)
        {
            dGridPublishers.AutoGenerateColumns = false;

            var result = from u in db.tblPublishers select u;

            dGridPublishers.DataSource = result;
        }

        private void btnNewPublisher_Click(object sender, EventArgs e)
        {
            frmNewEdit newEdit = new frmNewEdit();
            var result = (from u in db.tblPublishers where u.publishersId.ToString() == newEdit.txtId.Text select u).SingleOrDefault();
            //
            newEdit.lblId.Text = "کد نوع انتشارات";
            newEdit.lblName.Text = "نام انتشارات";
            //
            newEdit.btnSabt.Text = "ثبت انتشارات";
            newEdit.Show();

            this.Close();
        }

        private void dGridPublishers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //--------------- edit publishers ------------//

            if (e.ColumnIndex == dGridPublishers.Columns["clmEdit"].Index)
            {
                int id = int.Parse(dGridPublishers.Rows[e.RowIndex].Cells["clmPublishersId"].Value.ToString());

                var result = (from u in db.tblPublishers where u.publishersId == id select u).SingleOrDefault();
                
                frmNewEdit edit = new frmNewEdit();

                edit.txtId.Text = result.publishersId.ToString();
                edit.txtName.Text = result.publishersName;
                edit.btnSabt.Text = "ویرایش انتشارات";

                edit.Text = "ویرایش انتشارات";

                edit.Show();
                this.Close();

            }

            //--------------- delete publishers ------------//

            else if (e.ColumnIndex == dGridPublishers.Columns["clmDelete"].Index)
            {
                DialogResult x = new DialogResult();
                x = MessageBox.Show("آیا مطمئن هستید که می خواهید این انتشارات را حذف کنید؟",
                    "حذف انتشارات", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);

                if (x == DialogResult.Yes)
                {
                    int id = int.Parse(dGridPublishers.Rows[e.RowIndex].Cells["clmPublishersId"].Value.ToString());

                    var result = (from u in db.tblPublishers where u.publishersId == id select u).SingleOrDefault();

                    db.tblPublishers.DeleteOnSubmit(result);
                    db.SubmitChanges();

                    MessageBox.Show("حذف با موفقیت انجام شد", "", MessageBoxButtons.OK);

                    frmPublisher_Load(null, null);
                }

            }
        }
    }
}
