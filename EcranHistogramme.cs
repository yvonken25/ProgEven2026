using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProgEven2026
{
    public partial class EcranHistogramme : Form
    {

        ArrayList alData = new ArrayList();
        Random rnd = new Random();
        public EcranHistogramme()
        {
            InitializeComponent();
        }



        private void bCreer_Click(object sender, EventArgs e)
        {
            alData.Clear();
            lbMonPoint.Items.Clear();

            int nbPoints = rnd.Next(5, 15); // Nombre aléatoire > 0
            int currentX = 0;

            for (int i = 0; i < nbPoints; i++)
            {
                currentX += rnd.Next(10, 50); // X croissant
                int currentY = rnd.Next(-100, 101); // Y entre -100 et 100

                MonPoint mp = new MonPoint(currentX, currentY);
                alData.Add(mp);
                lbMonPoint.Items.Add(mp);
            }
        }

        private void bDessiner_Click(object sender, EventArgs e)
        {
            pDessin.Invalidate();
        }

        private void pDessin_Paint(object sender, PaintEventArgs e)
        {
            if (alData.Count < 2) return;

            Graphics g = e.Graphics;
            Pen penBleu = new Pen(Color.DarkBlue, 2);
            Pen penRouge = new Pen(Color.Red, 1);

 
            int xMin = ((MonPoint)alData[0]).X;
            int xMax = ((MonPoint)alData[alData.Count - 1]).X;

            
            float milieuY = pDessin.Height / 2f;
            g.DrawLine(penRouge, 0, milieuY, pDessin.Width, milieuY);

            
            PointF[] ptsTrace = new PointF[alData.Count];
            for (int i = 0; i < alData.Count; i++)
            {
                MonPoint mp = (MonPoint)alData[i];

                float scaledX = (float)(mp.X - xMin) / (xMax - xMin) * pDessin.Width;
                float scaledY = milieuY - (mp.Y * (pDessin.Height / 200f));

                ptsTrace[i] = new PointF(scaledX, scaledY);
            }

            
            for (int i = 0; i < ptsTrace.Length - 1; i++)
            {
                // Ligne horizontale vers le X suivant
                g.DrawLine(penBleu, ptsTrace[i].X, ptsTrace[i].Y, ptsTrace[i + 1].X, ptsTrace[i].Y);
                // Ligne verticale vers le Y suivant
                g.DrawLine(penBleu, ptsTrace[i + 1].X, ptsTrace[i].Y, ptsTrace[i + 1].X, ptsTrace[i + 1].Y);
            }
        }
    }
}
