using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgEven2026
{
    public partial class EcranListe : Form
    {
        private string NomFichier = "";
        public EcranListe()
        {
            InitializeComponent();
        }

        private void Activer(bool etat)
        {

            lbPersonne.Enabled = etat;
            bOuvrir.Enabled = etat;
            bEnregistrer.Enabled = etat;
            bAjouter.Enabled = etat;
            bSupprimer.Enabled = etat;


            gbDetail.Enabled = !etat;
        }


        private void EcranListe_Load(object sender, EventArgs e)
        {
            Activer(true);
            NomFichier = "donnees.txt";
            cbQualite.Items.Add("Monsieur");
            cbQualite.Items.Add("Madame");
            cbQualite.Items.Add("Mademoiselle");
            cbQualite.Items.Add("Mondemoiseau");

        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
            tbNom.Focus();
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex != -1)
            {
                int indexASupprimer = lbPersonne.SelectedIndex;

                int numeroSupprime = indexASupprimer + 1; for (int i = 0; i < lbPersonne.Items.Count; i++)
                {
                    string ligneCourante = lbPersonne.Items[i].ToString();
                    int positionHash = ligneCourante.LastIndexOf('#');

                    if (positionHash != -1)
                    {
                        string texte = ligneCourante.Substring(0, positionHash);
                        int idActuel = int.Parse(ligneCourante.Substring(positionHash + 1));

                        // Si l'ID est supérieur à celui supprimé, on décrémente
                        if (idActuel > numeroSupprime)
                        {
                            lbPersonne.Items[i] = $"{texte}#{idActuel - 1}";
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
            }
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            string ligne = $"{tbNom.Text} ({cbQualite.Text})";
            lbPersonne.Items.Add(ligne);

            // On vide les champs et on revient à l'état initial
            tbNom.Clear();
            cbQualite.SelectedIndex = -1;
            Activer(true);
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void bOuvrir_Click(object sender, EventArgs e)
        {
            if (ofdOuvrirFichier.ShowDialog() == DialogResult.OK)
            {
                NomFichier = ofdOuvrirFichier.FileName;
                lbPersonne.Items.Clear();

                string[] lignes = File.ReadAllLines(NomFichier);
                foreach (string l in lignes)
                {
                    if (l.Contains("#"))
                        lbPersonne.Items.Add(l);
                    else
                        lbPersonne.Items.Add($"{l}#{lbPersonne.Items.Count + 1}");

                }
            }
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
            {
                NomFichier = sfdEnregistrer.FileName;

                // Conversion des items de la ListBox en tableau de strings
                string[] lignes = new string[lbPersonne.Items.Count];
                for (int i = 0; i < lbPersonne.Items.Count; i++)
                {
                    lignes[i] = lbPersonne.Items[i].ToString();
                }

                File.WriteAllLines(NomFichier, lignes);
            }
        }

        private void cbQualite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
