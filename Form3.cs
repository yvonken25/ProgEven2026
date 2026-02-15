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
            MethodeNonImplantee(sender, e);
        }

        private void menuEditeur_Click(object sender, EventArgs e)
        {
            MethodeNonImplantee(sender, e);
        }

        private void menuProgression_Click(object sender, EventArgs e)
        {
            EcranProgression f = new EcranProgression();
            f.ShowDialog();
        }
    }
}
