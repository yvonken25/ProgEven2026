namespace ProgEven2026
{
    partial class EcranExplorateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranExplorateur));
            ListViewItem listViewItem1 = new ListViewItem("Nom");
            ListViewItem listViewItem2 = new ListViewItem("Taille");
            ListViewItem listViewItem3 = new ListViewItem("Creation");
            ListViewItem listViewItem4 = new ListViewItem("Modifications");
            ListViewItem listViewItem5 = new ListViewItem("");
            tsCommandes = new ToolStrip();
            tsbQuitter = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsddbApparence = new ToolStripDropDownButton();
            tsaPetiteIcone = new ToolStripMenuItem();
            tsaGrandeIcone = new ToolStripMenuItem();
            tsaListe = new ToolStripMenuItem();
            tsaDetail = new ToolStripMenuItem();
            ssMessage = new StatusStrip();
            sIMessage = new ToolStripStatusLabel();
            scSeparateur = new SplitContainer();
            tvRepertoire = new TreeView();
            lvFichiers = new ListView();
            NOM = new ColumnHeader();
            TAIL = new ColumnHeader();
            CREA = new ColumnHeader();
            MODI = new ColumnHeader();
            ilTreeView = new ImageList(components);
            ilGrand = new ImageList(components);
            ilPetit = new ImageList(components);
            tsCommandes.SuspendLayout();
            ssMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scSeparateur).BeginInit();
            scSeparateur.Panel1.SuspendLayout();
            scSeparateur.Panel2.SuspendLayout();
            scSeparateur.SuspendLayout();
            SuspendLayout();
            // 
            // tsCommandes
            // 
            tsCommandes.ImageScalingSize = new Size(24, 24);
            tsCommandes.Items.AddRange(new ToolStripItem[] { tsbQuitter, toolStripSeparator1, tsddbApparence });
            tsCommandes.Location = new Point(0, 0);
            tsCommandes.Name = "tsCommandes";
            tsCommandes.Size = new Size(1004, 33);
            tsCommandes.TabIndex = 0;
            tsCommandes.Text = "toolStrip1";
            // 
            // tsbQuitter
            // 
            tsbQuitter.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbQuitter.Image = (Image)resources.GetObject("tsbQuitter.Image");
            tsbQuitter.ImageTransparentColor = Color.Magenta;
            tsbQuitter.Name = "tsbQuitter";
            tsbQuitter.Size = new Size(34, 28);
            tsbQuitter.Text = "Quitter";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 33);
            // 
            // tsddbApparence
            // 
            tsddbApparence.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsddbApparence.DropDownItems.AddRange(new ToolStripItem[] { tsaPetiteIcone, tsaGrandeIcone, tsaListe, tsaDetail });
            tsddbApparence.Image = (Image)resources.GetObject("tsddbApparence.Image");
            tsddbApparence.ImageTransparentColor = Color.Magenta;
            tsddbApparence.Name = "tsddbApparence";
            tsddbApparence.Size = new Size(42, 28);
            tsddbApparence.Text = "toolStripDropDownButton1";
            // 
            // tsaPetiteIcone
            // 
            tsaPetiteIcone.Name = "tsaPetiteIcone";
            tsaPetiteIcone.Size = new Size(219, 34);
            tsaPetiteIcone.Text = "Petite Icone";
            tsaPetiteIcone.Click += tsaPetitesIcones_Click;
            // 
            // tsaGrandeIcone
            // 
            tsaGrandeIcone.Name = "tsaGrandeIcone";
            tsaGrandeIcone.Size = new Size(219, 34);
            tsaGrandeIcone.Text = "Grande Icone";
            tsaGrandeIcone.Click += tsaGrandesIcones_Click;
            // 
            // tsaListe
            // 
            tsaListe.Name = "tsaListe";
            tsaListe.Size = new Size(219, 34);
            tsaListe.Text = "Liste";
            tsaListe.Click += tsaListe_Click;
            // 
            // tsaDetail
            // 
            tsaDetail.Name = "tsaDetail";
            tsaDetail.Size = new Size(219, 34);
            tsaDetail.Text = "Detail";
            tsaDetail.Click += tsaDetail_Click;
            // 
            // ssMessage
            // 
            ssMessage.ImageScalingSize = new Size(24, 24);
            ssMessage.Items.AddRange(new ToolStripItem[] { sIMessage });
            ssMessage.Location = new Point(0, 453);
            ssMessage.Name = "ssMessage";
            ssMessage.Size = new Size(1004, 32);
            ssMessage.TabIndex = 1;
            ssMessage.Text = "statusStrip1";
            // 
            // sIMessage
            // 
            sIMessage.Name = "sIMessage";
            sIMessage.Size = new Size(92, 25);
            sIMessage.Text = "Bienvenue";
            // 
            // scSeparateur
            // 
            scSeparateur.Dock = DockStyle.Fill;
            scSeparateur.Location = new Point(0, 33);
            scSeparateur.Name = "scSeparateur";
            // 
            // scSeparateur.Panel1
            // 
            scSeparateur.Panel1.Controls.Add(tvRepertoire);
            // 
            // scSeparateur.Panel2
            // 
            scSeparateur.Panel2.Controls.Add(lvFichiers);
            scSeparateur.Size = new Size(1004, 420);
            scSeparateur.SplitterDistance = 334;
            scSeparateur.TabIndex = 2;
            // 
            // tvRepertoire
            // 
            tvRepertoire.Location = new Point(-1, 0);
            tvRepertoire.Name = "tvRepertoire";
            tvRepertoire.Size = new Size(332, 417);
            tvRepertoire.TabIndex = 0;
            // 
            // lvFichiers
            // 
            lvFichiers.Columns.AddRange(new ColumnHeader[] { NOM, TAIL, CREA, MODI });
            lvFichiers.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            lvFichiers.Location = new Point(3, 0);
            lvFichiers.Name = "lvFichiers";
            lvFichiers.Size = new Size(660, 420);
            lvFichiers.TabIndex = 0;
            lvFichiers.UseCompatibleStateImageBehavior = false;
            // 
            // NOM
            // 
            NOM.Text = "Nom";
            // 
            // TAIL
            // 
            TAIL.Text = "Tail";
            // 
            // CREA
            // 
            CREA.Text = "Creation";
            // 
            // MODI
            // 
            MODI.Text = "Modification";
            // 
            // ilTreeView
            // 
            ilTreeView.ColorDepth = ColorDepth.Depth32Bit;
            ilTreeView.ImageSize = new Size(16, 16);
            ilTreeView.TransparentColor = Color.Transparent;
            // 
            // ilGrand
            // 
            ilGrand.ColorDepth = ColorDepth.Depth32Bit;
            ilGrand.ImageSize = new Size(16, 16);
            ilGrand.TransparentColor = Color.Transparent;
            // 
            // ilPetit
            // 
            ilPetit.ColorDepth = ColorDepth.Depth32Bit;
            ilPetit.ImageSize = new Size(16, 16);
            ilPetit.TransparentColor = Color.Transparent;
            // 
            // EcranExplorateur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 485);
            Controls.Add(scSeparateur);
            Controls.Add(ssMessage);
            Controls.Add(tsCommandes);
            Name = "EcranExplorateur";
            Text = "EcranExplorateur";
            tsCommandes.ResumeLayout(false);
            tsCommandes.PerformLayout();
            ssMessage.ResumeLayout(false);
            ssMessage.PerformLayout();
            scSeparateur.Panel1.ResumeLayout(false);
            scSeparateur.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scSeparateur).EndInit();
            scSeparateur.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsCommandes;
        private ToolStripButton tsbQuitter;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tsddbApparence;
        private ToolStripMenuItem tsaPetiteIcone;
        private ToolStripMenuItem tsaGrandeIcone;
        private ToolStripMenuItem tsaListe;
        private ToolStripMenuItem tsaDetail;
        private StatusStrip ssMessage;
        private ToolStripStatusLabel sIMessage;
        private SplitContainer scSeparateur;
        private TreeView tvRepertoire;
        private ListView lvFichiers;
        private ColumnHeader NOM;
        private ColumnHeader TAIL;
        private ColumnHeader CREA;
        private ColumnHeader MODI;
        private ImageList ilTreeView;
        private ImageList ilGrand;
        private ImageList ilPetit;
    }
}