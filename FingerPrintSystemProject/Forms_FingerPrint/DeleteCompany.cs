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
            //
        }

        private void comboBoxDeleteCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _connectionString;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbo_Company", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            IDCompanyDelete.Text = dt.Rows[comboBoxDeleteCompany.SelectedIndex - comboBoxDeleteCompany.SelectedIndex]["ID"].ToString();

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

        }
    }
}
