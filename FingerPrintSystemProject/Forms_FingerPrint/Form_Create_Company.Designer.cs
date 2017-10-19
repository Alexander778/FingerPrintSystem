namespace Forms_FingerPrint
{
    partial class Form_Create_Company
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label сompanyLogoLabel;
            this._FINGERPRINTDB_MDFDataSet = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSet();
            this.tbo_CompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbo_CompanyTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_CompanyTableAdapter();
            this.tableAdapterManager = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager();
            this.tbo_DepartmentTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_DepartmentTableAdapter();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.сompanyLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.b_LoadLogo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.b_CreateCompany = new System.Windows.Forms.Button();
            this.tbo_DepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            сompanyLogoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_CompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сompanyLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_DepartmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(24, 34);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(30, 20);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(24, 66);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // сompanyLogoLabel
            // 
            сompanyLogoLabel.AutoSize = true;
            сompanyLogoLabel.Location = new System.Drawing.Point(24, 119);
            сompanyLogoLabel.Name = "сompanyLogoLabel";
            сompanyLogoLabel.Size = new System.Drawing.Size(120, 20);
            сompanyLogoLabel.TabIndex = 4;
            сompanyLogoLabel.Text = "Сompany Logo:";
            // 
            // _FINGERPRINTDB_MDFDataSet
            // 
            this._FINGERPRINTDB_MDFDataSet.DataSetName = "_FINGERPRINTDB_MDFDataSet";
            this._FINGERPRINTDB_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbo_CompanyBindingSource
            // 
            this.tbo_CompanyBindingSource.DataMember = "tbo_Company";
            this.tbo_CompanyBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // tbo_CompanyTableAdapter
            // 
            this.tbo_CompanyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbo_CompanyTableAdapter = this.tbo_CompanyTableAdapter;
            this.tableAdapterManager.tbo_DepartmentTableAdapter = this.tbo_DepartmentTableAdapter;
            this.tableAdapterManager.tbo_LinkDepartmentUserTableAdapter = null;
            this.tableAdapterManager.tbo_ProfileTableAdapter = null;
            this.tableAdapterManager.tbo_RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbo_DepartmentTableAdapter
            // 
            this.tbo_DepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_CompanyBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(150, 31);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 26);
            this.iDTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_CompanyBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(150, 63);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 3;
            // 
            // сompanyLogoPictureBox
            // 
            this.сompanyLogoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tbo_CompanyBindingSource, "СompanyLogo", true));
            this.сompanyLogoPictureBox.Location = new System.Drawing.Point(150, 119);
            this.сompanyLogoPictureBox.Name = "сompanyLogoPictureBox";
            this.сompanyLogoPictureBox.Size = new System.Drawing.Size(100, 90);
            this.сompanyLogoPictureBox.TabIndex = 5;
            this.сompanyLogoPictureBox.TabStop = false;
            // 
            // b_LoadLogo
            // 
            this.b_LoadLogo.Location = new System.Drawing.Point(300, 174);
            this.b_LoadLogo.Name = "b_LoadLogo";
            this.b_LoadLogo.Size = new System.Drawing.Size(76, 35);
            this.b_LoadLogo.TabIndex = 7;
            this.b_LoadLogo.Text = "Load";
            this.b_LoadLogo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "*Logo must be PNG 100x100";
            // 
            // b_CreateCompany
            // 
            this.b_CreateCompany.Location = new System.Drawing.Point(128, 349);
            this.b_CreateCompany.Name = "b_CreateCompany";
            this.b_CreateCompany.Size = new System.Drawing.Size(183, 43);
            this.b_CreateCompany.TabIndex = 9;
            this.b_CreateCompany.Text = "Create";
            this.b_CreateCompany.UseVisualStyleBackColor = true;
            this.b_CreateCompany.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbo_DepartmentBindingSource
            // 
            this.tbo_DepartmentBindingSource.DataMember = "tbo_Department";
            this.tbo_DepartmentBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // Form_Create_Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 436);
            this.Controls.Add(this.b_CreateCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_LoadLogo);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(сompanyLogoLabel);
            this.Controls.Add(this.сompanyLogoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_Create_Company";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form_Create_Company_Load);
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_CompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сompanyLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_DepartmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _FINGERPRINTDB_MDFDataSet _FINGERPRINTDB_MDFDataSet;
        private System.Windows.Forms.BindingSource tbo_CompanyBindingSource;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_CompanyTableAdapter tbo_CompanyTableAdapter;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox сompanyLogoPictureBox;
        private System.Windows.Forms.Button b_LoadLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_CreateCompany;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_DepartmentTableAdapter tbo_DepartmentTableAdapter;
        private System.Windows.Forms.BindingSource tbo_DepartmentBindingSource;
    }
}