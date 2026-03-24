using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgEven2026
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void MethodeNonImplantee(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité non encore implémentée.",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void menuQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuAPropos_Click(object sender, EventArgs e)
        {
            EcranAPropos f = new EcranAPropos();
            f.ShowDialog();
        }

        private void menuListe_Click(object sender, EventArgs e)
        {
            EcranListe f = new EcranListe();
            f.ShowDialog();
        }

        private void menuEditeur_Click(object sender, EventArgs e)
        {
            EcranEditeur f = new EcranEditeur();
            f.ShowDialog();
        }

        private void menuProgression_Click(object sender, EventArgs e)
        {
            EcranProgression f = new EcranProgression();
            f.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void malwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FicMalware f = new FicMalware();
            f.Show();
        }

        private void spirographeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranSpirographe f = new EcranSpirographe();
            f.Show();
        }

        private void clavierSourisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranClavierSouris f = new EcranClavierSouris();
            f.Show();
        }

        private void explorateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranExplorateur f = new EcranExplorateur();
            f.Show();
        }
    }
}
