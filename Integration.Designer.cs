namespace ProgEven2026
{
    partial class Integration
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
            lGauche = new Label();
            lDroite = new Label();
            lNbInt = new Label();
            tbGauche = new TextBox();
            tbNbInt = new TextBox();
            tbDroite = new TextBox();
            bPolynome = new Button();
            bTrigonometrique = new Button();
            bPointeurPolynome = new Button();
            bPointeurTrigonometrique = new Button();
            lbResultats = new ListBox();
            SuspendLayout();
            // 
            // lGauche
            // 
            lGauche.AutoSize = true;
            lGauche.Location = new Point(28, 31);
            lGauche.Name = "lGauche";
            lGauche.Size = new Size(70, 25);
            lGauche.TabIndex = 0;
            lGauche.Text = "Gauche";
            // 
            // lDroite
            // 
            lDroite.AutoSize = true;
            lDroite.Location = new Point(218, 31);
            lDroite.Name = "lDroite";
            lDroite.Size = new Size(61, 25);
            lDroite.TabIndex = 1;
            lDroite.Text = "Droite";
            // 
            // lNbInt
            // 
            lNbInt.AutoSize = true;
            lNbInt.Location = new Point(406, 31);
            lNbInt.Name = "lNbInt";
            lNbInt.Size = new Size(120, 25);
            lNbInt.TabIndex = 2;
            lNbInt.Text = "Nb Intervalles";
            // 
            // tbGauche
            // 
            tbGauche.Location = new Point(28, 68);
            tbGauche.Name = "tbGauche";
            tbGauche.Size = new Size(150, 31);
            tbGauche.TabIndex = 3;
            // 
            // tbNbInt
            // 
            tbNbInt.Location = new Point(406, 68);
            tbNbInt.Name = "tbNbInt";
            tbNbInt.Size = new Size(150, 31);
            tbNbInt.TabIndex = 4;
            // 
            // tbDroite
            // 
            tbDroite.Location = new Point(218, 68);
            tbDroite.Name = "tbDroite";
            tbDroite.Size = new Size(150, 31);
            tbDroite.TabIndex = 5;
            // 
            // bPolynome
            // 
            bPolynome.Location = new Point(28, 517);
            bPolynome.Name = "bPolynome";
            bPolynome.Size = new Size(239, 67);
            bPolynome.TabIndex = 6;
            bPolynome.Text = "Polynome : x* x + 2";
            bPolynome.UseVisualStyleBackColor = true;
            bPolynome.Click += bPolynome_Click;
            // 
            // bTrigonometrique
            // 
            bTrigonometrique.Location = new Point(28, 620);
            bTrigonometrique.Name = "bTrigonometrique";
            bTrigonometrique.Size = new Size(239, 67);
            bTrigonometrique.TabIndex = 7;
            bTrigonometrique.Text = "Trigonometrique : sin(x)";
            bTrigonometrique.UseVisualStyleBackColor = true;
            bTrigonometrique.Click += bTrigonometrique_Click;
            // 
            // bPointeurPolynome
            // 
            bPointeurPolynome.Location = new Point(298, 517);
            bPointeurPolynome.Name = "bPointeurPolynome";
            bPointeurPolynome.Size = new Size(239, 67);
            bPointeurPolynome.TabIndex = 8;
            bPointeurPolynome.Text = "Idem pointeur";
            bPointeurPolynome.UseVisualStyleBackColor = true;
            bPointeurPolynome.Click += bPointeurPolynome_Click;
            // 
            // bPointeurTrigonometrique
            // 
            bPointeurTrigonometrique.Location = new Point(298, 620);
            bPointeurTrigonometrique.Name = "bPointeurTrigonometrique";
            bPointeurTrigonometrique.Size = new Size(239, 67);
            bPointeurTrigonometrique.TabIndex = 9;
            bPointeurTrigonometrique.Text = "Idem pointeur trig";
            bPointeurTrigonometrique.UseVisualStyleBackColor = true;
            bPointeurTrigonometrique.Click += bPointeurTrigonometrique_Click;
            // 
            // lbResultats
            // 
            lbResultats.FormattingEnabled = true;
            lbResultats.ItemHeight = 25;
            lbResultats.Location = new Point(28, 119);
            lbResultats.Name = "lbResultats";
            lbResultats.Size = new Size(509, 379);
            lbResultats.TabIndex = 10;
            // 
            // Integration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 751);
            Controls.Add(lbResultats);
            Controls.Add(bPointeurTrigonometrique);
            Controls.Add(bPointeurPolynome);
            Controls.Add(bTrigonometrique);
            Controls.Add(bPolynome);
            Controls.Add(tbDroite);
            Controls.Add(tbNbInt);
            Controls.Add(tbGauche);
            Controls.Add(lNbInt);
            Controls.Add(lDroite);
            Controls.Add(lGauche);
            Name = "Integration";
            Text = "Integration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lGauche;
        private Label lDroite;
        private Label lNbInt;
        private TextBox tbGauche;
        private TextBox tbNbInt;
        private TextBox tbDroite;
        private Button bPolynome;
        private Button bTrigonometrique;
        private Button bPointeurPolynome;
        private Button bPointeurTrigonometrique;
        private ListBox lbResultats;
    }
}