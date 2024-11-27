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
    public partial class MDICustomer : Form
    {
        public MDICustomer()
        {
            InitializeComponent();
        }

        private void enterCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this; // Set MDCustomer as MDI parent
            frm.Show();
        }
    }
}
