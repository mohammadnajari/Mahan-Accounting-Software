
namespace AlborzBook
{
    partial class frmBookSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewBook = new System.Windows.Forms.Button();
            this.dGridBook = new System.Windows.Forms.DataGridView();
            this.clmBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPublisherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGridBook)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBookName.Location = new System.Drawing.Point(98, 35);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(202, 31);
            this.txtBookName.TabIndex = 7;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            this.txtBookName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "نام کتاب";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewBook
            // 
            this.btnNewBook.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNewBook.Location = new System.Drawing.Point(591, 32);
            this.btnNewBook.Name = "btnNewBook";
            this.btnNewBook.Size = new System.Drawing.Size(103, 36);
            this.btnNewBook.TabIndex = 5;
            this.btnNewBook.Text = "افزودن";
            this.btnNewBook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewBook.UseVisualStyleBackColor = true;
            this.btnNewBook.Click += new System.EventHandler(this.btnNewBook_Click);
            // 
            // dGridBook
            // 
            this.dGridBook.AllowUserToAddRows = false;
            this.dGridBook.AllowUserToDeleteRows = false;
            this.dGridBook.AllowUserToOrderColumns = true;
            this.dGridBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridBook.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dGridBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmBookId,
            this.clmcategoryId,
            this.clmPublisherId,
            this.clmBookName,
            this.clmPrice,
            this.clmNumber,
            this.clmEdit,
            this.clmDelete});
            this.dGridBook.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridBook.DefaultCellStyle = dataGridViewCellStyle5;
            this.dGridBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGridBook.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGridBook.Location = new System.Drawing.Point(0, 94);
            this.dGridBook.Name = "dGridBook";
            this.dGridBook.ReadOnly = true;
            this.dGridBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dGridBook.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dGridBook.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridBook.Size = new System.Drawing.Size(749, 341);
            this.dGridBook.TabIndex = 4;
            this.dGridBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridBook_CellClick);
            // 
            // clmBookId
            // 
            this.clmBookId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmBookId.DataPropertyName = "bookId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmBookId.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmBookId.FillWeight = 104.8223F;
            this.clmBookId.HeaderText = "کد کتاب";
            this.clmBookId.MinimumWidth = 2;
            this.clmBookId.Name = "clmBookId";
            this.clmBookId.ReadOnly = true;
            this.clmBookId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmBookId.Width = 50;
            // 
            // clmcategoryId
            // 
            this.clmcategoryId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmcategoryId.DataPropertyName = "categoryId";
            this.clmcategoryId.FillWeight = 202.4414F;
            this.clmcategoryId.HeaderText = "کد نوع دسته بندی";
            this.clmcategoryId.MinimumWidth = 2;
            this.clmcategoryId.Name = "clmcategoryId";
            this.clmcategoryId.ReadOnly = true;
            this.clmcategoryId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmcategoryId.Width = 87;
            // 
            // clmPublisherId
            // 
            this.clmPublisherId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmPublisherId.DataPropertyName = "publishersId";
            this.clmPublisherId.FillWeight = 180.8368F;
            this.clmPublisherId.HeaderText = "کد نوع انتشارات";
            this.clmPublisherId.MinimumWidth = 2;
            this.clmPublisherId.Name = "clmPublisherId";
            this.clmPublisherId.ReadOnly = true;
            this.clmPublisherId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmPublisherId.Width = 70;
            // 
            // clmBookName
            // 
            this.clmBookName.DataPropertyName = "bookName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmBookName.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmBookName.FillWeight = 57.61322F;
            this.clmBookName.HeaderText = "نام کتاب";
            this.clmBookName.Name = "clmBookName";
            this.clmBookName.ReadOnly = true;
            this.clmBookName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmPrice
            // 
            this.clmPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmPrice.DataPropertyName = "price";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmPrice.FillWeight = 57.61322F;
            this.clmPrice.HeaderText = "  قیمت   (ریال)";
            this.clmPrice.MinimumWidth = 2;
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            this.clmPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmPrice.Width = 70;
            // 
            // clmNumber
            // 
            this.clmNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmNumber.DataPropertyName = "number";
            this.clmNumber.FillWeight = 39.0598F;
            this.clmNumber.HeaderText = "تعداد";
            this.clmNumber.MinimumWidth = 2;
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            this.clmNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmNumber.Width = 45;
            // 
            // clmEdit
            // 
            this.clmEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmEdit.FillWeight = 50F;
            this.clmEdit.HeaderText = "ویرایش";
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            this.clmEdit.Text = "ویرایش";
            this.clmEdit.UseColumnTextForButtonValue = true;
            this.clmEdit.Width = 50;
            // 
            // clmDelete
            // 
            this.clmDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmDelete.FillWeight = 50F;
            this.clmDelete.HeaderText = "حذف";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmDelete.Text = "حذف";
            this.clmDelete.UseColumnTextForButtonValue = true;
            this.clmDelete.Width = 50;
            // 
            // frmBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(749, 435);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewBook);
            this.Controls.Add(this.dGridBook);
            this.Name = "frmBookSearch";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmBookSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewBook;
        private System.Windows.Forms.DataGridView dGridBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPublisherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewButtonColumn clmEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
    }
}
