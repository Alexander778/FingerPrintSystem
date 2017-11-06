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
using System.IO;

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

            //
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=AlexPC\SQLEXPRESS;Initial Catalog=FINGERPRINTDB.MDF;Integrated Security=True";

            nameComboBox.Items.Clear();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbo_Company", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                nameComboBox.Items.Add(dt.Rows[i]["Name"]);
            }
            //
            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = @"Data Source=AlexPC\SQLEXPRESS;Initial Catalog=FINGERPRINTDB.MDF;Integrated Security=True";

            nameComboBox1.Items.Clear();

            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM tbo_Department", con2);

            DataTable dt2 = new DataTable();

            da2.Fill(dt2);

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                nameComboBox1.Items.Add(dt2.Rows[i]["Name"]);
            }
            //

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








        private void button4_Click(object sender, EventArgs e)
        {
            //
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=AlexPC\SQLEXPRESS;Initial Catalog=FINGERPRINTDB.MDF;Integrated Security=True";

            nameComboBox.Items.Clear();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbo_Company", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                nameComboBox.Items.Add(dt.Rows[i]["Name"]);
            }
            //
            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = @"Data Source=AlexPC\SQLEXPRESS;Initial Catalog=FINGERPRINTDB.MDF;Integrated Security=True";

            nameComboBox1.Items.Clear();

            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM tbo_Department", con2);

            DataTable dt2 = new DataTable();

            da2.Fill(dt2);

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                nameComboBox1.Items.Add(dt2.Rows[i]["Name"]);
            }
            
            //
        }

        private void nameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Create_Department f1 = new Form_Create_Department();
            f1.Show();
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


    }
    }

