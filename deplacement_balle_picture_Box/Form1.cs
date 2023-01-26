namespace deplacement_balle_picture_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;

            int y;

            x = pictureBox1.Location.X;//Permet de recuper la corrdonée X de PictureBox1
            y = pictureBox1.Location.Y;//pareil mais pour y

            pictureBox1.Location = new Point(x, y - 10);
            pictureBox1.Image = deplacement_balle_picture_Box.Properties.Resources.ball_blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x;

            int y;

            x = pictureBox1.Location.X;//Permet de recuper la corrdonée X de PictureBox1
            y = pictureBox1.Location.Y;//pareil mais pour y

            pictureBox1.Location = new Point(x + 10, y);
            pictureBox1.Image = deplacement_balle_picture_Box.Properties.Resources.ball_yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x;

            int y;

            x = pictureBox1.Location.X;//Permet de recuper la corrdonée X de PictureBox1
            y = pictureBox1.Location.Y;//pareil mais pour y

            pictureBox1.Location = new Point(x - 10, y);
            pictureBox1.Image = deplacement_balle_picture_Box.Properties.Resources.ball_green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x;

            int y;

            x = pictureBox1.Location.X;//Permet de recuper la corrdonée X de PictureBox1
            y = pictureBox1.Location.Y;//pareil mais pour y

            pictureBox1.Location = new Point(x, y + 10);
            pictureBox1.Image = deplacement_balle_picture_Box.Properties.Resources.ball_magenta;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = deplacement_balle_picture_Box.Properties.Resources.ball_red_blur;
        }
    }
}