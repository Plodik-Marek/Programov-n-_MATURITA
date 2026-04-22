using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreninkWinForm.Data;
using TreninkWinForm.Entites;
using TreninkWinForm.Forms;
using Result = TreninkWinForm.Entites.Result;

namespace TreninkWinForm
{

    public partial class SecondForm : Form
    {
        AppDbContext AppDbContext = new AppDbContext();
        private BindingList<Result> Results {get; set;}
        public SecondForm()
        {
            InitializeComponent();

            List<Result> list = AppDbContext.Results.ToList();

            Results = new BindingList<Result>(list);

        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            SecondForm scndForm = new SecondForm();
            Result result = new Result()
            {
                Score = textBox_Score.Text,
                Cards = (int)numericUpDown_Cards.Value,
                Date = dateTimePicker_Date.Value
            };

            AppDbContext.Results.Add(result);
            AppDbContext.SaveChanges();

            Results.Add(result);


            DialogResult = DialogResult.OK;
            MessageBox.Show("OK button was clicked.");


        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            MessageBox.Show("Cancel button was clicked.");
            MainTestForm mainForm = new MainTestForm();
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            
                comboBox_Club.DataSource = AppDbContext.Clubs.ToList(); //join s tabulkou Clubs, aby se zobrazily názvy klubů místo ID
                comboBox_Club.DisplayMember = "Name";
                comboBox_Club.ValueMember = "Id";

            
        }
    }
}
