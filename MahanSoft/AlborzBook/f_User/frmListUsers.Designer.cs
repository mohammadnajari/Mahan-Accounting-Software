
namespace AlborzBook
{
    partial class frmListUsers
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
            this.dGridUsers = new System.Windows.Forms.DataGridView();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridUsers
            // 
            this.dGridUsers.AllowUserToAddRows = false;
            this.dGridUsers.AllowUserToDeleteRows = false;
            this.dGridUsers.AllowUserToOrderColumns = true;
            this.dGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridUsers.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dGridUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUserName,
            this.clmRoles,
            this.clmEdit,
            this.clmDelete});
            this.dGridUsers.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGridUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dGridUsers.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGridUsers.Location = new System.Drawing.Point(0, 0);
            this.dGridUsers.Name = "dGridUsers";
            this.dGridUsers.ReadOnly = true;
            this.dGridUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dGridUsers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGridUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridUsers.Size = new System.Drawing.Size(400, 341);
            this.dGridUsers.TabIndex = 6;
            this.dGridUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridUsers_CellClick);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNewUser.Location = new System.Drawing.Point(141, 353);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(112, 36);
            this.btnNewUser.TabIndex = 10;
            this.btnNewUser.Text = "افزودن";
            this.btnNewUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // clmUserName
            // 
            this.clmUserName.DataPropertyName = "userName";
            this.clmUserName.HeaderText = "نام کاربری";
            this.clmUserName.Name = "clmUserName";
            this.clmUserName.ReadOnly = true;
            // 
            // clmRoles
            // 
            this.clmRoles.DataPropertyName = "roles";
            this.clmRoles.HeaderText = "نقش کاربر";
            this.clmRoles.Name = "clmRoles";
            this.clmRoles.ReadOnly = true;
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
            this.clmDelete.Text = "حذف";
            this.clmDelete.UseColumnTextForButtonValue = true;
            this.clmDelete.Width = 50;
            // 
            // frmListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(400, 401);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.dGridUsers);
            this.Name = "frmListUsers";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmListUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dGridUsers;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoles;
        private System.Windows.Forms.DataGridViewButtonColumn clmEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
    }
}
