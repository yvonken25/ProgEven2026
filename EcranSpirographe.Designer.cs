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
            components = new System.ComponentModel.Container();
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
            timerHorloge = new System.Windows.Forms.Timer(components);
            gbParametrage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbSommets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).BeginInit();
            SuspendLayout();
            // 
            // lSommet
            // 
            lSommet.AutoSize = true;
            lSommet.Location = new Point(27, 84);
            lSommet.Name = "lSommet";
            lSommet.Size = new Size(80, 25);
            lSommet.TabIndex = 0;
            lSommet.Text = "Sommet";
            // 
            // lProfondeur
            // 
            lProfondeur.AutoSize = true;
            lProfondeur.Location = new Point(17, 333);
            lProfondeur.Name = "lProfondeur";
            lProfondeur.Size = new Size(102, 25);
            lProfondeur.TabIndex = 1;
            lProfondeur.Text = "Profondeur";
            // 
            // lDensite
            // 
            lDensite.AutoSize = true;
            lDensite.Location = new Point(17, 201);
            lDensite.Name = "lDensite";
            lDensite.Size = new Size(71, 25);
            lDensite.TabIndex = 2;
            lDensite.Text = "Densite";
            // 
            // gbParametrage
            // 
            gbParametrage.Controls.Add(tbSommets);
            gbParametrage.Controls.Add(lSommet);
            gbParametrage.Controls.Add(lProfondeur);
            gbParametrage.Controls.Add(tbProfondeur);
            gbParametrage.Controls.Add(lDensite);
            gbParametrage.Controls.Add(tbDensite);
            gbParametrage.Location = new Point(12, 21);
            gbParametrage.Name = "gbParametrage";
            gbParametrage.Size = new Size(206, 419);
            gbParametrage.TabIndex = 3;
            gbParametrage.TabStop = false;
            gbParametrage.Text = "groupBox1";
            // 
            // tbSommets
            // 
            tbSommets.Location = new Point(6, 129);
            tbSommets.Name = "tbSommets";
            tbSommets.Size = new Size(156, 69);
            tbSommets.TabIndex = 4;
            // 
            // tbDensite
            // 
            tbDensite.Location = new Point(6, 229);
            tbDensite.Name = "tbDensite";
            tbDensite.Size = new Size(156, 69);
            tbDensite.TabIndex = 5;
            // 
            // tbProfondeur
            // 
            tbProfondeur.Location = new Point(6, 361);
            tbProfondeur.Name = "tbProfondeur";
            tbProfondeur.Size = new Size(156, 69);
            tbProfondeur.TabIndex = 6;
            // 
            // bGo
            // 
            bGo.Location = new Point(62, 594);
            bGo.Name = "bGo";
            bGo.Size = new Size(112, 34);
            bGo.TabIndex = 7;
            bGo.Text = "Go";
            bGo.UseVisualStyleBackColor = true;
            bGo.Click += bGo_Click;
            // 
            // bTrait
            // 
            bTrait.Location = new Point(62, 532);
            bTrait.Name = "bTrait";
            bTrait.Size = new Size(112, 34);
            bTrait.TabIndex = 8;
            bTrait.Text = "Trait";
            bTrait.UseVisualStyleBackColor = true;
            bTrait.Click += bTrait_Click;
            // 
            // bFond
            // 
            bFond.Location = new Point(62, 468);
            bFond.Name = "bFond";
            bFond.Size = new Size(112, 34);
            bFond.TabIndex = 9;
            bFond.Text = "Fond";
            bFond.UseVisualStyleBackColor = true;
            bFond.Click += bFond_Click;
            // 
            // timerHorloge
            // 
            timerHorloge.Tick += timerHorloge_Tick;
            // 
            // EcranSpirographe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 690);
            Controls.Add(bFond);
            Controls.Add(bTrait);
            Controls.Add(bGo);
            Controls.Add(gbParametrage);
            DoubleBuffered = true;
            Name = "EcranSpirographe";
            Text = "Ecran Spirographe";
            Load += EcranSpirographe_Load;
            gbParametrage.ResumeLayout(false);
            gbParametrage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbSommets).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).EndInit();
            ResumeLayout(false);
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
        private System.Windows.Forms.Timer timerHorloge;
    }
}