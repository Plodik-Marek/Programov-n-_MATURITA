using Form_MAT.Connect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_MAT
{
    public partial class FormProcvicovanni : Form
    {
        private AppDbContext ReservationConnect {  get; set; }

        private BindingList<Reservation> Reservations { get; set; }



        public FormProcvicovanni()
        {
            InitializeComponent();

            ReservationConnect = new AppDbContext();
            List<Reservation> list = new List<Reservation>();
            dataGridView_Data.DataSource = Reservations;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {

            EditForm editForm = new EditForm();
            Show(editForm);

            Reservation reservation = new Reservation
            {
               Id = getClubName()
            }



             
        }





    }
}
