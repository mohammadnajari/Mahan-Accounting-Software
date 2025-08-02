
namespace AlborzBook
{
    partial class frmPublisher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGridPublishers = new System.Windows.Forms.DataGridView();
            this.btnNewPublisher = new System.Windows.Forms.Button();
            this.clmPublishersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPulishersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGridPublishers)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridPublishers
            // 
            this.dGridPublishers.AllowUserToAddRows = false;
            this.dGridPublishers.AllowUserToDeleteRows = false;
            this.dGridPublishers.AllowUserToOrderColumns = true;
            this.dGridPublishers.AllowUserToResizeColumns = false;
            this.dGridPublishers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGridPublishers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridPublishers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridPublishers.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dGridPublishers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridPublishers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGridPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridPublishers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPublishersId,
            this.clmPulishersName,
            this.clmEdit,
            this.clmDelete});
            this.dGridPublishers.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridPublishers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGridPublishers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dGridPublishers.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGridPublishers.Location = new System.Drawing.Point(0, 0);
            this.dGridPublishers.Name = "dGridPublishers";
            this.dGridPublishers.ReadOnly = true;
            this.dGridPublishers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dGridPublishers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGridPublishers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGridPublishers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridPublishers.Size = new System.Drawing.Size(400, 336);
            this.dGridPublishers.TabIndex = 18;
            this.dGridPublishers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridPublishers_CellClick);
            // 
            // btnNewPublisher
            // 
            this.btnNewPublisher.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNewPublisher.Location = new System.Drawing.Point(157, 353);
            this.btnNewPublisher.Name = "btnNewPublisher";
            this.btnNewPublisher.Size = new System.Drawing.Size(108, 36);
            this.btnNewPublisher.TabIndex = 19;
            this.btnNewPublisher.Text = "افزودن";
            this.btnNewPublisher.UseVisualStyleBackColor = true;
            this.btnNewPublisher.Click += new System.EventHandler(this.btnNewPublisher_Click);
            // 
            // clmPublishersId
            // 
            this.clmPublishersId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmPublishersId.DataPropertyName = "publishersId";
            this.clmPublishersId.FillWeight = 101.5228F;
            this.clmPublishersId.HeaderText = "کد نوع انتشارات";
            this.clmPublishersId.MinimumWidth = 2;
            this.clmPublishersId.Name = "clmPublishersId";
            this.clmPublishersId.ReadOnly = true;
            this.clmPublishersId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmPulishersName
            // 
            this.clmPulishersName.DataPropertyName = "publishersName";
            this.clmPulishersName.FillWeight = 98.47716F;
            this.clmPulishersName.HeaderText = "نام انتشارات";
            this.clmPulishersName.Name = "clmPulishersName";
            this.clmPulishersName.ReadOnly = true;
            this.clmPulishersName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clmEdit
            // 
            this.clmEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            // frmPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(400, 401);
            this.Controls.Add(this.dGridPublishers);
            this.Controls.Add(this.btnNewPublisher);
            this.Name = "frmPublisher";
            this.ShowInTaskbar = false;
            this.Text = "لیست انتشارات";
            this.Load += new System.EventHandler(this.frmPublisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridPublishers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridPublishers;
        private System.Windows.Forms.Button btnNewPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPublishersId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPulishersName;
        private System.Windows.Forms.DataGridViewButtonColumn clmEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
    }
}
