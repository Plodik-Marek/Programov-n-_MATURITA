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
    public partial class ReservationsManageForm : Form
    {
        public string Mode { get; set; }
         
        public ReservationsManageForm()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();

        }
    }
}
