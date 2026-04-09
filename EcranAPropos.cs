using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgEven2026
{
    public partial class EcranAPropos : Form
    {
        public EcranAPropos()
        {
            InitializeComponent();

            pCadre.MouseEnter += Control_MouseEnter;
            pCadre.MouseLeave += Control_MouseLeave;

            bConfirmer.MouseEnter += Control_MouseEnter;
            bConfirmer.MouseLeave += Control_MouseLeave;

            // Action du bouton Confirmer
            bConfirmer.Click += (s, e) => this.Close();
        }
        private Cursor curseurOriginal;
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            curseurOriginal = new Cursor("pointer.cur");
            this.Cursor = Cursors.Hand;
            pCadre.BackColor = Color.LightBlue;
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            
            curseurOriginal = this.Cursor;

         
            if (sender is Button)
            {
                this.Cursor = Cursors.Hand; 
                ((Button)sender).BackColor = Color.LightBlue; 
            }
            else if (sender is Panel)
            {
                this.Cursor = Cursors.Help; 
                ((Panel)sender).BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            // Restauration du curseur d'origine
            this.Cursor = curseurOriginal;

            // Remise à zéro des effets visuels
            if (sender is Button)
            {
                ((Button)sender).BackColor = SystemColors.Control;
            }
            else if (sender is Panel)
            {
                ((Panel)sender).BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            curseurOriginal = this.Cursor;
            pCadre.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bConfirmer_MouseEnter(object sender, EventArgs e)
        {
            curseurOriginal = this.Cursor;
            this.Cursor = Cursors.Cross;
            if (sender is Button)
            {
                this.Cursor = Cursors.Hand; // Curseur "Main" pour le bouton
                ((Button)sender).BackColor = Color.LightBlue; // Effet visuel bonus
            }
            else if (sender is Panel)
            {
                this.Cursor = Cursors.Help; // Curseur "Aide" pour le panel d'info
                ((Panel)sender).BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void bConfirmer_MouseLeave(object sender, EventArgs e)
        {
            curseurOriginal = this.Cursor;

            if (sender is Button)
            {
                ((Button)sender).BackColor = SystemColors.Control;
            }
            else if (sender is Panel)
            {
                ((Panel)sender).BorderStyle = BorderStyle.FixedSingle;
            }


        }
    }
}
