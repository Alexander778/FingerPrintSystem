namespace Forms_FingerPrint
{
    partial class Admin_Panel
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
            this._FINGERPRINTDB_MDFDataSet = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSet();
            this.tbo_RoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbo_RoleTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_RoleTableAdapter();
            this.tableAdapterManager = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager();
            this.tbo_ProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbo_ProfileTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_ProfileTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fINGERPRINTDBMDFDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tboCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbo_CompanyTableAdapter = new Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.tbo_CompanyTableAdapter();
            this.tboCompanyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_RoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_ProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINGERPRINTDBMDFDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // tbo_RoleTableAdapter
            // 
            this.tbo_RoleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbo_CompanyTableAdapter = this.tbo_CompanyTableAdapter;
            this.tableAdapterManager.tbo_DepartmentTableAdapter = null;
            this.tableAdapterManager.tbo_LinkDepartmentUserTableAdapter = null;
            this.tableAdapterManager.tbo_ProfileTableAdapter = this.tbo_ProfileTableAdapter;
            this.tableAdapterManager.tbo_RoleTableAdapter = this.tbo_RoleTableAdapter;
            this.tableAdapterManager.UpdateOrder = Forms_FingerPrint._FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbo_ProfileBindingSource
            // 
            this.tbo_ProfileBindingSource.DataMember = "tbo_Profile";
            this.tbo_ProfileBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            // 
            // tbo_ProfileTableAdapter
            // 
            this.tbo_ProfileTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nickname of admin";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tboCompanyBindingSource1;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose company";
            // 
            // fINGERPRINTDBMDFDataSetBindingSource
            // 
            this.fINGERPRINTDBMDFDataSetBindingSource.DataSource = this._FINGERPRINTDB_MDFDataSet;
            this.fINGERPRINTDBMDFDataSetBindingSource.Position = 0;
            // 
            // tboCompanyBindingSource
            // 
            this.tboCompanyBindingSource.DataMember = "tbo_Company";
            this.tboCompanyBindingSource.DataSource = this.fINGERPRINTDBMDFDataSetBindingSource;
            // 
            // tbo_CompanyTableAdapter
            // 
            this.tbo_CompanyTableAdapter.ClearBeforeFill = true;
            // 
            // tboCompanyBindingSource1
            // 
            this.tboCompanyBindingSource1.DataMember = "tbo_Company";
            this.tboCompanyBindingSource1.DataSource = this.fINGERPRINTDBMDFDataSetBindingSource;
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Name = "Admin_Panel";
            this.Text = "FingerPrintSystem:: Administration Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this._FINGERPRINTDB_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_RoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbo_ProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINGERPRINTDBMDFDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboCompanyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _FINGERPRINTDB_MDFDataSet _FINGERPRINTDB_MDFDataSet;
        private System.Windows.Forms.BindingSource tbo_RoleBindingSource;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_RoleTableAdapter tbo_RoleTableAdapter;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_ProfileTableAdapter tbo_ProfileTableAdapter;
        private System.Windows.Forms.BindingSource tbo_ProfileBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private _FINGERPRINTDB_MDFDataSetTableAdapters.tbo_CompanyTableAdapter tbo_CompanyTableAdapter;
        private System.Windows.Forms.BindingSource fINGERPRINTDBMDFDataSetBindingSource;
        private System.Windows.Forms.BindingSource tboCompanyBindingSource;
        private System.Windows.Forms.BindingSource tboCompanyBindingSource1;
    }
}