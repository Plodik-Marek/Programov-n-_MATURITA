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
        public BindingList<Reservation> Data {  get; set; }
       
        public ReservationListForm()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            ReservationsManageForm form = new ReservationsManageForm();
            form.Mode = "Add";
            form.Show();

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            ReservationsManageForm form = new ReservationsManageForm();
            form.Mode = "Edit";
            form.Show();
        }

        private void button_Detail_Click(object sender, EventArgs e)
        {
            ReservationDetailForm form = new ReservationDetailForm();
            form.ShowDialog();
        }

        private void ReservationListForm_Load(object sender, EventArgs e)
        {
            Data = new BindingList<Reservation>();  
            dataGridView_Reservations.DataSource = Data;

            
        }
    }
}
