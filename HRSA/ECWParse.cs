using HRSA.Models;
using System;
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
            if(string.IsNullOrWhiteSpace(dosBox.Text) || !DateTime.TryParse(dosBox.Text, out _))
                MessageBox.Show("Date of Service is invalid or empty. A valid Date of Service is required before continuing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "*.csv";
            var result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                if(!Directory.Exists(Path.GetDirectoryName(dialog.FileName)))
                {
                    MessageBox.Show("Directory of the file does not exist.", "Missing Path Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var incomingPatients = CSV.Read<ECWIncomingPatient>(ecwRecordBox.Text);
                var records = CSV.Read<ECWGenderPatient>(ecwDataBox.Text);
                var patients = incomingPatients.Select(x => new ECWOutgoingPatient(x, records.FirstOrDefault(r => r.AccountNumber == x.AccountNumber)));
                
                if (patients.Count() != incomingPatients.Count())
                    MessageBox.Show("Patient record mismatch. Please export correctly before trying again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (!File.Exists(dialog.FileName))
                    File.Create(dialog.FileName).Close();

                var outgoing = patients.Select(x => HealPatient.From(dosBox.Text.Trim(), x));
                CSV.Write(dialog.FileName, outgoing);
            }
        }
    }
}
