namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label company_IDLabel;
            System.Windows.Forms.Label user_IDLabel;
            System.Windows.Forms.Label nameCompanyLabel;
            System.Windows.Forms.Label employeesLabel;
            this._FINGERPRINTDB_MDFDataSet = new WindowsFormsApplication1._FINGERPRINTDB_MDFDataSet();
            this.tbo_CompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbo_CompanyTableAdapter = new WindowsFormsApplication1._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_CompanyTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1._FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager();
            this.tbo_CompanyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.company_IDTextBox = new System.Windows.Forms.TextBox();
            this.user_IDTextBox = new System.Windows.Forms.TextBox();
            this.nameCompanyTextBox = new System.Windows.Forms.TextBox();
            this.employeesTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            company_IDLabel = new System.Windows.Forms.Label();
            user_IDLabel = new System.Windows.Forms.Label();
            nameCompanyLabel = new System.Windows.Forms.Label();
            employeesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_CompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_CompanyDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.tbo_ConnectPrDeTableAdapter = null;
            this.tableAdapterManager.tbo_DepartmentTableAdapter = null;
            this.tableAdapterManager.tbo_ProfileTableAdapter = null;
            this.tableAdapterManager.tbo_UserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1._FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbo_CompanyDataGridView
            // 
            this.tbo_CompanyDataGridView.AutoGenerateColumns = false;
            this.tbo_CompanyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbo_CompanyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewImageColumn1});
            this.tbo_CompanyDataGridView.DataSource = this.tbo_CompanyBindingSource;
            this.tbo_CompanyDataGridView.Location = new System.Drawing.Point(366, 243);
            this.tbo_CompanyDataGridView.Name = "tbo_CompanyDataGridView";
            this.tbo_CompanyDataGridView.RowTemplate.Height = 28;
            this.tbo_CompanyDataGridView.Size = new System.Drawing.Size(542, 182);
            this.tbo_CompanyDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Company_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Company_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "User_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "User_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NameCompany";
            this.dataGridViewTextBoxColumn3.HeaderText = "NameCompany";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Employees";
            this.dataGridViewTextBoxColumn4.HeaderText = "Employees";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Emblem";
            this.dataGridViewImageColumn1.HeaderText = "Emblem";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // company_IDLabel
            // 
            company_IDLabel.AutoSize = true;
            company_IDLabel.Location = new System.Drawing.Point(22, 46);
            company_IDLabel.Name = "company_IDLabel";
            company_IDLabel.Size = new System.Drawing.Size(101, 20);
            company_IDLabel.TabIndex = 2;
            company_IDLabel.Text = "Company ID:";
            // 
            // company_IDTextBox
            // 
            this.company_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_CompanyBindingSource, "Company_ID", true));
            this.company_IDTextBox.Location = new System.Drawing.Point(154, 43);
            this.company_IDTextBox.Name = "company_IDTextBox";
            this.company_IDTextBox.Size = new System.Drawing.Size(100, 26);
            this.company_IDTextBox.TabIndex = 3;
            // 
            // user_IDLabel
            // 
            user_IDLabel.AutoSize = true;
            user_IDLabel.Location = new System.Drawing.Point(22, 78);
            user_IDLabel.Name = "user_IDLabel";
            user_IDLabel.Size = new System.Drawing.Size(68, 20);
            user_IDLabel.TabIndex = 4;
            user_IDLabel.Text = "User ID:";
            // 
            // user_IDTextBox
            // 
            this.user_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_CompanyBindingSource, "User_ID", true));
            this.user_IDTextBox.Location = new System.Drawing.Point(154, 75);
            this.user_IDTextBox.Name = "user_IDTextBox";
            this.user_IDTextBox.Size = new System.Drawing.Size(100, 26);
            this.user_IDTextBox.TabIndex = 5;
            // 
            // nameCompanyLabel
            // 
            nameCompanyLabel.AutoSize = true;
            nameCompanyLabel.Location = new System.Drawing.Point(22, 110);
            nameCompanyLabel.Name = "nameCompanyLabel";
            nameCompanyLabel.Size = new System.Drawing.Size(126, 20);
            nameCompanyLabel.TabIndex = 6;
            nameCompanyLabel.Text = "Name Company:";
            // 
            // nameCompanyTextBox
            // 
            this.nameCompanyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_CompanyBindingSource, "NameCompany", true));
            this.nameCompanyTextBox.Location = new System.Drawing.Point(154, 107);
            this.nameCompanyTextBox.Name = "nameCompanyTextBox";
            this.nameCompanyTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameCompanyTextBox.TabIndex = 7;
            // 
            // employeesLabel
            // 
            employeesLabel.AutoSize = true;
            employeesLabel.Location = new System.Drawing.Point(22, 142);
            employeesLabel.Name = "employeesLabel";
            employeesLabel.Size = new System.Drawing.Size(91, 20);
            employeesLabel.TabIndex = 8;
            employeesLabel.Text = "Employees:";
            // 
            // employeesTextBox
            // 
            this.employeesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbo_CompanyBindingSource, "Employees", true));
            this.employeesTextBox.Location = new System.Drawing.Point(154, 139);
            this.employeesTextBox.Name = "employeesTextBox";
            this.employeesTextBox.Size = new System.Drawing.Size(100, 26);
            this.employeesTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add new";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 549);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(company_IDLabel);
            this.Controls.Add(this.company_IDTextBox);
            this.Controls.Add(user_IDLabel);
            this.Controls.Add(this.user_IDTextBox);
            this.Controls.Add(nameCompanyLabel);
            this.Controls.Add(this.nameCompanyTextBox);
            this.Controls.Add(employeesLabel);
            this.Controls.Add(this.employeesTextBox);
            this.Controls.Add(this.tbo_CompanyDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_CompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_CompanyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _FINGERPRINTDB_MDFDataSet _FINGERPRINTDB_MDFDataSet;
        private System.Windows.Forms.BindingSource tbo_CompanyBindingSource;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_CompanyTableAdapter tbo_CompanyTableAdapter;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbo_CompanyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox company_IDTextBox;
        private System.Windows.Forms.TextBox user_IDTextBox;
        private System.Windows.Forms.TextBox nameCompanyTextBox;
        private System.Windows.Forms.TextBox employeesTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

