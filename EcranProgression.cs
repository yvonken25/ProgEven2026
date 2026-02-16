using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgEven2026
{
    public partial class EcranProgression : Form
    {
        public EcranProgression()
        {
            InitializeComponent();
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bExecuter_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int nombreFichiers = rnd.Next(3, 8); // entre 3 et 7 fichiers

            pbPrincipal.Minimum = 0;
            pbPrincipal.Maximum = nombreFichiers;
            pbPrincipal.Value = 0;

            // Désactivation
            bExecuter.Enabled = false;
            bQuitter.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            for (int i = 1; i <= nombreFichiers; i++)
            {
                lPrincipal.Text = "Copie fichier " + i + " / " + nombreFichiers;

                int tailleFichier = rnd.Next(10, 40);

                pbSecondaire.Minimum = 0;
                pbSecondaire.Maximum = tailleFichier;
                pbSecondaire.Value = 0;

                for (int j = 0; j < tailleFichier; j++)
                {
                    pbSecondaire.Value = j + 1;
                    lSecondaire.Text = "Progression : " + (j + 1) + " / " + tailleFichier;

                    Thread.Sleep(50); // simulation taille fichier
                    Application.DoEvents(); // permet mise à jour visuelle
                }

                pbPrincipal.Value = i;
            }

            lPrincipal.Text = "Copie terminée !";
            lSecondaire.Text = "";

            this.Cursor = Cursors.Default;
            bExecuter.Enabled = true;
            bQuitter.Enabled = true;
        }
    }
}
