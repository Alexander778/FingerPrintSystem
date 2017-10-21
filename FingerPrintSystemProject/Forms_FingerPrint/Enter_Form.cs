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
    public partial class Enter_Form : Form
    {
        public Enter_Form()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form_Create_Company f1 = new Form_Create_Company();
            f1.Show();
            this.Hide();

        }

        private void Enter_Form_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }
    }
}
