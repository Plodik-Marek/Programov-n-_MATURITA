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
    public partial class EditForm : Form
    {
        private Club Club;
        public EditForm(Club club)
        {
            InitializeComponent();
            Club = club;

            comboBox_Type.DataSource = Club.Types;

            textBox_Name.Text = club.Name;
            richTextBox_Desc.Text = club.Description;
            checkBox_FirstLeague.Checked = club.First_league;
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


        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button_Add_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
