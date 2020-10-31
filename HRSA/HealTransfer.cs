using HRSA.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HRSA
{
    public partial class HealTransfer : Form
    {
        public HealTransfer()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(hrsaDataBox.Text))
            {
                var wrn = MessageBox.Show("HRSA Data file is not selected. This means duplicate entries may not be filtered out.\nPress OK to continue with generating.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (wrn == DialogResult.Cancel)
                    return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV Fies (*.csv)|*.csv|All files (*.*)|*.*";
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (!Directory.Exists(Path.GetDirectoryName(dialog.FileName)))
                {
                    MessageBox.Show("Directory of the file does not exist.", "Missing Path Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var records = CSV.Read<HRSAIncomingPatient>(hrsaDataBox.Text);
                var incoming = CSV.Read<HealPatient>(healDataBox.Text);
                var patients = incoming
                    .Where(x => !records.Any(r => r.AccountNumber == x.AccountNumber && DateTime.Now > DateTime.Parse(r.DateOfService).AddDays(30)))
                    .Where(x => !records.Any(r => r.LastName == x.LastName && r.FirstName == x.FirstName 
                        && r.DateOfBirth == x.DateOfBirth && r.CleanGender == x.Gender)) // this could probably even be removed in the future
                    .Select(x => HRSAOutgoingPatient.From(x));

                if (!File.Exists(dialog.FileName))
                    File.Create(dialog.FileName).Close();

                CSV.Write(dialog.FileName, patients);
                MessageBox.Show("Saved " + patients.Count() + " patients.\n" + (incoming.Count() - patients.Count()) + " duplicates removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void openHrsaDataBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                hrsaDataBox.Text = dialog.FileName;
            }
        }

        private void openHealDataBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                healDataBox.Text = dialog.FileName;
            }
        }
    }
}
