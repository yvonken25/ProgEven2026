using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgEven2026
{
    public partial class EcranExplorateur : Form
    {
        public EcranExplorateur()
        {
            InitializeComponent();

            tvRepertoire.ImageList = ilTreeView;
            lvFichiers.LargeImageList = ilGrand;
            lvFichiers.SmallImageList = ilPetit;

            // 2. APPEL INITIAL (indispensable pour voir quelque chose)
            RemplirTreeView();
        }

        private void RemplirTreeView()
        {
            tvRepertoire.Nodes.Clear();
            TreeNode root = new TreeNode("Poste de travail");
            tvRepertoire.Nodes.Add(root);

            foreach (string drive in Environment.GetLogicalDrives())
            {
                TreeNode driveNode = new TreeNode(drive);
                root.Nodes.Add(driveNode);

                try
                {
                    LireRepertoires(drive, driveNode);
                }
                catch { /* Ignorer les disques non prêts (CD, USB vide) */ }
            }
            root.Expand();
        }

        private void LireRepertoires(string chemin, TreeNode parentNode)
        {
            try
            {
                string[] directories = Directory.GetDirectories(chemin);
                foreach (string dir in directories)
                {
                    // On récupère juste le nom du dossier pour l'affichage
                    TreeNode node = new TreeNode(Path.GetFileName(dir));
                    // On stocke le chemin complet dans le Tag pour une utilisation future
                    node.Tag = dir;
                    parentNode.Nodes.Add(node);

                    // Appel récursif (Attention : peut être lent sur de gros disques)
                    // Optionnel : ne remplir que sur clic pour optimiser
                    LireRepertoires(dir, node);
                }
            }
            catch { /* Accès refusé ou dossier système */ }
        }

        private void tsaPetitesIcones_Click(object sender, EventArgs e) => lvFichiers.View = View.SmallIcon;
        private void tsaGrandesIcones_Click(object sender, EventArgs e) => lvFichiers.View = View.LargeIcon;
        private void tsaListe_Click(object sender, EventArgs e) => lvFichiers.View = View.List;
        private void tsaDetail_Click(object sender, EventArgs e) => lvFichiers.View = View.Details;


    }
}
