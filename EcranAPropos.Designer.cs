namespace ProgEven2026
{
    partial class EcranAPropos
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
            pCadre = new Panel();
            bConfirmer = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pCadre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pCadre
            // 
            pCadre.Controls.Add(pictureBox1);
            pCadre.Controls.Add(label4);
            pCadre.Controls.Add(label3);
            pCadre.Controls.Add(label2);
            pCadre.Controls.Add(label1);
            pCadre.Location = new Point(26, 33);
            pCadre.Name = "pCadre";
            pCadre.Size = new Size(738, 307);
            pCadre.TabIndex = 0;
            pCadre.MouseEnter += panel1_MouseEnter;
            pCadre.MouseLeave += panel1_MouseLeave;
            // 
            // bConfirmer
            // 
            bConfirmer.Location = new Point(313, 360);
            bConfirmer.Name = "bConfirmer";
            bConfirmer.Size = new Size(156, 56);
            bConfirmer.TabIndex = 1;
            bConfirmer.Text = "Confirmer";
            bConfirmer.UseVisualStyleBackColor = true;
            bConfirmer.Click += button1_Click;
            bConfirmer.MouseEnter += bConfirmer_MouseEnter;
            bConfirmer.MouseLeave += bConfirmer_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(395, 38);
            label1.Name = "label1";
            label1.Size = new Size(324, 38);
            label1.TabIndex = 0;
            label1.Text = "Premieres Manipulations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(395, 110);
            label2.Name = "label2";
            label2.Size = new Size(244, 30);
            label2.TabIndex = 1;
            label2.Text = "Version sous alpha 1.0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(395, 178);
            label3.Name = "label3";
            label3.Size = new Size(216, 32);
            label3.TabIndex = 2;
            label3.Text = "CopyRight NADA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 265);
            label4.Name = "label4";
            label4.Size = new Size(559, 25);
            label4.TabIndex = 3;
            label4.Text = "Et l'application se dit qu'un jour, elle deviendra aussi grande que .NET";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(82, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 153);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // EcranAPropos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bConfirmer);
            Controls.Add(pCadre);
            Name = "EcranAPropos";
            Text = "EcranAPropos";
            pCadre.ResumeLayout(false);
            pCadre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pCadre;
        private Button bConfirmer;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}