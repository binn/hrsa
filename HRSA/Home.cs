using System;
using System.Windows.Forms;

namespace HRSA
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.UpdateTIN();
        }

        // ECW Form
        private void ecwButton_Click(object sender, EventArgs e)
        {
            ECWParse parseForm = new ECWParse();
            parseForm.Show();
        }

        // HRSA Form
        private void hrsaTransferButton_Click(object sender, EventArgs e)
        {
            HRSAParse parseForm = new HRSAParse();
            parseForm.Show();
        }

        // HRSABatch
        private void hrsaBatchButton_Click(object sender, EventArgs e)
        {
            HealTransfer batchForm = new HealTransfer();
            batchForm.Show();
        }

        private void masterTinButton_Click(object sender, EventArgs e)
        {
            SetMasterTIN masterTinSetForm = new SetMasterTIN(this);
            masterTinSetForm.Show();
        }

        public void UpdateTIN()
        {
            this.masterTin.Text = "Master TIN: " + Global.ReadMasterTIN();
        }
    }
}
