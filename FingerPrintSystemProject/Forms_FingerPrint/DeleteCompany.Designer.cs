﻿namespace Forms_FingerPrint
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDeleteCompany
            // 
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
            this.comboBoxDeleteDepartments.FormattingEnabled = true;
            this.comboBoxDeleteDepartments.Location = new System.Drawing.Point(26, 105);
            this.comboBoxDeleteDepartments.Name = "comboBoxDeleteDepartments";
            this.comboBoxDeleteDepartments.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeleteDepartments.TabIndex = 2;
            // 
            // checkBoxDeleteAllDepartments
            // 
            this.checkBoxDeleteAllDepartments.AutoSize = true;
            this.checkBoxDeleteAllDepartments.Location = new System.Drawing.Point(26, 151);
            this.checkBoxDeleteAllDepartments.Name = "checkBoxDeleteAllDepartments";
            this.checkBoxDeleteAllDepartments.Size = new System.Drawing.Size(131, 17);
            this.checkBoxDeleteAllDepartments.TabIndex = 3;
            this.checkBoxDeleteAllDepartments.Text = "Delete all departments";
            this.checkBoxDeleteAllDepartments.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            // DeleteCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 268);
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
    }
}