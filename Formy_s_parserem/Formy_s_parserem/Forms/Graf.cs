using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formy_s_parserem.Forms
{
    public partial class Graf : Form
    {
        public Graf()
        {
            InitializeComponent();
        }

        private void pictureBox_Graf_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

           Pen pen = new Pen(Color.Red, 2);

            int axisX = 50;

            int axisY = 50;

            g.DrawLine(pen,axisY,axisX);
            
            
        }
    }
}
