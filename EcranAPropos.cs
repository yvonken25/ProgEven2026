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
        }
        private Cursor curseurOriginal;
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            curseurOriginal = new Cursor("pointer.cur");
            this.Cursor = Cursors.Hand;
            panel1.BackColor = Color.LightBlue;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            curseurOriginal = this.Cursor;
            panel1.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            curseurOriginal = this.Cursor;
            this.Cursor = Cursors.Cross;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            curseurOriginal = this.Cursor;
        }
    }
}
