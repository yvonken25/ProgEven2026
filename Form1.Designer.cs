namespace ProgEven2026
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bOpen = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            bPermut = new Button();
            bPrincipal = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bOpen
            // 
            bOpen.BackgroundImageLayout = ImageLayout.Zoom;
            bOpen.Location = new Point(451, 294);
            bOpen.Name = "bOpen";
            bOpen.Size = new Size(185, 61);
            bOpen.TabIndex = 7;
            bOpen.Text = "Ouvrir la deuxieme fenetre";
            bOpen.UseVisualStyleBackColor = true;
            bOpen.Click += bOpen_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = Properties.Resources.flip;
            pictureBox2.Location = new Point(199, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(199, 169);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.téléchargement;
            pictureBox1.Location = new Point(451, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 169);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // bPermut
            // 
            bPermut.BackgroundImageLayout = ImageLayout.Zoom;
            bPermut.Location = new Point(220, 294);
            bPermut.Name = "bPermut";
            bPermut.Size = new Size(138, 61);
            bPermut.TabIndex = 4;
            bPermut.Text = "Permuter les Images";
            bPermut.UseVisualStyleBackColor = true;
            bPermut.Click += bPermut_Click;
            // 
            // bPrincipal
            // 
            bPrincipal.Location = new Point(314, 385);
            bPrincipal.Name = "bPrincipal";
            bPrincipal.Size = new Size(222, 34);
            bPrincipal.TabIndex = 8;
            bPrincipal.Text = "Ouvrir fenetre principale";
            bPrincipal.UseVisualStyleBackColor = true;
            bPrincipal.Click += bPrincipal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bPrincipal);
            Controls.Add(bOpen);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(bPermut);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bOpen;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button bPermut;
        private Button bPrincipal;
    }
}
