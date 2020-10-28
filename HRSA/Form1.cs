using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ECW Form
        private void button1_Click(object sender, EventArgs e)
        {
            ECWParse parseForm = new ECWParse();
            parseForm.Show();
        }

        // HRSA Form
        private void button2_Click(object sender, EventArgs e)
        {
            HRSAParse parseForm = new HRSAParse();
            parseForm.Show();
        }

        // HRSABatch
        private void button3_Click(object sender, EventArgs e)
        {
            HealTransfer batchForm = new HealTransfer();
            batchForm.Show();
        }
    }
}
