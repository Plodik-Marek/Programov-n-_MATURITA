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

namespace TreninkWinForm
{
    public partial class MainTestForm : Form
    {
        private AppDbContext AppDbContext { get; set; }
        private BindingList<Club> Clubs { get; set; }
        public MainTestForm()
        {
            InitializeComponent();

            AppDbContext = new AppDbContext();

            List<Club> list = AppDbContext.Clubs.ToList();

            Clubs = new BindingList<Club>(list);

            dataGridView1.DataSource = Clubs;


        }

        private void button_OpenSecondForm_Click(object sender, EventArgs e)
        {
            SecondForm secondForm = new SecondForm();
            secondForm.ShowDialog();
        }

        private void button_Message_Click(object sender, EventArgs e)
        {
            string text = "Toto je zpráva z MainTestForm.";
            MessageBox.Show(text);
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();

            Club club = new Club
            {
                Name = addForm.GetClubName(),
                Description = addForm.GetClubDescription(),
                Type = addForm.GetClubType(),
                First_league = addForm.GetClubFirstLeague()
            };

            AppDbContext.Clubs.Add(club);
            AppDbContext.SaveChanges();

            Clubs.Add(club); //bindig list
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            Club club = Clubs[index];

            AppDbContext.Clubs.Remove(club);
            AppDbContext.SaveChanges();

            Clubs.Remove(club); //odebrat binding list
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            Club club = Clubs[index];

            EditForm editForm = new EditForm(club);
            editForm.ShowDialog();

            club.Description = editForm.GetClubDescription();
            club.Type = editForm.GetClubType();
            club.First_league = editForm.GetClubFirstLeague();

            AppDbContext.SaveChanges();

            Clubs.ResetBindings();

        }

        private void button_Grafs_Click(object sender, EventArgs e)
        {
            GraphForm graphForm = new GraphForm();
            graphForm.ShowDialog();
        }

        private void button_Hodiny_Click(object sender, EventArgs e)
        {
            ClockGraph clock = new ClockGraph();
            clock.ShowDialog();
        }
    }
}
