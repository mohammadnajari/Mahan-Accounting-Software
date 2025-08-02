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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Step = progressBar1.Step - 1;
            if (progressBar1.Step <= 1)
            {
                timer1.Stop();
                frmSplash.ActiveForm.Hide();
                frmLogin frm = new frmLogin();
                frm.Show();
            }
        }
    }
}
