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
    public partial class DeleteCompany : Form
    {
        public DeleteCompany()
        {
            InitializeComponent();
        }

        private void DeleteCompany_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            //
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _connectionString;
            comboBoxDeleteCompany.Items.Clear();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbo_Company", con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxDeleteCompany.Items.Add(dt.Rows[i]["Name"]);
            }
            IDCompanyName.Text = null;
            //
        }

        private void comboBoxDeleteCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _connectionString;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbo_Company", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            

            IDCompanyDelete.Text = dt.Rows[comboBoxDeleteCompany.SelectedIndex]["ID"].ToString();
            IDCompanyName.Text = dt.Rows[comboBoxDeleteCompany.SelectedIndex]["Name"].ToString();
            comboBoxDeleteDepartments.Items.Clear();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT CompanyLogo FROM tbo_Company WHERE ID=" + IDCompanyDelete.Text.ToString(), con));
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
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT Name,ID FROM tbo_Department WHERE CompanyID=" + IDCompanyDelete.Text.ToString(), con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                comboBoxDeleteDepartments.Items.Add(dt1.Rows[i]["Name"]);
            }
            comboBoxDeleteDepartments.SelectedItem = comboBoxDeleteDepartments.Items[0];
            //

            

        }

        private void comboBoxDeleteDepartments_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _connectionString;
            
            //

            SqlDataAdapter da1 = new SqlDataAdapter("SELECT ID FROM tbo_Department WHERE CompanyID=" + IDCompanyDelete.Text.ToString(), con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);


            IDDepartmentDelete.Text = dt1.Rows[comboBoxDeleteDepartments.SelectedIndex]["ID"].ToString();

        }

        private void checkBoxDeleteAllDepartments_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDeleteAllDepartments.Checked == true)
            {
                comboBoxDeleteDepartments.Enabled = false;
            }
            else
            {
                comboBoxDeleteDepartments.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxDeleteAllDepartments.Checked == false)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = _connectionString;
                SqlCommand cmd1 = new SqlCommand(@"
DELETE tbo_LinkDepartmentUser
FROM tbo_LinkDepartmentUser
WHERE DepartmentID=" + IDDepartmentDelete.Text.ToString(), con); //link

                SqlCommand cmd2 = new SqlCommand(@"
DELETE tbo_Department
FROM tbo_Department
WHERE ID=" + IDDepartmentDelete.Text.ToString(), con);//tbo_department


                con.Open();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();

                DialogResult result = MessageBox.Show(@"Are you sure to delete this department?","FingerPrintSystem",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
              
                
                MessageBox.Show("Department Deleted Successfully!");
                //
                comboBoxDeleteDepartments.Items.Clear();

                SqlDataAdapter da = new SqlDataAdapter("SELECT Name FROM tbo_Department WHERE CompanyID=" + IDCompanyDelete.Text.ToString(), con);
                DataTable dt = new DataTable();

                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBoxDeleteDepartments.Items.Add(dt.Rows[i]["Name"]);
                }
                //
                if (comboBoxDeleteDepartments != null)
                {
                    comboBoxDeleteDepartments.SelectedIndex = 0;
                }
                
            }
            else
            {

            }
            
        }
    }
}
