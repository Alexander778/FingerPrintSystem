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
            System.Windows.Forms.Label nameLabel;
            this.tbo_CompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FINGERPRINTDB_MDFDataSet = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSet();
            this.b_LoadLogo = new System.Windows.Forms.Button();
            this.b_CreateCompany = new System.Windows.Forms.Button();
            this.tbo_DepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbo_RoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbo_CompanyTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_CompanyTableAdapter();
            this.tableAdapterManager = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager();
            this.tbo_DepartmentTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_DepartmentTableAdapter();
            this.tbo_RoleTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_RoleTableAdapter();
            this.tbo_DepartmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbo_RoleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbo_CompanyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.companyLogoPictureBox = new System.Windows.Forms.PictureBox();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_CompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_DepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_RoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_DepartmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_RoleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_CompanyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(25, 106);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 57;
            nameLabel.Text = "Name:";
            // 
            // tbo_CompanyBindingSource
            // 
            this.tbo_CompanyBindingSource.DataMember = "tbo_Company";
            this.tbo_CompanyBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // _FINGERPRINTDB_MDFDataSet
            // 
            this._FINGERPRINTDB_MDFDataSet.DataSetName = "_FINGERPRINTDB_MDFDataSet1";
            this._FINGERPRINTDB_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b_LoadLogo
            // 
            this.b_LoadLogo.Enabled = false;
            this.b_LoadLogo.Location = new System.Drawing.Point(226, 168);
            this.b_LoadLogo.Margin = new System.Windows.Forms.Padding(2);
            this.b_LoadLogo.Name = "b_LoadLogo";
            this.b_LoadLogo.Size = new System.Drawing.Size(51, 23);
            this.b_LoadLogo.TabIndex = 7;
            this.b_LoadLogo.Text = "Load";
            this.b_LoadLogo.UseVisualStyleBackColor = true;
            this.b_LoadLogo.Click += new System.EventHandler(this.b_LoadLogo_Click);
            // 
            // b_CreateCompany
            // 
            this.b_CreateCompany.Location = new System.Drawing.Point(21, 31);
            this.b_CreateCompany.Margin = new System.Windows.Forms.Padding(2);
            this.b_CreateCompany.Name = "b_CreateCompany";
            this.b_CreateCompany.Size = new System.Drawing.Size(89, 28);
            this.b_CreateCompany.TabIndex = 9;
            this.b_CreateCompany.Text = "Add Company";
            this.b_CreateCompany.UseVisualStyleBackColor = true;
            this.b_CreateCompany.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please write information about your company";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(20, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 21);
            this.button1.TabIndex = 12;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(20, 218);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 27);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(203, 127);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 21);
            this.button3.TabIndex = 14;
            this.button3.Text = "Remove company";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(166, 229);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Show result";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Forms_FingerPrint.Properties.Resources.Восклицательный_знак;
            this.pictureBox1.Location = new System.Drawing.Point(192, 174);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.tableAdapterManager.tbo_RoleTableAdapter = this.tbo_RoleTableAdapter;
            this.tableAdapterManager.UpdateOrder = Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbo_DepartmentTableAdapter
            // 
            this.tbo_DepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // tbo_RoleTableAdapter
            // 
            this.tbo_RoleTableAdapter.ClearBeforeFill = true;
            // 
            // tbo_DepartmentBindingSource1
            // 
            this.tbo_DepartmentBindingSource1.DataMember = "tbo_Department";
            this.tbo_DepartmentBindingSource1.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // tbo_RoleBindingSource1
            // 
            this.tbo_RoleBindingSource1.DataMember = "tbo_Role";
            this.tbo_RoleBindingSource1.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // tbo_CompanyDataGridView
            // 
            this.tbo_CompanyDataGridView.AutoGenerateColumns = false;
            this.tbo_CompanyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbo_CompanyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn2});
            this.tbo_CompanyDataGridView.DataSource = this.tbo_CompanyBindingSource;
            this.tbo_CompanyDataGridView.Location = new System.Drawing.Point(325, 26);
            this.tbo_CompanyDataGridView.Name = "tbo_CompanyDataGridView";
            this.tbo_CompanyDataGridView.Size = new System.Drawing.Size(344, 220);
            this.tbo_CompanyDataGridView.TabIndex = 57;
            this.tbo_CompanyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbo_CompanyDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "CompanyLogo";
            this.dataGridViewImageColumn2.HeaderText = "CompanyLogo";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_CompanyBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(69, 103);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 58;
            // 
            // companyLogoPictureBox
            // 
            this.companyLogoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tbo_CompanyBindingSource, "CompanyLogo", true));
            this.companyLogoPictureBox.Location = new System.Drawing.Point(69, 129);
            this.companyLogoPictureBox.Name = "companyLogoPictureBox";
            this.companyLogoPictureBox.Size = new System.Drawing.Size(100, 84);
            this.companyLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.companyLogoPictureBox.TabIndex = 59;
            this.companyLogoPictureBox.TabStop = false;
            // 
            // Form_Create_Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 345);
            this.Controls.Add(this.companyLogoPictureBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.tbo_CompanyDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_CreateCompany);
            this.Controls.Add(this.b_LoadLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Create_Company";
            this.Text = "FingerPrintSystem::Creating Company";
            this.Load += new System.EventHandler(this.Form_Create_Company_Load);
            this.VisibleChanged += new System.EventHandler(this.Form_Create_Company_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.tbo_CompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_DepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_RoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_DepartmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_RoleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_CompanyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tbo_CompanyBindingSource;
        private System.Windows.Forms.Button b_LoadLogo;
        private System.Windows.Forms.Button b_CreateCompany;
        private System.Windows.Forms.BindingSource tbo_DepartmentBindingSource;
        private System.Windows.Forms.BindingSource tbo_RoleBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private _FINGERPRINTDB_MDFDataSet _FINGERPRINTDB_MDFDataSet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_CompanyTableAdapter tbo_CompanyTableAdapter;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_DepartmentTableAdapter tbo_DepartmentTableAdapter;
        private System.Windows.Forms.BindingSource tbo_DepartmentBindingSource1;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_RoleTableAdapter tbo_RoleTableAdapter;
        private System.Windows.Forms.BindingSource tbo_RoleBindingSource1;
        private System.Windows.Forms.DataGridView tbo_CompanyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox companyLogoPictureBox;
    }
}