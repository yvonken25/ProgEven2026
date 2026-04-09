using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProgEven2026
{
    public partial class EcranSpirographe : Form
    {

        private Color cFond;
        private Color cTrait;
        private GraphicsPath gpSauvegarde = null;
        public EcranSpirographe()
        {
            InitializeComponent();

            cFond = Color.Black;
            cTrait = Color.Turquoise;

            // Configuration des TrackBars (exemples de plages)
            tbSommets.Minimum = 3; tbSommets.Maximum = 8;
            tbDensite.Minimum = 2; tbDensite.Maximum = 50;
            tbProfondeur.Minimum = 1; tbProfondeur.Maximum = 90;
        }

        private void EcranSpirographe_Load(object sender, EventArgs e)
        {

        }

        private void bFond_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK)
            {
                cFond = cdCouleur.Color;
                this.Invalidate(new Rectangle(248, 0, ClientSize.Width - 248, ClientSize.Height));
            }
        }

        private void bTrait_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK)
            {
                cTrait = cdCouleur.Color;
                this.Invalidate(new Rectangle(248, 0, ClientSize.Width - 248, ClientSize.Height));
            }
        }

      

        private void bGo_Click(object sender, EventArgs e)
        {
            int iSommets = tbSommets.Value;
            int iDensite = tbDensite.Value;
            int iProfondeur = tbProfondeur.Value;

            gpSauvegarde = new GraphicsPath();

            // Calcul du centre et rayon de la zone droite
            double xc = 248 + (ClientSize.Width - 248) / 2.0;
            double yc = ClientSize.Height / 2.0;
            double rayon = Math.Min(ClientSize.Width - 248, ClientSize.Height) / 2.0 - 10;

            double[] sx = new double[iSommets + 1];
            double[] sy = new double[iSommets + 1];

            // 1. Positionnement des sommets initiaux
            for (int i = 0; i <= iSommets; i++)
            {
                sx[i] = xc + rayon * Math.Cos(2 * Math.PI * i / iSommets);
                sy[i] = yc + rayon * Math.Sin(2 * Math.PI * i / iSommets);
            }

            double limite = rayon * iProfondeur / 100.0;

            // 2. Boucle de génération du spirographe
            // On s'arrête quand la distance au centre est trop petite
            while (rayon > limite)
            {
                // Dessiner le polygone actuel
                for (int i = 0; i < iSommets; i++)
                {
                    gpSauvegarde.AddLine((float)sx[i], (float)sy[i], (float)sx[i + 1], (float)sy[i + 1]);
                }

                // Calcul des nouveaux sommets (décalage vers l'intérieur)
                for (int i = 0; i < iSommets; i++)
                {
                    sx[i] = sx[i] + (sx[i + 1] - sx[i]) / iDensite;
                    sy[i] = sy[i] + (sy[i + 1] - sy[i]) / iDensite;
                }
                // Fermer le polygone pour la prochaine itération
                sx[iSommets] = sx[0];
                sy[iSommets] = sy[0];

                // Recalculer le rayon actuel (distance d'un sommet au centre)
                rayon = Math.Sqrt(Math.Pow(sx[0] - xc, 2) + Math.Pow(sy[0] - yc, 2));
            }

            this.Invalidate();
        }

        // UN SEUL OnPaint pour tout gérer
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // --- 1. DESSIN DU SPIROGRAPHE (S'il existe) ---
            if (gpSauvegarde != null)
            {
                // On remplit la zone de dessin (à droite du panneau 248px)
                e.Graphics.FillRectangle(new SolidBrush(cFond), new Rectangle(248, 0, ClientSize.Width - 248, ClientSize.Height));
                e.Graphics.DrawPath(new Pen(cTrait), gpSauvegarde);
            }

            // --- 2. DESSIN DE L'HORLOGE ---
            // On peut la dessiner par-dessus ou ailleurs. 
            // Ici, on garde ta logique de calcul au centre de la fenêtre.
            DateTime mnt = DateTime.Now;

            float xc = ClientSize.Width / 2f;
            float yc = ClientSize.Height / 2f;
            float r = Math.Min(xc, yc) - 20;

            // Fond de l'horloge
            g.DrawEllipse(Pens.Black, xc - r, yc - r, 2 * r, 2 * r);

            // Secondes
            double sAngle = 2 * Math.PI * mnt.Second / 60.0 - Math.PI / 2;
            DessinerAiguille(g, xc, yc, sAngle, r * 0.9, Pens.Red);

            // Minutes
            double mAngle = 2 * Math.PI * (mnt.Minute + mnt.Second / 60.0) / 60.0 - Math.PI / 2;
            DessinerAiguille(g, xc, yc, mAngle, r * 0.8, Pens.Black);

            // Heures
            double hAngle = 2 * Math.PI * (mnt.Hour % 12 + mnt.Minute / 60.0) / 12.0 - Math.PI / 2;
            DessinerAiguille(g, xc, yc, hAngle, r * 0.5, new Pen(Color.Black, 3));
        }

        private void DessinerAiguille(Graphics g, float xc, float yc, double angle, double longu, Pen p)
        {
            float xEnd = xc + (float)(longu * Math.Cos(angle));
            float yEnd = yc + (float)(longu * Math.Sin(angle));
            g.DrawLine(p, xc, yc, xEnd, yEnd);
        }

        private void timerHorloge_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString("HH:mm:ss");
            this.Invalidate(); // Force l'appel à OnPaint
        }
        private void timerHorloge_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
