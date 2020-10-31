using HRSA.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HRSA
{
    public partial class ECWParse : Form
    {
        public ECWParse()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ecwRecordsOpenFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ecwRecordBox.Text = dialog.FileName;
            }
        }

        private void ecwPatientDataOpenFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ecwDataBox.Text = dialog.FileName;
            }
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dosBox.Text) || !DateTime.TryParse(dosBox.Text, out _))
            {
                MessageBox.Show("Date of Service is invalid or empty. A valid Date of Service is required before continuing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(string.IsNullOrWhiteSpace(hsraMemberBox.Text))
            {
                var wrn = MessageBox.Show("HRSA member data is not selected. This means duplicate patients could show up in the record.\nPress OK to continue generating H36 data.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (wrn == DialogResult.Cancel)
                    return;
            }
           
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV Fies (*.csv)|*.csv|All files (*.*)|*.*";
            var result = dialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                if(!Directory.Exists(Path.GetDirectoryName(dialog.FileName)))
                {
                    MessageBox.Show("Directory of the file does not exist.", "Missing Path Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Clean(ecwDataBox.Text);
                Clean(ecwRecordBox.Text);
                var incomingPatients = CSV.Read<ECWIncomingPatient>(ecwRecordBox.Text);
                var incomingDataRecords = CSV.Read<ECWGenderPatient>(ecwDataBox.Text);
                List<HRSAIncomingPatient> records = string.IsNullOrWhiteSpace(hsraMemberBox.Text)
                    ? new List<HRSAIncomingPatient>() : CSV.Read<HRSAIncomingPatient>(hsraMemberBox.Text).ToList();

                var patients = incomingPatients
                    .Select(x => new ECWOutgoingPatient(x, incomingDataRecords.FirstOrDefault(r => r.AccountNumber == x.AccountNumber)))
                    .Where(x => !records.Any(r => r.AccountNumber == x.AccountNumber && DateTime.Now > DateTime.Parse(r.DateOfService).AddDays(30)))
                    .Where(x => !records.Any(r => r.LastName == x.LastName && r.FirstName == x.FirstName
                        && r.DateOfBirth == x.DateOfBirth && r.CleanGender == x.Gender)) // this could probably even be removed in the future
                    .Select(x => HRSAOutgoingPatient.From(x));

                if (patients.Count() != incomingPatients.Count())
                   MessageBox.Show("Patient record mismatch. Please export correctly before trying again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (!File.Exists(dialog.FileName))
                    File.Create(dialog.FileName).Close();

                var outgoing = patients.Select(x => HealPatient.From(dosBox.Text.Trim(), x));
                CSV.Write(dialog.FileName, outgoing);
            }
        }

        private void Clean(string path)
        {
            List<string> lines = new List<string>();
            foreach (var line in File.ReadAllLines(path))
                if (!line.Contains("Report Criteria") && !line.Contains("Total Patients"))
                    lines.Add(line);

            File.WriteAllLines(path, lines);
        }

        private void hrsaMemberBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
