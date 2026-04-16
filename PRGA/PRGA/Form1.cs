using System.ComponentModel;
using System.IO.Pipes;

namespace PRGA
{
    public partial class Form1 : Form
    {
        public BindingList<Eater> Eaters { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> Hamburger = ["cheese burger", "chicken burger", "vegan burger", "nakedburger"];
            comboBox_Hamburger.DataSource = Hamburger;

            Eaters = new BindingList<Eater>();
            dataGridView_Hamburgers.DataSource = Eaters;
        }

        private void textBox_FullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_Hamburgers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Eater eater = new Eater();
            eater.Name = textBox_FullName.Text;
            eater.Eaten = Convert.ToInt32(numericUpDown_Eaten.Value);
            eater.LastHamburgerEaten = dateTimePicker_LastHamburger.Value;
            if (comboBox_Hamburger.SelectedValue != null)
            {
                eater.HamburgerType = (string)comboBox_Hamburger.SelectedValue;

            }
            Eaters.Add(eater);




        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

            if (dataGridView_Hamburgers.CurrentRow != null)
            {
                int index = dataGridView_Hamburgers.CurrentRow.Index;
                Eaters.RemoveAt(index);

            }


        }

        private void button_Edit_Click(object sender, EventArgs e)
        {

            if (dataGridView_Hamburgers != null)
            {
                int index = dataGridView_Hamburgers.CurrentRow.Index;

                Eater eater = Eaters[index];

                eater.Name = textBox_FullName.Text;
                eater.LastHamburgerEaten = dateTimePicker_LastHamburger.Value;
                eater.Eaten = Convert.ToInt32(numericUpDown_Eaten.Value);
                if (comboBox_Hamburger.SelectedValue != null)
                {

                    eater.HamburgerType = (string)comboBox_Hamburger.SelectedValue;

                }
                Eaters[index] = eater;
            }

        }
    }
}
