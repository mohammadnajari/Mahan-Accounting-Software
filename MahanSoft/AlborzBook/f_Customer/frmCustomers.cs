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
    public partial class frmCustomers : AlborzBook.frmTemplateTable
    {
        public frmCustomers()
        {
            InitializeComponent();
  
        }

        //--------------- list cusromers ------------//

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerN customerN = new frmCustomerN();
            customerN.Show();
            this.Close();
            
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            dGridCustomers.AutoGenerateColumns = false;

            alborzBookDataContext db = new alborzBookDataContext();
            var result = from u in db.tblCustomers select u;

            dGridCustomers.DataSource = result;
        }
    }
}
