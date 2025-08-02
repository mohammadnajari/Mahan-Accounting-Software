
namespace AlborzBook
{
    partial class frmCategoruBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.dGridCategory = new System.Windows.Forms.DataGridView();
            this.clmCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGridCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNewCategory.Location = new System.Drawing.Point(155, 353);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(108, 36);
            this.btnNewCategory.TabIndex = 5;
            this.btnNewCategory.Text = "افزودن";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // dGridCategory
            // 
            this.dGridCategory.AllowUserToAddRows = false;
            this.dGridCategory.AllowUserToDeleteRows = false;
            this.dGridCategory.AllowUserToOrderColumns = true;
            this.dGridCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridCategory.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dGridCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCategoryId,
            this.clmCategoryName,
            this.clmEdit,
            this.clmDelete});
            this.dGridCategory.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGridCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.dGridCategory.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGridCategory.Location = new System.Drawing.Point(0, 0);
            this.dGridCategory.Name = "dGridCategory";
            this.dGridCategory.ReadOnly = true;
            this.dGridCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dGridCategory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGridCategory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridCategory.Size = new System.Drawing.Size(400, 331);
            this.dGridCategory.TabIndex = 4;
            this.dGridCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridCategory_CellClick);
            // 
            // clmCategoryId
            // 
            this.clmCategoryId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmCategoryId.DataPropertyName = "categoryId";
            this.clmCategoryId.HeaderText = "کد نوع دسته بندی";
            this.clmCategoryId.MinimumWidth = 2;
            this.clmCategoryId.Name = "clmCategoryId";
            this.clmCategoryId.ReadOnly = true;
            this.clmCategoryId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCategoryId.Width = 90;
            // 
            // clmCategoryName
            // 
            this.clmCategoryName.DataPropertyName = "categoryName";
            this.clmCategoryName.HeaderText = "نام نوع دسته بندی";
            this.clmCategoryName.Name = "clmCategoryName";
            this.clmCategoryName.ReadOnly = true;
            this.clmCategoryName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmEdit
            // 
            this.clmEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clmEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmEdit.HeaderText = "ویرایش";
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            this.clmEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmEdit.Text = "ویرایش";
            this.clmEdit.UseColumnTextForButtonValue = true;
            this.clmEdit.Width = 50;
            // 
            // clmDelete
            // 
            this.clmDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmDelete.HeaderText = "حذف";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmDelete.Text = "حذف";
            this.clmDelete.UseColumnTextForButtonValue = true;
            this.clmDelete.Width = 50;
            // 
            // frmCategoruBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(400, 401);
            this.Controls.Add(this.btnNewCategory);
            this.Controls.Add(this.dGridCategory);
            this.Name = "frmCategoruBooks";
            this.ShowInTaskbar = false;
            this.Text = "دسته بندی کتب";
            this.Load += new System.EventHandler(this.frmCategoryBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.DataGridView dGridCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoryName;
        private System.Windows.Forms.DataGridViewButtonColumn clmEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
    }
}
