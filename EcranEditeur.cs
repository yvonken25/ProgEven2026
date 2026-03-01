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
    public partial class EcranEditeur : Form
    {
        private string sFichier = ""; // Stocke le chemin complet du fichier
        private bool bModifier = false;
        public EcranEditeur()
        {
            InitializeComponent();
            sFichier = "";
            bModifier = false;
            this.Text = "Nouvel éditeur - Sans titre";
        }


        private void FichierEnregistrer()
        {
            // Si pas de nom de fichier, on demande où enregistrer (Save As)
            if (string.IsNullOrEmpty(sFichier))
            {
                if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
                {
                    sFichier = sfdEnregistrer.FileName;
                }
                else return; // L'utilisateur a annulé
            }

            // Enregistrement effectif
            // On précise RichText pour garder la mise en forme (Gras, Italique, etc.)
            rtbTexte.SaveFile(sFichier, RichTextBoxStreamType.RichText);
            bModifier = false;
            this.Text = "Editeur - " + Path.GetFileName(sFichier);
        }

        private void VerifierSauver()
        {
            if (bModifier)
            {
                DialogResult rep = MessageBox.Show("Voulez-vous enregistrer les modifications ?",
                                                  "Enregistrement",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    FichierEnregistrer();
                }
            }
        }

        private void policeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fdPolice.ShowDialog() == DialogResult.OK)
            {
                // Applique la police uniquement au texte sélectionné
                rtbTexte.SelectionFont = fdPolice.Font;
            }
        }

        private void centreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void grasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont != null)
            {
                FontStyle styleActuel = rtbTexte.SelectionFont.Style;
                // Toggle le gras (si gras, on l'enlève, sinon on l'ajoute)
                FontStyle nouveauStyle = rtbTexte.SelectionFont.Bold ?
                                         styleActuel & ~FontStyle.Bold :
                                         styleActuel | FontStyle.Bold;

                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, nouveauStyle);
            }
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            if (ofdOuvrir.ShowDialog() == DialogResult.OK)
            {
                sFichier = ofdOuvrir.FileName;
                rtbTexte.LoadFile(sFichier, RichTextBoxStreamType.RichText);
                bModifier = false;
                this.Text = "Editeur - " + Path.GetFileName(sFichier);
            }
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            rtbTexte.Clear();
            sFichier = "";
            bModifier = false;
            this.Text = "Nouvel éditeur - Sans titre";
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            this.Close();
        }
    }
}
