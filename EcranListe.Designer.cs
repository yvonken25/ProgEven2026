namespace ProgEven2026
{
    partial class EcranListe
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
            bOuvrir = new Button();
            bEnregistrer = new Button();
            bAjouter = new Button();
            bSupprimer = new Button();
            bConfirmer = new Button();
            bAnnuler = new Button();
            gbDetail = new GroupBox();
            lNom = new Label();
            lQualite = new Label();
            cbQualite = new ComboBox();
            tbNom = new TextBox();
            lbPersonne = new ListBox();
            lFichier = new Label();
            ofdOuvrirFichier = new OpenFileDialog();
            sfdEnregistrer = new SaveFileDialog();
            gbDetail.SuspendLayout();
            SuspendLayout();
            // 
            // bOuvrir
            // 
            bOuvrir.Location = new Point(46, 228);
            bOuvrir.Name = "bOuvrir";
            bOuvrir.Size = new Size(112, 34);
            bOuvrir.TabIndex = 0;
            bOuvrir.Text = "Ouvrir";
            bOuvrir.UseVisualStyleBackColor = true;
            bOuvrir.Click += bOuvrir_Click;
            // 
            // bEnregistrer
            // 
            bEnregistrer.Location = new Point(46, 268);
            bEnregistrer.Name = "bEnregistrer";
            bEnregistrer.Size = new Size(112, 34);
            bEnregistrer.TabIndex = 1;
            bEnregistrer.Text = "Enregistrer";
            bEnregistrer.UseVisualStyleBackColor = true;
            bEnregistrer.Click += bEnregistrer_Click;
            // 
            // bAjouter
            // 
            bAjouter.Location = new Point(46, 346);
            bAjouter.Name = "bAjouter";
            bAjouter.Size = new Size(112, 34);
            bAjouter.TabIndex = 2;
            bAjouter.Text = "Ajouter";
            bAjouter.UseVisualStyleBackColor = true;
            bAjouter.Click += bAjouter_Click;
            // 
            // bSupprimer
            // 
            bSupprimer.Location = new Point(46, 386);
            bSupprimer.Name = "bSupprimer";
            bSupprimer.Size = new Size(112, 34);
            bSupprimer.TabIndex = 3;
            bSupprimer.Text = "Supprimer";
            bSupprimer.UseVisualStyleBackColor = true;
            bSupprimer.Click += bSupprimer_Click;
            // 
            // bConfirmer
            // 
            bConfirmer.Location = new Point(21, 176);
            bConfirmer.Name = "bConfirmer";
            bConfirmer.Size = new Size(112, 34);
            bConfirmer.TabIndex = 4;
            bConfirmer.Text = "Confirmer";
            bConfirmer.UseVisualStyleBackColor = true;
            bConfirmer.Click += bConfirmer_Click;
            // 
            // bAnnuler
            // 
            bAnnuler.Location = new Point(168, 176);
            bAnnuler.Name = "bAnnuler";
            bAnnuler.Size = new Size(112, 34);
            bAnnuler.TabIndex = 5;
            bAnnuler.Text = "Annuler";
            bAnnuler.UseVisualStyleBackColor = true;
            bAnnuler.Click += bAnnuler_Click;
            // 
            // gbDetail
            // 
            gbDetail.Controls.Add(lNom);
            gbDetail.Controls.Add(lQualite);
            gbDetail.Controls.Add(cbQualite);
            gbDetail.Controls.Add(tbNom);
            gbDetail.Controls.Add(bAnnuler);
            gbDetail.Controls.Add(bConfirmer);
            gbDetail.Location = new Point(381, 210);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(300, 228);
            gbDetail.TabIndex = 6;
            gbDetail.TabStop = false;
            gbDetail.Text = "Details";
            // 
            // lNom
            // 
            lNom.AutoSize = true;
            lNom.Location = new Point(21, 107);
            lNom.Name = "lNom";
            lNom.Size = new Size(52, 25);
            lNom.TabIndex = 10;
            lNom.Text = "Nom";
            // 
            // lQualite
            // 
            lQualite.AutoSize = true;
            lQualite.Location = new Point(21, 36);
            lQualite.Name = "lQualite";
            lQualite.Size = new Size(68, 25);
            lQualite.TabIndex = 9;
            lQualite.Text = "Qualite";
            // 
            // cbQualite
            // 
            cbQualite.FormattingEnabled = true;
            cbQualite.Location = new Point(21, 71);
            cbQualite.Name = "cbQualite";
            cbQualite.Size = new Size(259, 33);
            cbQualite.TabIndex = 7;
            cbQualite.SelectedIndexChanged += cbQualite_SelectedIndexChanged;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(21, 138);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(259, 31);
            tbNom.TabIndex = 6;
            // 
            // lbPersonne
            // 
            lbPersonne.FormattingEnabled = true;
            lbPersonne.ItemHeight = 25;
            lbPersonne.Location = new Point(89, 40);
            lbPersonne.Name = "lbPersonne";
            lbPersonne.Size = new Size(554, 129);
            lbPersonne.TabIndex = 7;
            // 
            // lFichier
            // 
            lFichier.AutoSize = true;
            lFichier.Location = new Point(89, 9);
            lFichier.Name = "lFichier";
            lFichier.Size = new Size(132, 25);
            lFichier.TabIndex = 8;
            lFichier.Text = "Nom de Fichier";
            // 
            // ofdOuvrirFichier
            // 
            ofdOuvrirFichier.FileName = "openFileDialog1";
            // 
            // EcranListe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lFichier);
            Controls.Add(lbPersonne);
            Controls.Add(gbDetail);
            Controls.Add(bSupprimer);
            Controls.Add(bAjouter);
            Controls.Add(bEnregistrer);
            Controls.Add(bOuvrir);
            Name = "EcranListe";
            Text = "EcranListe";
            Load += EcranListe_Load;
            gbDetail.ResumeLayout(false);
            gbDetail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bOuvrir;
        private Button bEnregistrer;
        private Button bAjouter;
        private Button bSupprimer;
        private Button bConfirmer;
        private Button bAnnuler;
        private GroupBox gbDetail;
        private Label lNom;
        private Label lQualite;
        private ComboBox cbQualite;
        private TextBox tbNom;
        private ListBox lbPersonne;
        private Label lFichier;
        private OpenFileDialog ofdOuvrirFichier;
        private SaveFileDialog sfdEnregistrer;
    }
}