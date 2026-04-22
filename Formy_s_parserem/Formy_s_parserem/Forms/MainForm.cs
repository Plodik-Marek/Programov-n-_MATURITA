using Formy_s_parserem.Entities;
using Formy_s_parserem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formy_s_parserem
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BindingList<Workers> workers = new BindingList<Workers>();

        }

        private void button_Graf_Click(object sender, EventArgs e)
        {
            Graf form = new Graf();
            form.Show();
        }
    }
}
