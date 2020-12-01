using HRSA.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HRSA
{
    public partial class HRSAParse : Form
    {
        public HRSAParse()
        {
            InitializeComponent();
        }

        private void processMembersBtn_Click(object sender, EventArgs e)
        {
            var memberData = CSV.Read<HRSAIncomingPatient>(hrsaDataBox.Text);
            var patients = CSV.Read<HealPatient>(healRecordBox.Text).ToArray();

            foreach (var patient in patients)
            {
                var data = memberData.FirstOrDefault(x => x.AccountNumber == patient.AccountNumber && DateTime.Now < DateTime.Parse(x.DateOfService).AddDays(30));
                if(data != null)
                {
                    patient.SubscriberId = data.MemberID;
                    patient.SubmittedDate = data.SubmissionDate;
                    patient.ActiveDate = data.DateOfService;
                }
            }

            CSV.Write(healRecordBox.Text, patients);
            MessageBox.Show(
                "Processed " + patients.Count(x => x.SubscriberId != null) + "/" + patients.Count() + " patients...\nPress OK to continue.", 
                "Success", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void healRecordBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                healRecordBox.Text = dialog.FileName;
            }
        }

        private void hrsaDataBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                hrsaDataBox.Text = dialog.FileName;
            }
        }
    }
}
