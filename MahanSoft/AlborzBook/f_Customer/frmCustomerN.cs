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
    public partial class frmCustomerN : AlborzBook.frmTemplateNewEdit
    {
        public frmCustomerN()
        {
            InitializeComponent();
        }

        //--------------- new customer ------------//

        private void btnCustomerN_Click(object sender, EventArgs e)
        {
            
            errorProvider1.Clear();
            errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
            Boolean flag = false;
            
            if (txtCustomerNew.Text == "")
            {
                errorProvider1.SetError(txtCustomerNew, "نام مشتری را وارد کنید");
                flag = true;
            }
            if (txtPhoneNumber.Text == "")
            {
                errorProvider1.SetError(txtPhoneNumber, "شماره تماس مشتری را وارد کنید");
                flag = true;
            }
            if (flag == true)
            {
                return;
            }
            else
            {
                alborzBookDataContext db = new alborzBookDataContext();
                tblCustomer tblCustomer = new tblCustomer();

                var result = (from u in db.tblCustomers
                              where txtCustomerNew.Text == u.customersName
                              && txtPhoneNumber.Text == u.customersPhoneNumber
                              select u).SingleOrDefault();

                if (result != null)
                {

                    MessageBox.Show("! مشخصات مشتری تکرای می باشد", "",
                            MessageBoxButtons.OK, MessageBoxIcon.None,
                            MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
                    
                }
                else
                {

                    tblCustomer.customersName = txtCustomerNew.Text;
                    tblCustomer.customersPhoneNumber = txtPhoneNumber.Text;

                    db.tblCustomers.InsertOnSubmit(tblCustomer);
                    db.SubmitChanges();

                    frmCustomers frmCustomers = new frmCustomers();
                    frmCustomers.Show();

                    this.Close();
                }
            }
            
        }

        private void txtCustomerNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if(e.KeyChar=='!'||e.KeyChar=='?'|| e.KeyChar == '@' 
                || e.KeyChar == '#'|| e.KeyChar == '$' || e.KeyChar == '%' || e.KeyChar=='*'
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

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) 
            {
                e.Handled = true;
            }
            if (e.KeyChar==' ')
            {
                e.Handled = true;
            }
        }

        private void frmCustomerN_Load(object sender, EventArgs e)
        {

        }
    }
}
