using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreninkWinForm.Forms
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            //fAKE DATA, pak budeme tahat z db
            Dictionary<string, int> questionsCountDictionary = new Dictionary<string, int>();
            questionsCountDictionary.Add("MAT", 5);
            questionsCountDictionary.Add("ČJ", 2);
            questionsCountDictionary.Add("PRG", 3);
            questionsCountDictionary.Add("FYZ", 12);
            questionsCountDictionary.Add("TEV", 1);

            Graphics g = e.Graphics;
            Pen myPen = Pens.Black;

            int columnWidth = 30;
            int columnSpacing = 15;
            int axis = 10;

            int graphPadding = 50;

            // Draw X and Y axes
            g.DrawLine(myPen, graphPadding - axis, pictureBox1.Height - graphPadding, pictureBox1.Width - graphPadding, pictureBox1.Height - graphPadding); //x
            g.DrawLine(myPen, graphPadding, graphPadding, graphPadding, pictureBox1.Height - graphPadding + axis);

            int startX = graphPadding;
            int startY = pictureBox1.Height - graphPadding ;

            int totalGraphHeight = pictureBox1.Height + graphPadding;
            int maxValue = questionsCountDictionary.Values.Max() ;
            int heightPerUnit = totalGraphHeight / maxValue;

            foreach (KeyValuePair<string, int> item in questionsCountDictionary)
            {
                startX += columnSpacing;

                int columnHeight = heightPerUnit * item.Value;
                Color columnColor = Color.Magenta;
                SolidBrush columnBrush = new SolidBrush(columnColor);

                g.FillRectangle(columnBrush,
                    startX, //x
                    startY - columnHeight, //y
                    columnWidth, //Width
                    columnHeight); //Height

                Font font = new Font("Arial", 10);
                Brush fontBrush = Brushes.Black;
                g.DrawString(item.Key, font, fontBrush, startX - axis - 5  + columnWidth  / 2  , startY + 5);

                startX += columnWidth;
            }

        }
    }
}
