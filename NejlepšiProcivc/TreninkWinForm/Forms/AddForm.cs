using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreninkWinForm.Entites;

namespace TreninkWinForm.Forms
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();

            comboBox_Type.DataSource = Club.Types;
        }

        public string GetClubName()
        {
            return textBox_Name.Text;
        }

        public string GetClubDescription()
        {
            return richTextBox_Desc.Text;
        }

        public string GetClubType()
        {
            return comboBox_Type.SelectedItem.ToString();
        }   


        public bool GetClubFirstLeague()
        {
            return checkBox_FirstLeague.Checked;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
