using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procviceni_CRUD
{
    public partial class ReservationListForm : Form
    {
        public BindingList<Reservation> ReservationData {  get; set; }
       
        public ReservationListForm()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {


            ReservationsManageForm form = new ReservationsManageForm();
            DialogResult saveResult = form.ShowDialog();
           
            if (saveResult== DialogResult.OK)
            {

                Reservation newReservation = form.ReservationManageForm

                    Dbcontext.ReservationData.Add(newReservation);
                    Dbcontext.SaveChanges();

                dataGridView_Reservations.Refresh();

            }
           

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            ReservationsManageForm form = new ReservationsManageForm();
            
            form.Show();
        }

        private void button_Detail_Click(object sender, EventArgs e)
        {
            ReservationDetailForm form = new ReservationDetailForm();
            form.ShowDialog();
        }

        private void ReservationListForm_Load(object sender, EventArgs e)
        {
           
            List<Reservation> list = new List<Reservation>();

            ReservationData = new(list);

            dataGridView_Reservations.DataSource = list; 

            
        }
    }
}
