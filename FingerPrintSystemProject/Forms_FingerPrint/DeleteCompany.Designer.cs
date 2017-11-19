namespace Forms_FingerPrint
{
    partial class DeleteCompany
    {
        private string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Forms_FingerPrint.Properties.Settings.FINGERPRINTDB_DB"].ToString();

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
            this.comboBoxDeleteCompany = new System.Windows.Forms.ComboBox();
            this.IDCompanyDelete = new System.Windows.Forms.Label();
            this.comboBoxDeleteDepartments = new System.Windows.Forms.ComboBox();
            this.checkBoxDeleteAllDepartments = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IDCompanyName = new System.Windows.Forms.Label();
            this.IDDepartmentDelete = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDeleteCompany
            // 
            this.comboBoxDeleteCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeleteCompany.FormattingEnabled = true;
            this.comboBoxDeleteCompany.Location = new System.Drawing.Point(23, 27);
            this.comboBoxDeleteCompany.Name = "comboBoxDeleteCompany";
            this.comboBoxDeleteCompany.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeleteCompany.TabIndex = 0;
            this.comboBoxDeleteCompany.SelectedValueChanged += new System.EventHandler(this.comboBoxDeleteCompany_SelectedValueChanged);
            // 
            // IDCompanyDelete
            // 
            this.IDCompanyDelete.AutoSize = true;
            this.IDCompanyDelete.Location = new System.Drawing.Point(23, 65);
            this.IDCompanyDelete.Name = "IDCompanyDelete";
            this.IDCompanyDelete.Size = new System.Drawing.Size(62, 13);
            this.IDCompanyDelete.TabIndex = 1;
            this.IDCompanyDelete.Text = "IDCompany";
            // 
            // comboBoxDeleteDepartments
            // 
            this.comboBoxDeleteDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeleteDepartments.FormattingEnabled = true;
            this.comboBoxDeleteDepartments.Location = new System.Drawing.Point(23, 93);
            this.comboBoxDeleteDepartments.Name = "comboBoxDeleteDepartments";
            this.comboBoxDeleteDepartments.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeleteDepartments.TabIndex = 2;
            this.comboBoxDeleteDepartments.SelectedValueChanged += new System.EventHandler(this.comboBoxDeleteDepartments_SelectedValueChanged);
            // 
            // checkBoxDeleteAllDepartments
            // 
            this.checkBoxDeleteAllDepartments.AutoSize = true;
            this.checkBoxDeleteAllDepartments.Location = new System.Drawing.Point(23, 144);
            this.checkBoxDeleteAllDepartments.Name = "checkBoxDeleteAllDepartments";
            this.checkBoxDeleteAllDepartments.Size = new System.Drawing.Size(199, 17);
            this.checkBoxDeleteAllDepartments.TabIndex = 3;
            this.checkBoxDeleteAllDepartments.Text = "Delete company with all departments";
            this.checkBoxDeleteAllDepartments.UseVisualStyleBackColor = true;
            this.checkBoxDeleteAllDepartments.CheckedChanged += new System.EventHandler(this.checkBoxDeleteAllDepartments_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(239, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // IDCompanyName
            // 
            this.IDCompanyName.AutoSize = true;
            this.IDCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDCompanyName.Location = new System.Drawing.Point(271, 173);
            this.IDCompanyName.Name = "IDCompanyName";
            this.IDCompanyName.Size = new System.Drawing.Size(61, 24);
            this.IDCompanyName.TabIndex = 6;
            this.IDCompanyName.Text = "Name";
            // 
            // IDDepartmentDelete
            // 
            this.IDDepartmentDelete.AutoSize = true;
            this.IDDepartmentDelete.Location = new System.Drawing.Point(23, 128);
            this.IDDepartmentDelete.Name = "IDDepartmentDelete";
            this.IDDepartmentDelete.Size = new System.Drawing.Size(73, 13);
            this.IDDepartmentDelete.TabIndex = 7;
            this.IDDepartmentDelete.Text = "IDDepartment";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 221);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // DeleteCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 268);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.IDDepartmentDelete);
            this.Controls.Add(this.IDCompanyName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxDeleteAllDepartments);
            this.Controls.Add(this.comboBoxDeleteDepartments);
            this.Controls.Add(this.IDCompanyDelete);
            this.Controls.Add(this.comboBoxDeleteCompany);
            this.Name = "DeleteCompany";
            this.Text = "DeleteCompany";
            this.Load += new System.EventHandler(this.DeleteCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDeleteCompany;
        private System.Windows.Forms.Label IDCompanyDelete;
        private System.Windows.Forms.ComboBox comboBoxDeleteDepartments;
        private System.Windows.Forms.CheckBox checkBoxDeleteAllDepartments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label IDCompanyName;
        private System.Windows.Forms.Label IDDepartmentDelete;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}