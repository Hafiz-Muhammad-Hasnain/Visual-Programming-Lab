using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_01_Lab
{
    public partial class frmCustomerPreview : Form
    {
        public frmCustomerPreview()
        {
            InitializeComponent();
        }

        private void frmCustomerPreview_Load(object sender, EventArgs e)
        {

        }

        public void SetValues(string name, string country, string gender, string hobby, string status)
        {
            lblName.Text = name;
            lblCountry.Text = country;
            lblGender.Text = gender;
            lblHobby.Text = hobby;
            lblStatus.Text = status;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
