using Fires.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plodik_EF_Test.WinForms
{
    public partial class FireEditForm : Form
    {
        public FireEditForm()
        {
            InitializeComponent();
        }

        private void FireEditForm_Load(object sender, EventArgs e)
        {



        }

        public CountryFire CreateCountryFire()
        {

            CountryFire countryFire = new CountryFire();

            countryFire.Location = textBox_Location.Text;
            countryFire.Severity = (int)numericUpDown_Severity.Value;
            countryFire.Involvement = textBox_Involement.Text;
            countryFire.StartedAt = dateTimePicker_Started.Value;
            countryFire.EndedAt = dateTimePicker_Ended.Value;
            return countryFire;
        }

        public void LoadData(CountryFire countryFire)
        {
            textBox_Location.Text = countryFire.Location;
            numericUpDown_Severity.Value = (int) countryFire.Severity;
            textBox_Involement.Text = countryFire.Involvement;
            dateTimePicker_Started.Value = countryFire.StartedAt;
            dateTimePicker_Ended.Value = countryFire.EndedAt;



        }

        public void UpdateData (CountryFire countryFire)
        {
            countryFire.Location = textBox_Location.Text;
            countryFire.Severity = (int)numericUpDown_Severity.Value;
            countryFire.Involvement = textBox_Involement.Text;
            countryFire.StartedAt = dateTimePicker_Started.Value;
            countryFire.EndedAt = dateTimePicker_Ended.Value;

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
