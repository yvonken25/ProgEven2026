using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProgEven2026
{
    public partial class EcranBDDirect : Form
    {

        private string chaineConnexion = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\GENERAL STORES-SARL\Desktop\HEL COURSES\BLOC 2\Programmation Evenementielle\Bd1.accdb";

        public EcranBDDirect()
        {
            InitializeComponent();
        }

        private void bConsulter_Click(object sender, EventArgs e)
        {
            lbConsole.Items.Clear();

            OleDbConnection connexion = new OleDbConnection(chaineConnexion);
            OleDbCommand commande = new OleDbCommand(
                "SELECT Prenom, Nom, NumCLi FROM Client ORDER BY Nom", connexion);

            try
            {
                connexion.Open();
                OleDbDataReader lecteur = commande.ExecuteReader();

                // 2. UTILISATION DU LECTEUR POUR REMPLIR LA LISTBOX
                while (lecteur.Read())
                {
                    // On récupère les colonnes par leur nom ou leur index
                    string prenom = lecteur["Prenom"].ToString();
                    string nom = lecteur["Nom"].ToString();
                    string numero = lecteur["NumCLi"].ToString();

                    // Ajout dans la ListBox
                    lbConsole.Items.Add($"{numero} : {nom} {prenom}");
                }

                lecteur.Close(); // Toujours fermer le lecteur
            }
            catch (Exception ex)
            {
                // Très important pour savoir POURQUOI ça plante (ex: fichier introuvable)
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                // On ferme la connexion quoi qu'il arrive
                if (connexion.State == ConnectionState.Open)
                    connexion.Close();
            }
        }

        private void EcranBDDirect_Load(object sender, EventArgs e)
        {

        }
    }
}
