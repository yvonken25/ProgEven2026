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
    public partial class EcranClavierSouris : Form
    {

        private int nbGauche = 0;
        private int nbDroit = 0;
        public EcranClavierSouris()
        {
            InitializeComponent();
        }

        private void AfficherClic()
        {
            tbxClicGauche.Text = nbGauche.ToString();
            tbxClicDroit.Text = nbDroit.ToString();
        }
        private void pnlSouris_MouseMove(object sender, MouseEventArgs e)
        {
            tbxPositionX.Text = e.X.ToString();
            tbxPositionY.Text = e.Y.ToString();
        }

        private void pnlSouris_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) nbGauche++;
            if (e.Button == MouseButtons.Right) nbDroit++;

            AfficherClic();
            DetecterCase(e.X, e.Y); // Pour le travail sur les 9 cases
        }
        private void EcranClavierSouris_KeyDown(object sender, KeyEventArgs e)
        {
            lsbClavier.Items.Insert(0, $"Down: {e.KeyCode}");
        }
        private void butRAZ_Click(object sender, EventArgs e)
        {
            nbGauche = 0;
            nbDroit = 0;
            AfficherClic();
            tbxPositionX.Clear();
            tbxPositionY.Clear();
            lsbClavier.Items.Clear();
        }

        private void DetecterCase(int x, int y)
        {
            // Calcul de la taille d'une case
            int largeurCase = pnlSouris.Width / 3;
            int hauteurCase = pnlSouris.Height / 3;

            // Détermination de la colonne (1, 2 ou 3)
            // On utilise Math.Min pour éviter un débordement si on clique sur la bordure droite
            int col = Math.Min((x / largeurCase) + 1, 3);

            // Détermination de la ligne (1, 2 ou 3)
            int lig = Math.Min((y / hauteurCase) + 1, 3);

            lsbClavier.Items.Insert(0, $"Clic Case : Ligne {lig}, Col {col}");
        }
    }
}
