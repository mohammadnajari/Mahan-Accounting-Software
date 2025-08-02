
namespace AlborzBook
{
    partial class frmCustomers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGridCustomers = new System.Windows.Forms.DataGridView();
            this.clmCustomersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridCustomers
            // 
            this.dGridCustomers.AllowUserToAddRows = false;
            this.dGridCustomers.AllowUserToDeleteRows = false;
            this.dGridCustomers.AllowUserToOrderColumns = true;
            this.dGridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridCustomers.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dGridCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCustomersId,
            this.clmCustomerName,
            this.clmPhoneNumber});
            this.dGridCustomers.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGridCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dGridCustomers.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGridCustomers.Location = new System.Drawing.Point(0, 0);
            this.dGridCustomers.Name = "dGridCustomers";
            this.dGridCustomers.ReadOnly = true;
            this.dGridCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dGridCustomers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGridCustomers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridCustomers.Size = new System.Drawing.Size(441, 448);
            this.dGridCustomers.TabIndex = 5;
            // 
            // clmCustomersId
            // 
            this.clmCustomersId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmCustomersId.DataPropertyName = "customersId";
            this.clmCustomersId.HeaderText = "کد مشتری";
            this.clmCustomersId.MinimumWidth = 2;
            this.clmCustomersId.Name = "clmCustomersId";
            this.clmCustomersId.ReadOnly = true;
            this.clmCustomersId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCustomersId.Width = 87;
            // 
            // clmCustomerName
            // 
            this.clmCustomerName.DataPropertyName = "customersName";
            this.clmCustomerName.HeaderText = "نام مشتری";
            this.clmCustomerName.Name = "clmCustomerName";
            this.clmCustomerName.ReadOnly = true;
            this.clmCustomerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmPhoneNumber
            // 
            this.clmPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmPhoneNumber.DataPropertyName = "customersPhoneNumber";
            this.clmPhoneNumber.HeaderText = "شماره تماس";
            this.clmPhoneNumber.Name = "clmPhoneNumber";
            this.clmPhoneNumber.ReadOnly = true;
            this.clmPhoneNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmPhoneNumber.Width = 120;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(441, 447);
            this.Controls.Add(this.dGridCustomers);
            this.Name = "frmCustomers";
            this.ShowInTaskbar = false;
            this.Text = "لیست مشتریان";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridCustomers;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomersId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNumber;
    }
}
