using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public delegate double fctAIntegrer(double x);

namespace ProgEven2026
{
    public partial class Integration : Form
    {
        public Integration()
        {
            InitializeComponent();
        }



        private double MaFonctionPolynome(double x) => (x * x) + 2;
        private double MaFonctionSin(double x) => Math.Sin(x);

        private double AireTrapeze(fctAIntegrer f, double x1, double x2)
        {
            return (f(x1) + f(x2)) * (x2 - x1) / 2.0;
        }


        double IntegrationTrapeze(fctAIntegrer f, double xGauche, double xDroit, int nInterval)
        {
            double sommeAires = 0;
            double h = (xDroit - xGauche) / nInterval;
            for (int i = 0; i < nInterval; i++)
            {
                sommeAires += AireTrapeze(f, xGauche + i * h, xGauche + (i + 1) * h);
            }
            return sommeAires;
        }

        private void bPointeurTrigonometrique_Click(object sender, EventArgs e)
        {
            double g = double.Parse(tbGauche.Text);
            double d = double.Parse(tbDroite.Text);
            int nBase = int.Parse(tbNbInt.Text);

            lbResultats.Items.Add("Méthode des trapèzes (Pointeur)");
            lbResultats.Items.Add("Trigonométrique : sin(x)");

            for (int m = 1; m <= 16; m *= 2)
            {
                int nActuel = nBase * m;

                double res = IntegrationTrapeze(MaFonctionSin, g, d, nActuel);
                lbResultats.Items.Add($"  Nb Int : {nActuel} => {res}");
            }
        }

        private void bPolynome_Click(object sender, EventArgs e)
        {

            double g = double.Parse(tbGauche.Text);
            double d = double.Parse(tbDroite.Text);
            int nBase = int.Parse(tbNbInt.Text);

            lbResultats.Items.Add("Méthode des trapèzes (Traditionnelle)");
            lbResultats.Items.Add("Polynôme : x*x + 2");


            for (int m = 1; m <= 16; m *= 2)
            {
                int nActuel = nBase * m;
                double h = (d - g) / nActuel;
                double sommeAires = 0;

                for (int i = 0; i < nActuel; i++)
                {
                    double x1 = g + i * h;
                    double x2 = x1 + h;


                    double y1 = (x1 * x1) + 2;
                    double y2 = (x2 * x2) + 2;

                    sommeAires += (y1 + y2) * h / 2.0;
                }
                lbResultats.Items.Add($"  Nb Int : {nActuel} => {sommeAires}");
            }
        }

        private void bTrigonometrique_Click(object sender, EventArgs e)
        {
            double g = double.Parse(tbGauche.Text);
            double d = double.Parse(tbDroite.Text);
            int nBase = int.Parse(tbNbInt.Text);

            lbResultats.Items.Add("Méthode des trapèzes (Traditionnelle)");
            lbResultats.Items.Add("Trigonométrique : sin(x)");

            for (int m = 1; m <= 16; m *= 2)
            {
                int nActuel = nBase * m;
                double h = (d - g) / nActuel;
                double sommeAires = 0;

                for (int i = 0; i < nActuel; i++)
                {
                    double x1 = g + i * h;
                    double x2 = x1 + h;


                    double y1 = Math.Sin(x1);
                    double y2 = Math.Sin(x2);

                    sommeAires += (y1 + y2) * h / 2.0;
                }
                lbResultats.Items.Add($"  Nb Int : {nActuel} => {sommeAires}");
            }
        }

        private void bPointeurPolynome_Click(object sender, EventArgs e)
        {
            double g = double.Parse(tbGauche.Text);
            double d = double.Parse(tbDroite.Text);
            int nBase = int.Parse(tbNbInt.Text);

            lbResultats.Items.Add("Méthode des trapèzes (Pointeur)");
            lbResultats.Items.Add("Polynôme : x*x + 2");

            for (int m = 1; m <= 16; m *= 2)
            {
                int nActuel = nBase * m;
                
                double res = IntegrationTrapeze(MaFonctionPolynome, g, d, nActuel);
                lbResultats.Items.Add($"  Nb Int : {nActuel} => {res}");
            }
        }
    }
}
