namespace ProgEven2026
{
    partial class EcranBDDirect
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
            lbConsole = new ListBox();
            bAjouter = new Button();
            bDenombrer = new Button();
            bConsulter = new Button();
            tbNom = new TextBox();
            tbPrenom = new TextBox();
            lNom = new Label();
            lPrenom = new Label();
            SuspendLayout();
            // 
            // lbConsole
            // 
            lbConsole.FormattingEnabled = true;
            lbConsole.ItemHeight = 25;
            lbConsole.Location = new Point(0, 0);
            lbConsole.Name = "lbConsole";
            lbConsole.Size = new Size(435, 429);
            lbConsole.TabIndex = 0;
            // 
            // bAjouter
            // 
            bAjouter.BackColor = SystemColors.ControlLight;
            bAjouter.Location = new Point(485, 370);
            bAjouter.Name = "bAjouter";
            bAjouter.Size = new Size(173, 34);
            bAjouter.TabIndex = 1;
            bAjouter.Text = "Ajouter";
            bAjouter.UseVisualStyleBackColor = false;
            // 
            // bDenombrer
            // 
            bDenombrer.BackColor = SystemColors.ControlLight;
            bDenombrer.Location = new Point(485, 126);
            bDenombrer.Name = "bDenombrer";
            bDenombrer.Size = new Size(173, 45);
            bDenombrer.TabIndex = 2;
            bDenombrer.Text = "Denombrer";
            bDenombrer.UseVisualStyleBackColor = false;
            // 
            // bConsulter
            // 
            bConsulter.BackColor = SystemColors.ControlLight;
            bConsulter.Location = new Point(485, 36);
            bConsulter.Name = "bConsulter";
            bConsulter.Size = new Size(173, 47);
            bConsulter.TabIndex = 3;
            bConsulter.Text = "Consulter";
            bConsulter.UseVisualStyleBackColor = false;
            bConsulter.Click += bConsulter_Click;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(485, 218);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(173, 31);
            tbNom.TabIndex = 4;
            // 
            // tbPrenom
            // 
            tbPrenom.Location = new Point(485, 298);
            tbPrenom.Name = "tbPrenom";
            tbPrenom.Size = new Size(173, 31);
            tbPrenom.TabIndex = 5;
            // 
            // lNom
            // 
            lNom.AutoSize = true;
            lNom.Location = new Point(485, 190);
            lNom.Name = "lNom";
            lNom.Size = new Size(52, 25);
            lNom.TabIndex = 6;
            lNom.Text = "Nom";
            // 
            // lPrenom
            // 
            lPrenom.AutoSize = true;
            lPrenom.Location = new Point(485, 270);
            lPrenom.Name = "lPrenom";
            lPrenom.Size = new Size(74, 25);
            lPrenom.TabIndex = 7;
            lPrenom.Text = "Prenom";
            // 
            // EcranBDDirect
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 450);
            Controls.Add(lPrenom);
            Controls.Add(lNom);
            Controls.Add(tbPrenom);
            Controls.Add(tbNom);
            Controls.Add(bConsulter);
            Controls.Add(bDenombrer);
            Controls.Add(bAjouter);
            Controls.Add(lbConsole);
            Name = "EcranBDDirect";
            Text = "EcranBDDirect";
            Load += EcranBDDirect_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbConsole;
        private Button bAjouter;
        private Button bDenombrer;
        private Button bConsulter;
        private TextBox tbNom;
        private TextBox tbPrenom;
        private Label lNom;
        private Label lPrenom;
    }
}