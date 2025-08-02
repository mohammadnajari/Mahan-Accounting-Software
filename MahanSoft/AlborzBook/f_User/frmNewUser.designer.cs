
namespace AlborzBook
{
    partial class frmNewUser
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
            this.lblRePass2 = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblRePass = new System.Windows.Forms.Label();
            this.txtReNewPass = new System.Windows.Forms.TextBox();
            this.txtCurentPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rBtnSenior = new System.Windows.Forms.RadioButton();
            this.rBtnNormal = new System.Windows.Forms.RadioButton();
            this.gbRole = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRePass2
            // 
            this.lblRePass2.AutoSize = true;
            this.lblRePass2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRePass2.Location = new System.Drawing.Point(66, 223);
            this.lblRePass2.Name = "lblRePass2";
            this.lblRePass2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRePass2.Size = new System.Drawing.Size(122, 19);
            this.lblRePass2.TabIndex = 54;
            this.lblRePass2.Text = "تکرار رمز عبور جدید";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(66, 113);
            this.lblPass.Name = "lblPass";
            this.lblPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPass.Size = new System.Drawing.Size(87, 19);
            this.lblPass.TabIndex = 55;
            this.lblPass.Text = "رمز عبور قبلی";
            // 
            // lblRePass
            // 
            this.lblRePass.AutoSize = true;
            this.lblRePass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRePass.Location = new System.Drawing.Point(66, 169);
            this.lblRePass.Name = "lblRePass";
            this.lblRePass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRePass.Size = new System.Drawing.Size(87, 19);
            this.lblRePass.TabIndex = 56;
            this.lblRePass.Text = "رمز عبور جدید";
            // 
            // txtReNewPass
            // 
            this.txtReNewPass.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReNewPass.Location = new System.Drawing.Point(209, 220);
            this.txtReNewPass.Name = "txtReNewPass";
            this.txtReNewPass.PasswordChar = '•';
            this.txtReNewPass.Size = new System.Drawing.Size(114, 26);
            this.txtReNewPass.TabIndex = 49;
            this.txtReNewPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReNewPass_KeyPress);
            // 
            // txtCurentPass
            // 
            this.txtCurentPass.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurentPass.Location = new System.Drawing.Point(209, 110);
            this.txtCurentPass.Name = "txtCurentPass";
            this.txtCurentPass.PasswordChar = '•';
            this.txtCurentPass.Size = new System.Drawing.Size(114, 26);
            this.txtCurentPass.TabIndex = 47;
            this.txtCurentPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReNewPass_KeyPress);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(209, 166);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '•';
            this.txtNewPass.Size = new System.Drawing.Size(114, 26);
            this.txtNewPass.TabIndex = 48;
            this.txtNewPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReNewPass_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(326, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 32);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(473, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 32);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(210, 52);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(113, 26);
            this.txtUserName.TabIndex = 46;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReNewPass_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 55);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 53;
            this.label4.Text = "نام کاربری";
            // 
            // rBtnSenior
            // 
            this.rBtnSenior.AutoSize = true;
            this.rBtnSenior.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rBtnSenior.Location = new System.Drawing.Point(49, 37);
            this.rBtnSenior.Name = "rBtnSenior";
            this.rBtnSenior.Size = new System.Drawing.Size(85, 23);
            this.rBtnSenior.TabIndex = 5;
            this.rBtnSenior.TabStop = true;
            this.rBtnSenior.Text = "کاربر ارشد";
            this.rBtnSenior.UseVisualStyleBackColor = true;
            // 
            // rBtnNormal
            // 
            this.rBtnNormal.AutoSize = true;
            this.rBtnNormal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rBtnNormal.Location = new System.Drawing.Point(36, 87);
            this.rBtnNormal.Name = "rBtnNormal";
            this.rBtnNormal.Size = new System.Drawing.Size(98, 23);
            this.rBtnNormal.TabIndex = 6;
            this.rBtnNormal.TabStop = true;
            this.rBtnNormal.Text = "کاربر عمومی";
            this.rBtnNormal.UseVisualStyleBackColor = true;
            // 
            // gbRole
            // 
            this.gbRole.Controls.Add(this.rBtnSenior);
            this.gbRole.Controls.Add(this.rBtnNormal);
            this.gbRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbRole.Location = new System.Drawing.Point(439, 55);
            this.gbRole.Name = "gbRole";
            this.gbRole.Size = new System.Drawing.Size(147, 137);
            this.gbRole.TabIndex = 50;
            this.gbRole.TabStop = false;
            this.gbRole.Text = "نقش کاربر";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.ClientSize = new System.Drawing.Size(652, 395);
            this.Controls.Add(this.lblRePass2);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblRePass);
            this.Controls.Add(this.txtReNewPass);
            this.Controls.Add(this.txtCurentPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbRole);
            this.Name = "frmNewUser";
            this.gbRole.ResumeLayout(false);
            this.gbRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbRole;
        public System.Windows.Forms.Label lblRePass2;
        public System.Windows.Forms.Label lblPass;
        public System.Windows.Forms.Label lblRePass;
        public System.Windows.Forms.TextBox txtReNewPass;
        public System.Windows.Forms.TextBox txtCurentPass;
        public System.Windows.Forms.TextBox txtNewPass;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.RadioButton rBtnSenior;
        public System.Windows.Forms.RadioButton rBtnNormal;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
