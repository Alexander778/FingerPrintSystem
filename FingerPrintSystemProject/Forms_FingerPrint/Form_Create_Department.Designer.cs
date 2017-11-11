namespace Forms_FingerPrint
{
    partial class Form_Create_Department
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
            System.Windows.Forms.Label companyIDLabel;
            System.Windows.Forms.Label regimeLabel;
            this.tbo_DepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FINGERPRINTDB_MDFDataSet = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSet();
            this.tbo_RoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbo_ProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbo_DepartmentDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._FINGERPRINTDB_MDFDataSet1 = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbo_DepartmentTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_DepartmentTableAdapter();
            this.tableAdapterManager = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager();
            this.tbo_CompanyTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_CompanyTableAdapter();
            this.tbo_ProfileTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_ProfileTableAdapter();
            this.tbo_RoleTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_RoleTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.regimeTextBox = new System.Windows.Forms.TextBox();
            this._FINGERPRINTDB_MDFDataSet2 = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSet();
            this.tboCompanyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companyIDComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameLabel = new System.Windows.Forms.Label();
            companyIDLabel = new System.Windows.Forms.Label();
            regimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_DepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_RoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_ProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_DepartmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(9, 92);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 61;
            nameLabel.Text = "Name:";
            // 
            // companyIDLabel
            // 
            companyIDLabel.AutoSize = true;
            companyIDLabel.Location = new System.Drawing.Point(9, 118);
            companyIDLabel.Name = "companyIDLabel";
            companyIDLabel.Size = new System.Drawing.Size(68, 13);
            companyIDLabel.TabIndex = 63;
            companyIDLabel.Text = "Company ID:";
            // 
            // regimeLabel
            // 
            regimeLabel.AutoSize = true;
            regimeLabel.Location = new System.Drawing.Point(9, 145);
            regimeLabel.Name = "regimeLabel";
            regimeLabel.Size = new System.Drawing.Size(46, 13);
            regimeLabel.TabIndex = 65;
            regimeLabel.Text = "Regime:";
            // 
            // tbo_DepartmentBindingSource
            // 
            this.tbo_DepartmentBindingSource.DataMember = "tbo_Department";
            this.tbo_DepartmentBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // _FINGERPRINTDB_MDFDataSet
            // 
            this._FINGERPRINTDB_MDFDataSet.DataSetName = "_FINGERPRINTDB_MDFDataSet";
            this._FINGERPRINTDB_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbo_RoleBindingSource
            // 
            this.tbo_RoleBindingSource.DataMember = "tbo_Role";
            this.tbo_RoleBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // tbo_ProfileBindingSource
            // 
            this.tbo_ProfileBindingSource.DataMember = "tbo_Profile";
            this.tbo_ProfileBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // tbo_DepartmentDataGridView
            // 
            this.tbo_DepartmentDataGridView.AutoGenerateColumns = false;
            this.tbo_DepartmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbo_DepartmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tbo_DepartmentDataGridView.DataSource = this.tbo_DepartmentBindingSource;
            this.tbo_DepartmentDataGridView.Location = new System.Drawing.Point(227, 18);
            this.tbo_DepartmentDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.tbo_DepartmentDataGridView.Name = "tbo_DepartmentDataGridView";
            this.tbo_DepartmentDataGridView.RowTemplate.Height = 28;
            this.tbo_DepartmentDataGridView.Size = new System.Drawing.Size(442, 288);
            this.tbo_DepartmentDataGridView.TabIndex = 8;
            this.tbo_DepartmentDataGridView.Visible = false;
            this.tbo_DepartmentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbo_DepartmentDataGridView_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Department";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please write information about department";
            this.label1.Visible = false;
            // 
            // tboCompanyBindingSource
            // 
            this.tboCompanyBindingSource.DataMember = "tbo_Company";
            this.tboCompanyBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet1;
            // 
            // _FINGERPRINTDB_MDFDataSet1
            // 
            this._FINGERPRINTDB_MDFDataSet1.DataSetName = "_FINGERPRINTDB_MDFDataSet";
            this._FINGERPRINTDB_MDFDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(20, 184);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(119, 184);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(57, 223);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Show result";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Forms_FingerPrint.Properties.Resources.Восклицательный_знак;
            this.pictureBox1.Location = new System.Drawing.Point(175, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // tbo_DepartmentTableAdapter
            // 
            this.tbo_DepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbo_CompanyTableAdapter = this.tbo_CompanyTableAdapter;
            this.tableAdapterManager.tbo_DepartmentTableAdapter = this.tbo_DepartmentTableAdapter;
            this.tableAdapterManager.tbo_LinkDepartmentUserTableAdapter = null;
            this.tableAdapterManager.tbo_ProfileTableAdapter = this.tbo_ProfileTableAdapter;
            this.tableAdapterManager.tbo_RoleTableAdapter = this.tbo_RoleTableAdapter;
            this.tableAdapterManager.UpdateOrder = Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbo_CompanyTableAdapter
            // 
            this.tbo_CompanyTableAdapter.ClearBeforeFill = true;
            // 
            // tbo_ProfileTableAdapter
            // 
            this.tbo_ProfileTableAdapter.ClearBeforeFill = true;
            // 
            // tbo_RoleTableAdapter
            // 
            this.tbo_RoleTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(57, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 59;
            this.button2.Text = "Finish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_DepartmentBindingSource, "Name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(83, 85);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(110, 20);
            this.nameTextBox.TabIndex = 62;
            // 
            // regimeTextBox
            // 
            this.regimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_DepartmentBindingSource, "Regime", true));
            this.regimeTextBox.Enabled = false;
            this.regimeTextBox.Location = new System.Drawing.Point(83, 142);
            this.regimeTextBox.Name = "regimeTextBox";
            this.regimeTextBox.Size = new System.Drawing.Size(110, 20);
            this.regimeTextBox.TabIndex = 66;
            // 
            // _FINGERPRINTDB_MDFDataSet2
            // 
            this._FINGERPRINTDB_MDFDataSet2.DataSetName = "_FINGERPRINTDB_MDFDataSet";
            this._FINGERPRINTDB_MDFDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tboCompanyBindingSource1
            // 
            this.tboCompanyBindingSource1.DataMember = "tbo_Company";
            this.tboCompanyBindingSource1.DataSource = this._FINGERPRINTDB_MDFDataSet2;
            // 
            // companyIDComboBox
            // 
            this.companyIDComboBox.Cursor = System.Windows.Forms.Cursors.No;
            this.companyIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbo_DepartmentBindingSource, "CompanyID", true));
            this.companyIDComboBox.DataSource = this.tboCompanyBindingSource1;
            this.companyIDComboBox.DisplayMember = "Name";
            this.companyIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyIDComboBox.Enabled = false;
            this.companyIDComboBox.FormattingEnabled = true;
            this.companyIDComboBox.Location = new System.Drawing.Point(89, 110);
            this.companyIDComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.companyIDComboBox.Name = "companyIDComboBox";
            this.companyIDComboBox.Size = new System.Drawing.Size(82, 21);
            this.companyIDComboBox.TabIndex = 67;
            this.companyIDComboBox.ValueMember = "ID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Department";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CompanyID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID Company";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Regime";
            this.dataGridViewTextBoxColumn4.HeaderText = "Regime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form_Create_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 326);
            this.Controls.Add(this.companyIDComboBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(companyIDLabel);
            this.Controls.Add(regimeLabel);
            this.Controls.Add(this.regimeTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbo_DepartmentDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Create_Department";
            this.Text = "FingerPrintSystem::Add Departments";
            this.Load += new System.EventHandler(this.Form_Create_Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbo_DepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_RoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_ProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_DepartmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _FINGERPRINTDB_MDFDataSet _FINGERPRINTDB_MDFDataSet;
        private System.Windows.Forms.BindingSource tbo_RoleBindingSource;
        private System.Windows.Forms.BindingSource tbo_ProfileBindingSource;
        private System.Windows.Forms.BindingSource tbo_DepartmentBindingSource;
        private System.Windows.Forms.DataGridView tbo_DepartmentDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private _FINGERPRINTDB_MDFDataSet _FINGERPRINTDB_MDFDataSet1;
        private System.Windows.Forms.BindingSource tboCompanyBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_DepartmentTableAdapter tbo_DepartmentTableAdapter;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_RoleTableAdapter tbo_RoleTableAdapter;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_ProfileTableAdapter tbo_ProfileTableAdapter;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_CompanyTableAdapter tbo_CompanyTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox regimeTextBox;
        private _FINGERPRINTDB_MDFDataSet _FINGERPRINTDB_MDFDataSet2;
        private System.Windows.Forms.BindingSource tboCompanyBindingSource1;
        private System.Windows.Forms.ComboBox companyIDComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}