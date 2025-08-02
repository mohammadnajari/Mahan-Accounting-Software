
namespace AlborzBook
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.msListUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.msBook = new System.Windows.Forms.ToolStripMenuItem();
            this.msBookSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.msCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.msNewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.msListCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msCall = new System.Windows.Forms.ToolStripMenuItem();
            this.msNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.msCheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.msExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msNewBook = new System.Windows.Forms.ToolStripMenuItem();
            this.msCategoryBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.msCategoryPublishers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msUsers,
            this.msBook,
            this.msCustomers,
            this.msHelp,
            this.msExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msUsers
            // 
            this.msUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msListUsers});
            this.msUsers.Name = "msUsers";
            this.msUsers.Size = new System.Drawing.Size(58, 21);
            this.msUsers.Text = "کاربران";
            // 
            // msListUsers
            // 
            this.msListUsers.Name = "msListUsers";
            this.msListUsers.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.msListUsers.Size = new System.Drawing.Size(193, 22);
            this.msListUsers.Text = "لیست کاربران";
            this.msListUsers.Click += new System.EventHandler(this.msListUsers_Click);
            // 
            // msBook
            // 
            this.msBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msBookSearch,
            this.msNewBook,
            this.msCategoryBooks,
            this.msCategoryPublishers});
            this.msBook.Name = "msBook";
            this.msBook.Size = new System.Drawing.Size(44, 21);
            this.msBook.Text = "کتاب";
            // 
            // msBookSearch
            // 
            this.msBookSearch.Name = "msBookSearch";
            this.msBookSearch.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.msBookSearch.Size = new System.Drawing.Size(196, 22);
            this.msBookSearch.Text = "جستجوی کتاب";
            this.msBookSearch.Click += new System.EventHandler(this.msBookSearch_Click);
            // 
            // msCustomers
            // 
            this.msCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msNewCustomer,
            this.msListCustomers});
            this.msCustomers.Name = "msCustomers";
            this.msCustomers.Size = new System.Drawing.Size(60, 21);
            this.msCustomers.Text = "مشتریان";
            // 
            // msNewCustomer
            // 
            this.msNewCustomer.Name = "msNewCustomer";
            this.msNewCustomer.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.msNewCustomer.Size = new System.Drawing.Size(171, 22);
            this.msNewCustomer.Text = "افزودن مشتری";
            this.msNewCustomer.Click += new System.EventHandler(this.msNewCustomer_Click);
            // 
            // msListCustomers
            // 
            this.msListCustomers.Name = "msListCustomers";
            this.msListCustomers.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.msListCustomers.Size = new System.Drawing.Size(171, 22);
            this.msListCustomers.Text = "لیست مشتریان";
            this.msListCustomers.Click += new System.EventHandler(this.msListCustomers_Click);
            // 
            // msHelp
            // 
            this.msHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCall,
            this.msCheckUpdate});
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(50, 21);
            this.msHelp.Text = "راهنما";
            // 
            // msCall
            // 
            this.msCall.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msNumber});
            this.msCall.Name = "msCall";
            this.msCall.Size = new System.Drawing.Size(206, 22);
            this.msCall.Text = "تماس با پشتیبانی نرم افزار";
            // 
            // msNumber
            // 
            this.msNumber.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.msNumber.Name = "msNumber";
            this.msNumber.Size = new System.Drawing.Size(164, 22);
            this.msNumber.Text = "09016386485";
            // 
            // msCheckUpdate
            // 
            this.msCheckUpdate.Name = "msCheckUpdate";
            this.msCheckUpdate.Size = new System.Drawing.Size(206, 22);
            this.msCheckUpdate.Text = "چک کردن نسخه نرم افزار";
            // 
            // msExit
            // 
            this.msExit.Name = "msExit";
            this.msExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.msExit.Size = new System.Drawing.Size(49, 21);
            this.msExit.Text = "خروج";
            this.msExit.Click += new System.EventHandler(this.msExit_Click);
            // 
            // msNewBook
            // 
            this.msNewBook.Name = "msNewBook";
            this.msNewBook.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.msNewBook.Size = new System.Drawing.Size(196, 22);
            this.msNewBook.Text = "افزودن کتاب";
            this.msNewBook.Click += new System.EventHandler(this.msNewBook_Click);
            // 
            // msCategoryBooks
            // 
            this.msCategoryBooks.Name = "msCategoryBooks";
            this.msCategoryBooks.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.msCategoryBooks.Size = new System.Drawing.Size(196, 22);
            this.msCategoryBooks.Text = "دسته بندی کتب";
            this.msCategoryBooks.Click += new System.EventHandler(this.msCategoryBooks_Click);
            // 
            // msCategoryPublishers
            // 
            this.msCategoryPublishers.Name = "msCategoryPublishers";
            this.msCategoryPublishers.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.msCategoryPublishers.Size = new System.Drawing.Size(196, 22);
            this.msCategoryPublishers.Text = "دسته بندی انتشارات";
            this.msCategoryPublishers.Click += new System.EventHandler(this.msCategoryPublishers_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1004, 637);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(1024, 680);
            this.Name = "frmMain";
            this.Text = "نرم افزار حسابداری ماهان (فروشگاه البرز)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msUsers;
        private System.Windows.Forms.ToolStripMenuItem msCustomers;
        private System.Windows.Forms.ToolStripMenuItem msHelp;
        private System.Windows.Forms.ToolStripMenuItem msExit;
        private System.Windows.Forms.ToolStripMenuItem msCall;
        private System.Windows.Forms.ToolStripMenuItem msCheckUpdate;
        private System.Windows.Forms.ToolStripMenuItem msNumber;
        private System.Windows.Forms.ToolStripMenuItem msBook;
        private System.Windows.Forms.ToolStripMenuItem msBookSearch;
        private System.Windows.Forms.ToolStripMenuItem msListUsers;
        private System.Windows.Forms.ToolStripMenuItem msNewCustomer;
        private System.Windows.Forms.ToolStripMenuItem msListCustomers;
        private System.Windows.Forms.ToolStripMenuItem msNewBook;
        private System.Windows.Forms.ToolStripMenuItem msCategoryBooks;
        private System.Windows.Forms.ToolStripMenuItem msCategoryPublishers;
    }
}
