using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AlborzBook
{
    public partial class frmTemplate : Form
    {
        public frmTemplate()
        {
            InitializeComponent();
        }

        private void frmTemplate_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            PersianCalendar pc = new PersianCalendar();

            lblDate.Text = pc.GetYear(dt).ToString("0000/") + pc.GetMonth(dt).ToString("00/") +
                pc.GetDayOfMonth(dt).ToString("00");

            lblTime.Text = pc.GetHour(dt).ToString("00:") + pc.GetMinute(dt).ToString("00");

            string DayName = "";

            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    DayName = " شنبه ";
                    break;
                case DayOfWeek.Sunday:
                    DayName = " یکشنبه ";
                    break;
                case DayOfWeek.Monday:
                    DayName = " دوشنبه ";
                    break;
                case DayOfWeek.Tuesday:
                    DayName = " سه شنبه ";
                    break;
                case DayOfWeek.Wednesday:
                    DayName = " چهارشنبه ";
                    break;
                case DayOfWeek.Thursday:
                    DayName = " پنج شنبه ";
                    break;
                case DayOfWeek.Friday:
                    DayName = " جمـــعه ";
                    break;
            }

            string fullPersianDate = DayName;
            lblDay.Text = fullPersianDate;
        }
    }
}
