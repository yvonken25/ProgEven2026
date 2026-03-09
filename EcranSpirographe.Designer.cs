namespace ProgEven2026
{
    partial class EcranSpirographe
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
            lSommet = new Label();
            lProfondeur = new Label();
            lDensite = new Label();
            gbParametrage = new GroupBox();
            tbSommets = new TrackBar();
            tbDensite = new TrackBar();
            tbProfondeur = new TrackBar();
            bGo = new Button();
            bTrait = new Button();
            bFond = new Button();
            cdCouleur = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)tbSommets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).BeginInit();
            SuspendLayout();
            // 
            // lSommet
            // 
            lSommet.AutoSize = true;
            lSommet.Location = new Point(118, 551);
            lSommet.Name = "lSommet";
            lSommet.Size = new Size(80, 25);
            lSommet.TabIndex = 0;
            lSommet.Text = "Sommet";
            // 
            // lProfondeur
            // 
            lProfondeur.AutoSize = true;
            lProfondeur.Location = new Point(570, 551);
            lProfondeur.Name = "lProfondeur";
            lProfondeur.Size = new Size(102, 25);
            lProfondeur.TabIndex = 1;
            lProfondeur.Text = "Profondeur";
            // 
            // lDensite
            // 
            lDensite.AutoSize = true;
            lDensite.Location = new Point(344, 551);
            lDensite.Name = "lDensite";
            lDensite.Size = new Size(71, 25);
            lDensite.TabIndex = 2;
            lDensite.Text = "Densite";
            // 
            // gbParametrage
            // 
            gbParametrage.Location = new Point(12, 21);
            gbParametrage.Name = "gbParametrage";
            gbParametrage.Size = new Size(300, 236);
            gbParametrage.TabIndex = 3;
            gbParametrage.TabStop = false;
            gbParametrage.Text = "groupBox1";
            // 
            // tbSommets
            // 
            tbSommets.Location = new Point(107, 600);
            tbSommets.Name = "tbSommets";
            tbSommets.Size = new Size(156, 69);
            tbSommets.TabIndex = 4;
            // 
            // tbDensite
            // 
            tbDensite.Location = new Point(332, 600);
            tbDensite.Name = "tbDensite";
            tbDensite.Size = new Size(156, 69);
            tbDensite.TabIndex = 5;
            // 
            // tbProfondeur
            // 
            tbProfondeur.Location = new Point(558, 600);
            tbProfondeur.Name = "tbProfondeur";
            tbProfondeur.Size = new Size(156, 69);
            tbProfondeur.TabIndex = 6;
            // 
            // bGo
            // 
            bGo.Location = new Point(28, 388);
            bGo.Name = "bGo";
            bGo.Size = new Size(112, 34);
            bGo.TabIndex = 7;
            bGo.Text = "Go";
            bGo.UseVisualStyleBackColor = true;
            // 
            // bTrait
            // 
            bTrait.Location = new Point(28, 335);
            bTrait.Name = "bTrait";
            bTrait.Size = new Size(112, 34);
            bTrait.TabIndex = 8;
            bTrait.Text = "Trait";
            bTrait.UseVisualStyleBackColor = true;
            // 
            // bFond
            // 
            bFond.Location = new Point(28, 285);
            bFond.Name = "bFond";
            bFond.Size = new Size(112, 34);
            bFond.TabIndex = 9;
            bFond.Text = "Fond";
            bFond.UseVisualStyleBackColor = true;
            // 
            // EcranSpirographe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 690);
            Controls.Add(bFond);
            Controls.Add(bTrait);
            Controls.Add(bGo);
            Controls.Add(tbProfondeur);
            Controls.Add(tbDensite);
            Controls.Add(tbSommets);
            Controls.Add(gbParametrage);
            Controls.Add(lDensite);
            Controls.Add(lProfondeur);
            Controls.Add(lSommet);
            Name = "EcranSpirographe";
            Text = "Ecran Spirographe";
            ((System.ComponentModel.ISupportInitialize)tbSommets).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lSommet;
        private Label lProfondeur;
        private Label lDensite;
        private GroupBox gbParametrage;
        private TrackBar tbSommets;
        private TrackBar tbDensite;
        private TrackBar tbProfondeur;
        private Button bGo;
        private Button bTrait;
        private Button bFond;
        private ColorDialog cdCouleur;
    }
}