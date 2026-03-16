namespace ProgEven2026
{
    partial class EcranClavierSouris
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
            tbxClicDroit = new TextBox();
            tbxPositionX = new TextBox();
            tbxPositionY = new TextBox();
            lblPositionY = new Label();
            lblPositionX = new Label();
            lblClavier = new Label();
            lblCLiqueGauche = new Label();
            lblCLiqueDroit = new Label();
            pnlSouris = new Panel();
            tbxClicGauche = new TextBox();
            lsbClavier = new ListBox();
            butRAZ = new Button();
            SuspendLayout();
            // 
            // tbxClicDroit
            // 
            tbxClicDroit.Location = new Point(422, 54);
            tbxClicDroit.Name = "tbxClicDroit";
            tbxClicDroit.Size = new Size(82, 31);
            tbxClicDroit.TabIndex = 16;
            // 
            // tbxPositionX
            // 
            tbxPositionX.Location = new Point(553, 54);
            tbxPositionX.Name = "tbxPositionX";
            tbxPositionX.Size = new Size(82, 31);
            tbxPositionX.TabIndex = 15;
            // 
            // tbxPositionY
            // 
            tbxPositionY.Location = new Point(688, 54);
            tbxPositionY.Name = "tbxPositionY";
            tbxPositionY.Size = new Size(82, 31);
            tbxPositionY.TabIndex = 14;
            // 
            // lblPositionY
            // 
            lblPositionY.AutoSize = true;
            lblPositionY.Location = new Point(688, 26);
            lblPositionY.Name = "lblPositionY";
            lblPositionY.Size = new Size(90, 25);
            lblPositionY.TabIndex = 13;
            lblPositionY.Text = "Position Y";
            // 
            // lblPositionX
            // 
            lblPositionX.AutoSize = true;
            lblPositionX.Location = new Point(544, 26);
            lblPositionX.Name = "lblPositionX";
            lblPositionX.Size = new Size(91, 25);
            lblPositionX.TabIndex = 12;
            lblPositionX.Text = "Position X";
            // 
            // lblClavier
            // 
            lblClavier.AutoSize = true;
            lblClavier.Location = new Point(22, 26);
            lblClavier.Name = "lblClavier";
            lblClavier.Size = new Size(164, 25);
            lblClavier.TabIndex = 8;
            lblClavier.Text = "Interception Clavier";
            // 
            // lblCLiqueGauche
            // 
            lblCLiqueGauche.AutoSize = true;
            lblCLiqueGauche.Location = new Point(279, 26);
            lblCLiqueGauche.Name = "lblCLiqueGauche";
            lblCLiqueGauche.Size = new Size(124, 25);
            lblCLiqueGauche.TabIndex = 9;
            lblCLiqueGauche.Text = "Clique Gauche";
            // 
            // lblCLiqueDroit
            // 
            lblCLiqueDroit.AutoSize = true;
            lblCLiqueDroit.Location = new Point(409, 26);
            lblCLiqueDroit.Name = "lblCLiqueDroit";
            lblCLiqueDroit.Size = new Size(106, 25);
            lblCLiqueDroit.TabIndex = 11;
            lblCLiqueDroit.Text = "Clique Droit";
            // 
            // pnlSouris
            // 
            pnlSouris.BackColor = SystemColors.ControlLight;
            pnlSouris.Location = new Point(292, 105);
            pnlSouris.Name = "pnlSouris";
            pnlSouris.Size = new Size(486, 282);
            pnlSouris.TabIndex = 10;
            pnlSouris.MouseDown += pnlSouris_MouseDown;
            pnlSouris.MouseMove += pnlSouris_MouseMove;
            // 
            // tbxClicGauche
            // 
            tbxClicGauche.Location = new Point(292, 54);
            tbxClicGauche.Name = "tbxClicGauche";
            tbxClicGauche.Size = new Size(82, 31);
            tbxClicGauche.TabIndex = 17;
            // 
            // lsbClavier
            // 
            lsbClavier.FormattingEnabled = true;
            lsbClavier.ItemHeight = 25;
            lsbClavier.Location = new Point(22, 58);
            lsbClavier.Name = "lsbClavier";
            lsbClavier.Size = new Size(235, 329);
            lsbClavier.TabIndex = 18;
            // 
            // butRAZ
            // 
            butRAZ.Location = new Point(67, 404);
            butRAZ.Name = "butRAZ";
            butRAZ.Size = new Size(138, 34);
            butRAZ.TabIndex = 19;
            butRAZ.Text = "Remise a Zero";
            butRAZ.UseVisualStyleBackColor = true;
            butRAZ.Click += butRAZ_Click;
            // 
            // EcranClavierSouris
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butRAZ);
            Controls.Add(lsbClavier);
            Controls.Add(tbxClicGauche);
            Controls.Add(tbxClicDroit);
            Controls.Add(tbxPositionX);
            Controls.Add(tbxPositionY);
            Controls.Add(lblPositionY);
            Controls.Add(lblPositionX);
            Controls.Add(lblClavier);
            Controls.Add(lblCLiqueGauche);
            Controls.Add(lblCLiqueDroit);
            Controls.Add(pnlSouris);
            Name = "EcranClavierSouris";
            Text = "EcranClavierSouris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxClicDroit;
        private TextBox tbxPositionX;
        private TextBox tbxPositionY;
        private Label lblPositionY;
        private Label lblPositionX;
        private Label lblClavier;
        private Label lblCLiqueGauche;
        private Label lblCLiqueDroit;
        private Panel pnlSouris;
        private TextBox tbxClicGauche;
        private ListBox lsbClavier;
        private Button butRAZ;
    }
}