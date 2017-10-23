using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_FingerPrint
{
    public partial class Form_Create_Department : Form
    {
        public Form_Create_Department()
        {
            InitializeComponent();
        }

        private void tbo_RoleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbo_RoleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._FINGERPRINTDB_MDFDataSet);

        }

        private void Form_Create_Department_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet1.tbo_Company". При необходимости она может быть перемещена или удалена.
            this.tbo_CompanyTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet1.tbo_Company);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Department". При необходимости она может быть перемещена или удалена.
            this.tbo_DepartmentTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Profile". При необходимости она может быть перемещена или удалена.
            this.tbo_ProfileTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Profile);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Role". При необходимости она может быть перемещена или удалена.
            this.tbo_RoleTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Role);

            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            iDTextBox.Enabled = true;
            nameTextBox.Enabled = true;
            companyIDComboBox.Enabled = true;
            regimeTextBox.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            checkBox1.Enabled = true;


            tbo_DepartmentBindingSource.AddNew();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbo_DepartmentBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbo_DepartmentBindingSource.EndEdit();
            tbo_DepartmentTableAdapter.Update(_FINGERPRINTDB_MDFDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string message = "Your company(ies) and departments were created!Now,please, add information about administrator profile and change password!";
            string caption = "FingerPrintSystem::Change information";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);

            ChangePasswordAdmin ch1 = new ChangePasswordAdmin();
            ch1.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tbo_DepartmentDataGridView.Visible = true;
            }
            else
            {
                tbo_DepartmentDataGridView.Visible = false;
            }
        }
    }
}
