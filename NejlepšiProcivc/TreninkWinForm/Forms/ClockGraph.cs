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
    public partial class ClockGraph : Form
    {
        public ClockGraph()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;

            // velikost kruhu = menší z width/height (aby byl vždy čtverec)
            int size = Math.Min(pictureBox1.Width, pictureBox1.Height) - 20;

            // obdélník, do kterého se bude kreslit kruh (pozice + velikost)
            Rectangle rect = new Rectangle(180, 5, size, size);

            // střed kruhu (od něj se kreslí ručičky)
            int centerX = rect.X + rect.Width / 2;
            int centerY = rect.Y + rect.Height / 2;

            // poloměr kruhu (polovina šířky)
            int radius = rect.Width / 2;
        
            // nakreslení obrysu kruhu
            g.DrawEllipse(Pens.Black, rect);

            // vyplnění celého kruhu (pozadí hodin)
            g.FillEllipse(new SolidBrush(Color.LightBlue), rect);



            // aktuální čas
            DateTime now = DateTime.Now;

            // výpočet úhlu pro hodiny
            // hodina = 30° (360 / 12)
            // + přičítáme minuty, aby se ručička plynule posouvala
            float hourAngle = (now.Hour % 12 + now.Minute / 60f) * 30f;

            // výpočet úhlu pro minuty
            // minuta = 6° (360 / 60)
            float minuteAngle = now.Minute * 6f;

            // koláč (výseč) od 12 hodin (-90°) do aktuální hodiny
            // -90 protože 0° je doprava → chceme začít nahoře
            g.FillPie(new SolidBrush(Color.LightBlue), rect, -90, hourAngle);



            // ručičky (kreslí se od středu do vypočteného bodu)
            DrawHand(g, hourAngle, radius * 0.5, Pens.Black, centerX, centerY); // hodinová
            DrawHand(g, minuteAngle, radius * 0.7, Pens.Blue, centerX, centerY); // minutová

            // font pro čísla
            Font f = new Font("Arial", 10);

            // čísla na ciferníku (ručně umístěná)
            g.DrawString("12", f, Brushes.Black, centerX - 10, rect.Y);
            g.DrawString("6", f, Brushes.Black, centerX - 5, rect.Bottom - 20);
            g.DrawString("3", f, Brushes.Black, rect.Right - 20, centerY - 5);
            g.DrawString("9", f, Brushes.Black, rect.X, centerY - 5);
        }
        private void DrawHand(Graphics g, float angle, double length, Pen pen, int cx, int cy)
        {
            // převod stupňů na radiány (Math.Cos a Sin pracují s radiány)
            // -90 protože chceme začínat nahoře (12 hodin)
            double rad = (angle - 90) * Math.PI / 180;

            // výpočet koncového bodu ručičky
            int x = cx + (int)(Math.Cos(rad) * length);
            int y = cy + (int)(Math.Sin(rad) * length);

            // vykreslení čáry (ručičky)
            g.DrawLine(pen, cx, cy, x, y);
        }

    }
    
}
