using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Forms_FingerPrint
{
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void tbo_RoleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbo_RoleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._FINGERPRINTDB_MDFDataSet);

        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet1.tbo_Company". При необходимости она может быть перемещена или удалена.
            this.tbo_CompanyTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet1.tbo_Company);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Department". При необходимости она может быть перемещена или удалена.
            this.tbo_DepartmentTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Company". При необходимости она может быть перемещена или удалена.
            this.tbo_CompanyTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Company);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Profile". При необходимости она может быть перемещена или удалена.
            this.tbo_ProfileTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Profile);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Role". При необходимости она может быть перемещена или удалена.
            this.tbo_RoleTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Role);

            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_Create_Company f = new Form_Create_Company();
            f.Show();
            

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fillByExampleToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

       

       

        private void nameComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {


            nameComboBox.BeginUpdate();
            tbo_CompanyTableAdapter.Fill(_FINGERPRINTDB_MDFDataSet.tbo_Company);
            nameComboBox.DataSource = tbo_CompanyBindingSource;
            nameComboBox.EndUpdate();
            


        }

        private void nameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Create_Department f1 = new Form_Create_Department();
            f1.Show();
        }
    }
}
