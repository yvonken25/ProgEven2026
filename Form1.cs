namespace ProgEven2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bPermut_Click(object sender, EventArgs e)
        {
            Image tempImage = pictureBox1.Image;


            pictureBox1.Image = pictureBox2.Image;


            pictureBox2.Image = tempImage;
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            Form2 secondeFenetre = new Form2();


            secondeFenetre.Show();

            this.Hide();
        }

        private void bPrincipal_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();

        }
    }
}
