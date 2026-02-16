namespace ProgEven2026
{
    partial class EcranProgression
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
            pbPrincipal = new ProgressBar();
            pbSecondaire = new ProgressBar();
            bQuitter = new Button();
            lPrincipal = new Label();
            lSecondaire = new Label();
            bExecuter = new Button();
            SuspendLayout();
            // 
            // pbPrincipal
            // 
            pbPrincipal.Location = new Point(174, 154);
            pbPrincipal.Name = "pbPrincipal";
            pbPrincipal.Size = new Size(387, 34);
            pbPrincipal.TabIndex = 0;
            // 
            // pbSecondaire
            // 
            pbSecondaire.Location = new Point(174, 278);
            pbSecondaire.Name = "pbSecondaire";
            pbSecondaire.Size = new Size(387, 34);
            pbSecondaire.TabIndex = 1;
            // 
            // bQuitter
            // 
            bQuitter.Location = new Point(297, 388);
            bQuitter.Name = "bQuitter";
            bQuitter.Size = new Size(154, 34);
            bQuitter.TabIndex = 2;
            bQuitter.Text = "Quitter ";
            bQuitter.UseVisualStyleBackColor = true;
            bQuitter.Click += bQuitter_Click;
            // 
            // lPrincipal
            // 
            lPrincipal.AutoSize = true;
            lPrincipal.Location = new Point(176, 100);
            lPrincipal.Name = "lPrincipal";
            lPrincipal.Size = new Size(127, 25);
            lPrincipal.TabIndex = 3;
            lPrincipal.Text = "Index principal";
            // 
            // lSecondaire
            // 
            lSecondaire.AutoSize = true;
            lSecondaire.Location = new Point(176, 240);
            lSecondaire.Name = "lSecondaire";
            lSecondaire.Size = new Size(145, 25);
            lSecondaire.TabIndex = 4;
            lSecondaire.Text = "Index secondaire";
            // 
            // bExecuter
            // 
            bExecuter.Location = new Point(297, 335);
            bExecuter.Name = "bExecuter";
            bExecuter.Size = new Size(154, 34);
            bExecuter.TabIndex = 5;
            bExecuter.Text = "Executer";
            bExecuter.UseVisualStyleBackColor = true;
            bExecuter.Click += bExecuter_Click;
            // 
            // EcranProgression
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bExecuter);
            Controls.Add(lSecondaire);
            Controls.Add(lPrincipal);
            Controls.Add(bQuitter);
            Controls.Add(pbSecondaire);
            Controls.Add(pbPrincipal);
            Name = "EcranProgression";
            Text = "EcranProgression";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pbPrincipal;
        private ProgressBar pbSecondaire;
        private Button bQuitter;
        private Label lPrincipal;
        private Label lSecondaire;
        private Button bExecuter;
    }
}