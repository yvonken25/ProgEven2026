namespace ProgEven2026
{
    partial class EcranEditeur
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
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            nouveauToolStripMenuItem = new ToolStripMenuItem();
            ouvrirToolStripMenuItem = new ToolStripMenuItem();
            enregistrerToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            editerToolStripMenuItem = new ToolStripMenuItem();
            copierToolStripMenuItem = new ToolStripMenuItem();
            couperToolStripMenuItem = new ToolStripMenuItem();
            collerToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            justifierToolStripMenuItem = new ToolStripMenuItem();
            gaucheToolStripMenuItem = new ToolStripMenuItem();
            centreToolStripMenuItem = new ToolStripMenuItem();
            droiteToolStripMenuItem = new ToolStripMenuItem();
            policeToolStripMenuItem = new ToolStripMenuItem();
            caractereToolStripMenuItem = new ToolStripMenuItem();
            grasToolStripMenuItem = new ToolStripMenuItem();
            italiqueToolStripMenuItem = new ToolStripMenuItem();
            souligneToolStripMenuItem = new ToolStripMenuItem();
            barreToolStripMenuItem = new ToolStripMenuItem();
            pMenu = new Panel();
            pbQuitter = new PictureBox();
            pbEnregistrer = new PictureBox();
            pbNouveau = new PictureBox();
            pbOuvrir = new PictureBox();
            rtbTexte = new RichTextBox();
            ofdOuvrir = new OpenFileDialog();
            sfdEnregistrer = new SaveFileDialog();
            fdPolice = new FontDialog();
            menuStrip1.SuspendLayout();
            pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQuitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnregistrer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNouveau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOuvrir).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, editerToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouveauToolStripMenuItem, ouvrirToolStripMenuItem, enregistrerToolStripMenuItem, quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(78, 29);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            nouveauToolStripMenuItem.Size = new Size(270, 34);
            nouveauToolStripMenuItem.Text = "Nouveau";
            nouveauToolStripMenuItem.Click += nouveauToolStripMenuItem_Click;
            // 
            // ouvrirToolStripMenuItem
            // 
            ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            ouvrirToolStripMenuItem.Size = new Size(270, 34);
            ouvrirToolStripMenuItem.Text = "Ouvrir";
            ouvrirToolStripMenuItem.Click += ouvrirToolStripMenuItem_Click;
            // 
            // enregistrerToolStripMenuItem
            // 
            enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            enregistrerToolStripMenuItem.Size = new Size(270, 34);
            enregistrerToolStripMenuItem.Text = "Enregistrer";
            enregistrerToolStripMenuItem.Click += enregistrerToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(270, 34);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // editerToolStripMenuItem
            // 
            editerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copierToolStripMenuItem, couperToolStripMenuItem, collerToolStripMenuItem });
            editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            editerToolStripMenuItem.Size = new Size(78, 29);
            editerToolStripMenuItem.Text = "Editer ";
            // 
            // copierToolStripMenuItem
            // 
            copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            copierToolStripMenuItem.Size = new Size(172, 34);
            copierToolStripMenuItem.Text = "Copier";
            // 
            // couperToolStripMenuItem
            // 
            couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            couperToolStripMenuItem.Size = new Size(172, 34);
            couperToolStripMenuItem.Text = "Couper";
            // 
            // collerToolStripMenuItem
            // 
            collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            collerToolStripMenuItem.Size = new Size(172, 34);
            collerToolStripMenuItem.Text = "Coller";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { justifierToolStripMenuItem, policeToolStripMenuItem, caractereToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(85, 29);
            formatToolStripMenuItem.Text = "Format";
            // 
            // justifierToolStripMenuItem
            // 
            justifierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gaucheToolStripMenuItem, centreToolStripMenuItem, droiteToolStripMenuItem });
            justifierToolStripMenuItem.Name = "justifierToolStripMenuItem";
            justifierToolStripMenuItem.Size = new Size(187, 34);
            justifierToolStripMenuItem.Text = "Justifier";
            // 
            // gaucheToolStripMenuItem
            // 
            gaucheToolStripMenuItem.Name = "gaucheToolStripMenuItem";
            gaucheToolStripMenuItem.Size = new Size(172, 34);
            gaucheToolStripMenuItem.Text = "Gauche";
            // 
            // centreToolStripMenuItem
            // 
            centreToolStripMenuItem.Name = "centreToolStripMenuItem";
            centreToolStripMenuItem.Size = new Size(172, 34);
            centreToolStripMenuItem.Text = "Centre";
            centreToolStripMenuItem.Click += centreToolStripMenuItem_Click;
            // 
            // droiteToolStripMenuItem
            // 
            droiteToolStripMenuItem.Name = "droiteToolStripMenuItem";
            droiteToolStripMenuItem.Size = new Size(172, 34);
            droiteToolStripMenuItem.Text = "Droite";
            // 
            // policeToolStripMenuItem
            // 
            policeToolStripMenuItem.Name = "policeToolStripMenuItem";
            policeToolStripMenuItem.Size = new Size(187, 34);
            policeToolStripMenuItem.Text = "Police";
            policeToolStripMenuItem.Click += policeToolStripMenuItem_Click;
            // 
            // caractereToolStripMenuItem
            // 
            caractereToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grasToolStripMenuItem, italiqueToolStripMenuItem, souligneToolStripMenuItem, barreToolStripMenuItem });
            caractereToolStripMenuItem.Name = "caractereToolStripMenuItem";
            caractereToolStripMenuItem.Size = new Size(187, 34);
            caractereToolStripMenuItem.Text = "Caractere";
            // 
            // grasToolStripMenuItem
            // 
            grasToolStripMenuItem.Name = "grasToolStripMenuItem";
            grasToolStripMenuItem.Size = new Size(188, 34);
            grasToolStripMenuItem.Text = "Gras";
            grasToolStripMenuItem.Click += grasToolStripMenuItem_Click;
            // 
            // italiqueToolStripMenuItem
            // 
            italiqueToolStripMenuItem.Name = "italiqueToolStripMenuItem";
            italiqueToolStripMenuItem.Size = new Size(188, 34);
            italiqueToolStripMenuItem.Text = "Italique";
            // 
            // souligneToolStripMenuItem
            // 
            souligneToolStripMenuItem.Name = "souligneToolStripMenuItem";
            souligneToolStripMenuItem.Size = new Size(188, 34);
            souligneToolStripMenuItem.Text = "Souligne ";
            // 
            // barreToolStripMenuItem
            // 
            barreToolStripMenuItem.Name = "barreToolStripMenuItem";
            barreToolStripMenuItem.Size = new Size(188, 34);
            barreToolStripMenuItem.Text = "Barre";
            // 
            // pMenu
            // 
            pMenu.Controls.Add(pbQuitter);
            pMenu.Controls.Add(pbEnregistrer);
            pMenu.Controls.Add(pbNouveau);
            pMenu.Controls.Add(pbOuvrir);
            pMenu.Dock = DockStyle.Top;
            pMenu.Location = new Point(0, 33);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(800, 150);
            pMenu.TabIndex = 1;
            // 
            // pbQuitter
            // 
            pbQuitter.Location = new Point(165, 16);
            pbQuitter.Name = "pbQuitter";
            pbQuitter.Size = new Size(45, 45);
            pbQuitter.SizeMode = PictureBoxSizeMode.Zoom;
            pbQuitter.TabIndex = 2;
            pbQuitter.TabStop = false;
            // 
            // pbEnregistrer
            // 
            pbEnregistrer.Location = new Point(389, 16);
            pbEnregistrer.Name = "pbEnregistrer";
            pbEnregistrer.Size = new Size(46, 45);
            pbEnregistrer.SizeMode = PictureBoxSizeMode.Zoom;
            pbEnregistrer.TabIndex = 3;
            pbEnregistrer.TabStop = false;
            // 
            // pbNouveau
            // 
            pbNouveau.Location = new Point(320, 16);
            pbNouveau.Name = "pbNouveau";
            pbNouveau.Size = new Size(42, 45);
            pbNouveau.SizeMode = PictureBoxSizeMode.Zoom;
            pbNouveau.TabIndex = 4;
            pbNouveau.TabStop = false;
            // 
            // pbOuvrir
            // 
            pbOuvrir.Location = new Point(246, 16);
            pbOuvrir.Name = "pbOuvrir";
            pbOuvrir.Size = new Size(41, 45);
            pbOuvrir.SizeMode = PictureBoxSizeMode.Zoom;
            pbOuvrir.TabIndex = 5;
            pbOuvrir.TabStop = false;
            // 
            // rtbTexte
            // 
            rtbTexte.Dock = DockStyle.Fill;
            rtbTexte.Location = new Point(0, 183);
            rtbTexte.Name = "rtbTexte";
            rtbTexte.Size = new Size(800, 267);
            rtbTexte.TabIndex = 6;
            rtbTexte.Text = "";
            // 
            // ofdOuvrir
            // 
            ofdOuvrir.FileName = "openFileDialog1";
            // 
            // EcranEditeur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbTexte);
            Controls.Add(pMenu);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "EcranEditeur";
            Text = "EcranEditeur";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbQuitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnregistrer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNouveau).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOuvrir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem nouveauToolStripMenuItem;
        private ToolStripMenuItem ouvrirToolStripMenuItem;
        private ToolStripMenuItem enregistrerToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem editerToolStripMenuItem;
        private ToolStripMenuItem copierToolStripMenuItem;
        private ToolStripMenuItem couperToolStripMenuItem;
        private ToolStripMenuItem collerToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem justifierToolStripMenuItem;
        private ToolStripMenuItem gaucheToolStripMenuItem;
        private ToolStripMenuItem centreToolStripMenuItem;
        private ToolStripMenuItem droiteToolStripMenuItem;
        private ToolStripMenuItem policeToolStripMenuItem;
        private ToolStripMenuItem caractereToolStripMenuItem;
        private ToolStripMenuItem grasToolStripMenuItem;
        private ToolStripMenuItem italiqueToolStripMenuItem;
        private ToolStripMenuItem souligneToolStripMenuItem;
        private ToolStripMenuItem barreToolStripMenuItem;
        private Panel pMenu;
        private PictureBox pbQuitter;
        private PictureBox pbEnregistrer;
        private PictureBox pbNouveau;
        private PictureBox pbOuvrir;
        private RichTextBox rtbTexte;
        private OpenFileDialog ofdOuvrir;
        private SaveFileDialog sfdEnregistrer;
        private FontDialog fdPolice;
    }
}