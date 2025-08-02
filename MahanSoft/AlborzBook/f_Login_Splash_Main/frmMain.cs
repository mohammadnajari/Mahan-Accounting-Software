using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlborzBook
{
    public partial class frmMain : AlborzBook.frmTemplate
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void msExit_Click(object sender, EventArgs e)
        {
            DialogResult x = new DialogResult();
            x = MessageBox.Show("آیا می خواهید خارج شوید ؟", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.None, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign |
                MessageBoxOptions.RtlReading);

            if(x==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void msNewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerN newCustomer = new frmCustomerN();
            newCustomer.Show();
        }
        private void msListCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers customers = new frmCustomers();
            customers.Show();
        }

        private void msBookSearch_Click(object sender, EventArgs e)
        {
            frmBookSearch bookSearch = new frmBookSearch();
            bookSearch.Show();
        }

        private void msNewBook_Click(object sender, EventArgs e)
        {
            frmNewBook newBook = new frmNewBook();
            newBook.Show();
        }

        private void msCategoryBooks_Click(object sender, EventArgs e)
        {
            frmCategoruBooks categoruBooks = new frmCategoruBooks();
            categoruBooks.Show();
        }

        private void msCategoryPublishers_Click(object sender, EventArgs e)
        {
            frmPublisher publisher = new frmPublisher();
            publisher.Show();
        }

        private void msListUsers_Click(object sender, EventArgs e)
        {
            frmLoginListUsers loginListUsers = new frmLoginListUsers();
            loginListUsers.Show(); 
        }
    }
}
