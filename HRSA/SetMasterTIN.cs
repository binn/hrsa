using System;
using System.Windows.Forms;

namespace HRSA
{
    public partial class SetMasterTIN : Form
    {
        private readonly Home _home;

        public SetMasterTIN(Home home)
        {
            _home = home;
            InitializeComponent();
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            Global.SetMasterTIN(string.IsNullOrWhiteSpace(masterTinInput.Text) ? "None" : masterTinInput.Text);
            _home.UpdateTIN();

            this.Dispose();
        }

        private void cancelBtn_Click(object sender, EventArgs e) =>
            this.Dispose();
    }
}
