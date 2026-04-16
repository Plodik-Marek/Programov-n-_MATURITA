using Fires.Core;
using Fires.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plodik_EF_Test.WinForms
{
    public partial class FiresGridForm : Form
    {
        public BindingList<CountryFire> CountryFireData { get; set; }

        public FiresDbContext DbContext { get; set; }

        public FiresGridForm()
        {
            InitializeComponent();
        }

        private void FiresGridForm_Load(object sender, EventArgs e)
        {
            DbContext = new FiresDbContext();

            List<CountryFire> list = DbContext.CountryFireData.OrderBy(f => f.Id).ToList();

            CountryFireData = new(list);
            dataGridView_Fires.DataSource = list;

        }

        private void button_Add_Click(object sender, EventArgs e)
        {

            FireEditForm form = new FireEditForm();
            DialogResult saveResult = form.ShowDialog();

            if (saveResult == DialogResult.OK)
            {

                CountryFire newCountryFire = form.CreateCountryFire();

                DbContext.CountryFireData.Add(newCountryFire);
                DbContext.SaveChanges();

                dataGridView_Fires.Refresh();

            }



        }

        private void button_Update_Click(object sender, EventArgs e)
        {

            if (dataGridView_Fires.CurrentRow != null)
            {

                int index = dataGridView_Fires.CurrentRow.Index;
                CountryFire countryFireToUpdate = CountryFireData[index];


                FireEditForm fireEditForm = new FireEditForm();
                fireEditForm.LoadData(countryFireToUpdate);
                DialogResult editResult = fireEditForm.ShowDialog();
                if (editResult == DialogResult.OK)
                {

                    fireEditForm.UpdateData(countryFireToUpdate);

                   // DbContext.CountryFireData.Update(countryFireToUpdate);
                    DbContext.SaveChanges();

                    dataGridView_Fires.Refresh();

                }




            }





        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

            if (dataGridView_Fires.CurrentRow != null)
            {
                int index = dataGridView_Fires.CurrentRow.Index;
                CountryFire countryFireToRemove = CountryFireData[index];



                DbContext.CountryFireData.Remove(countryFireToRemove);
                DbContext.SaveChanges();


                CountryFireData.Remove(countryFireToRemove);

                dataGridView_Fires.Refresh();
            }
        }
    }
}
