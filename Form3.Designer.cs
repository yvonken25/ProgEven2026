namespace ProgEven2026
{
    partial class Form3
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
            controlesToolStripMenuItem = new ToolStripMenuItem();
            menuListe = new ToolStripMenuItem();
            menuProgression = new ToolStripMenuItem();
            menuQuitter = new ToolStripMenuItem();
            applicationsToolStripMenuItem = new ToolStripMenuItem();
            menuEditeur = new ToolStripMenuItem();
            aideToolStripMenuItem = new ToolStripMenuItem();
            menuAPropos = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { controlesToolStripMenuItem, applicationsToolStripMenuItem, aideToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // controlesToolStripMenuItem
            // 
            controlesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuListe, menuProgression, menuQuitter });
            controlesToolStripMenuItem.Name = "controlesToolStripMenuItem";
            controlesToolStripMenuItem.Size = new Size(104, 29);
            controlesToolStripMenuItem.Text = "Controles";
            // 
            // menuListe
            // 
            menuListe.Name = "menuListe";
            menuListe.Size = new Size(279, 34);
            menuListe.Text = "Liste ";
            menuListe.Click += menuListe_Click;
            // 
            // menuProgression
            // 
            menuProgression.Name = "menuProgression";
            menuProgression.Size = new Size(279, 34);
            menuProgression.Text = "Barre de progression";
            menuProgression.Click += menuProgression_Click;
            // 
            // menuQuitter
            // 
            menuQuitter.Name = "menuQuitter";
            menuQuitter.Size = new Size(279, 34);
            menuQuitter.Text = "Quitter";
            menuQuitter.Click += menuQuitter_Click;
            // 
            // applicationsToolStripMenuItem
            // 
            applicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuEditeur });
            applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            applicationsToolStripMenuItem.Size = new Size(131, 29);
            applicationsToolStripMenuItem.Text = "Applications ";
            // 
            // menuEditeur
            // 
            menuEditeur.Name = "menuEditeur";
            menuEditeur.Size = new Size(270, 34);
            menuEditeur.Text = "Editeur";
            menuEditeur.Click += menuEditeur_Click;
            // 
            // aideToolStripMenuItem
            // 
            aideToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuAPropos });
            aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            aideToolStripMenuItem.Size = new Size(64, 29);
            aideToolStripMenuItem.Text = "Aide";
            // 
            // menuAPropos
            // 
            menuAPropos.Name = "menuAPropos";
            menuAPropos.Size = new Size(189, 34);
            menuAPropos.Text = "A propos";
            menuAPropos.Click += menuAPropos_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            Text = "Form3";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem controlesToolStripMenuItem;
        private ToolStripMenuItem menuListe;
        private ToolStripMenuItem menuProgression;
        private ToolStripMenuItem menuQuitter;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem menuEditeur;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem menuAPropos;
    }
}