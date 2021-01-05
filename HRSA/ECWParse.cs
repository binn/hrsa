using HRSA.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            if(string.IsNullOrWhiteSpace(hrsaMemberBox.Text))
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
                List<HRSAIncomingPatient> records = string.IsNullOrWhiteSpace(hrsaMemberBox.Text)
                    ? new List<HRSAIncomingPatient>() : CSV.Read<HRSAIncomingPatient>(hrsaMemberBox.Text).ToList();

                List<SetmorePatient> setmorePatients = string.IsNullOrWhiteSpace(setmoreBox.Text)
                    ? new List<SetmorePatient>() : CSV.Read<SetmorePatient>(setmoreBox.Text).ToList();

                var patients = incomingPatients
                    .Select(x => new ECWOutgoingPatient(x, incomingDataRecords.FirstOrDefault(r => r.AccountNumber == x.AccountNumber)))
                    .Where(x => !records.Any(r => r.AccountNumber == x.AccountNumber && DateTime.Now < DateTime.Parse(r.DateOfService).AddDays(30)));
                //    .Where(x => !records.Any(r => r.LastName == x.LastName && r.FirstName == x.FirstName
                //        && r.DateOfBirth == x.DateOfBirth && r.CleanGender == x.Gender)); // this could probably even be removed in the future

                if (!File.Exists(dialog.FileName))
                    File.Create(dialog.FileName).Close();

                setmorePatients = setmorePatients
                    .Where(x => x.ResourceName.Contains("UNINSURED"))
                    .Select(x => x.Clean()).ToList();

                List<ECWOutgoingPatient> finalPatients = new List<ECWOutgoingPatient>();
                foreach (var patient in patients)
                {
                    var pt = setmorePatients.FirstOrDefault(x => 
                           x.Gender == patient.Gender
                        && x.DateOfBirth.Date == patient.DateOfBirth.Date
                        && x.Phone.Trim() == patient.PhoneNumber.Trim()
                        && Percent(x.CustomerName, patient.FirstName, patient.LastName) >= 55.00);

                    if (pt == null)
                    {
                        finalPatients.Add(patient);
                        continue;
                    }

                    patient.DL = pt.DL;
                    patient.SubmitDate = $"{pt.CustomerName.ToUpper().Trim()} - {pt.DateOfBirth.Date.ToShortDateString()}";
                    finalPatients.Add(patient);
                }

                var outgoing = finalPatients.Select(x => HealPatient.From(dosBox.Text.Trim(), x));
                CSV.Write(dialog.FileName, outgoing);

                MessageBox.Show("Saved " + patients.Count() + "/" + incomingPatients.Count() + " patients.\n" + (incomingPatients.Count() - patients.Count()) + " duplicates removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private double Percent(string customerName, string firstName, string lastName)
        {
            string name = firstName.Trim().ToUpper().Split(' ')[0] + " " + lastName.Trim().ToUpper().Split(' ')[0];

            int distance = LevenshteinDistance(customerName, name);
            int longerLength = customerName.Length > name.Length ? customerName.Length : name.Length;

            double percent = (((double)longerLength - (double)distance) / (double)longerLength) * 100.00;
            Trace.WriteLine($"P: {percent}, N1: {name}, N2: {customerName}");
            return percent;
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
            OpenFileDialog dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                hrsaMemberBox.Text = dialog.FileName;
            }
        }

        private void setmoreBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                setmoreBox.Text = dialog.FileName;
            }
        }

        public static int LevenshteinDistance(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }
    }
}
