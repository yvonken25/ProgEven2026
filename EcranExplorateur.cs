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
            // On écoute l'événement "Avant expansion"
            tvRepertoire.BeforeExpand += TvRepertoire_BeforeExpand;

            foreach (string drive in Directory.GetLogicalDrives())
            {
                TreeNode driveNode = new TreeNode(drive) { Tag = drive };
                // On ajoute un nœud vide pour forcer l'apparition du bouton [+]
                driveNode.Nodes.Add("...");
                tvRepertoire.Nodes.Add(driveNode);
            }
        }

        private void TvRepertoire_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode parentNode = e.Node;

            // Si le nœud contient notre dossier fictif "..."
            if (parentNode.Nodes.Count > 0 && parentNode.Nodes[0].Text == "...")
            {
                parentNode.Nodes.Clear(); // On retire le fictif
                string chemin = parentNode.Tag.ToString();

                try
                {
                    foreach (string dir in Directory.GetDirectories(chemin))
                    {
                        TreeNode node = new TreeNode(Path.GetFileName(dir)) { Tag = dir };
                        // On remet un dossier fictif sous chaque sous-dossier
                        node.Nodes.Add("...");
                        parentNode.Nodes.Add(node);
                    }
                }
                catch (UnauthorizedAccessException) { /* Dossier système protégé */ }
            }
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
