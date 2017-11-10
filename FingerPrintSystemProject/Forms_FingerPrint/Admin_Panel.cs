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

           
        
        //SqlDataAdapter da1 = new SqlDataAdapter("SELECT CompanyLogo FROM tbo_Company WHERE ID="+dt.Rows[nameComboBox.SelectedIndex]["ID"], con);

        //DataTable dt1 = new DataTable();

        //da1.Fill(dt1);
        //var data=(Byte[])()
        //



        //label3.Text = null;
        //companyIDLabel1.Text = null;
        //pictureBox1.Image = null;



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
            
        }

        private void nameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=AlexPC\SQLEXPRESS;Initial Catalog=FINGERPRINTDB.MDF;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbo_Company", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
   
            companyIDLabel1.Text = dt.Rows[nameComboBox.SelectedIndex]["ID"].ToString();
            label3.Text = dt.Rows[nameComboBox.SelectedIndex]["Name"].ToString();
            nameComboBox1.Items.Clear();

            //
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT Name FROM tbo_Department WHERE CompanyID=" + dt.Rows[nameComboBox.SelectedIndex]["ID"], con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                nameComboBox1.Items.Add(dt1.Rows[i]["Name"]);
            }

            nameComboBox1.SelectedIndex = 0;

            //
            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT CompanyLogo FROM tbo_Company WHERE ID="+ dt.Rows[nameComboBox.SelectedIndex]["ID"],con));
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 1)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(dataSet.Tables[0].Rows[0]["CompanyLogo"]);
                MemoryStream mem = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(mem);
            }
            //




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Create_Department f1 = new Form_Create_Department();
            f1.Show();
        }

        private void companyIDLabel1_Click(object sender, EventArgs e)
        {

        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Create_User f = new Form_Create_User();
            f.Show();
        }

        private void nameComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(button3, "Add User");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip2.SetToolTip(button1, "Add Company");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBoxShowOnlyCompany.Checked == true) //no division
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=AlexPC\SQLEXPRESS;Initial Catalog=FINGERPRINTDB.MDF;Integrated Security=True";
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID FROM tbo_Company", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                var select = @"
SELECT tbo_Profile.Name,tbo_Profile.Surname,tbo_Profile.Patronymic,tbo_Profile.BirthDate,tbo_Profile.Photo,tbo_Profile.BirthDate,tbo_Profile.DateCreation,tbo_Department.Name,tbo_Department.Regime,tbo_LinkDepartmentUser.Access,tbo_LinkDepartmentUser.Position
 FROM tbo_LinkDepartmentUser 
 INNER JOIN tbo_Profile ON tbo_LinkDepartmentUser.UserID=tbo_Profile.ID
 INNER JOIN tbo_Department ON tbo_LinkDepartmentUser.DepartmentID=tbo_Department.ID
 INNER JOIN tbo_Company ON tbo_Department.CompanyID=tbo_Company.ID
 WHERE tbo_Company.ID="+dt.Rows[nameComboBox.SelectedIndex]["ID"];

                var c = new SqlConnection(@"Data Source=AlexPC\SQLEXPRESS;Initial Catalog=FINGERPRINTDB.MDF;Integrated Security=True"); // Your Connection String here
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
                
            }
            else//division by departments
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=AlexPC\SQLEXPRESS;Initial Catalog=FINGERPRINTDB.MDF;Integrated Security=True";
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID FROM tbo_Department", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                var select = @"
SELECT tbo_Profile.Name,tbo_Profile.Surname,tbo_Profile.Patronymic,tbo_Profile.BirthDate,tbo_Profile.Photo,tbo_Profile.BirthDate,tbo_Profile.DateCreation,tbo_Department.Name,tbo_Department.Regime,tbo_LinkDepartmentUser.Access,tbo_LinkDepartmentUser.Position
 FROM tbo_LinkDepartmentUser 
 INNER JOIN tbo_Profile ON tbo_LinkDepartmentUser.UserID=tbo_Profile.ID
 INNER JOIN tbo_Department ON tbo_LinkDepartmentUser.DepartmentID=tbo_Department.ID
 INNER JOIN tbo_Company ON tbo_Department.CompanyID=tbo_Company.ID
 WHERE tbo_Department.ID=" + dt.Rows[nameComboBox1.SelectedIndex]["ID"];

                var c = new SqlConnection(@"Data Source=AlexPC\SQLEXPRESS;Initial Catalog=FINGERPRINTDB.MDF;Integrated Security=True"); // Your Connection String here
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];


            }
        }

        private void checkBoxShowOnlyCompany_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowOnlyCompany.Checked == true)
            {
                nameComboBox1.Enabled = false;
            }
            else
            {
                nameComboBox1.Enabled = true;
            }
        }

        private void tbo_CompanyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }
    }
    }
    


