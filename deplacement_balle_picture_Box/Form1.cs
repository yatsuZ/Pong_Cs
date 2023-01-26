namespace deplacement_balle_picture_Box
{
    public partial class Form1 : Form
    {
        readonly int sensX = 10;
        readonly int sensY = 10;
        readonly int maxX = 785;
        readonly int maxY = 288;
        int deplacementX = 10;
        int deplacementY = 10;
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

            pictureBox1.Location = new Point(x, y - sensY);
            pictureBox1.Image = deplacement_balle_picture_Box.Properties.Resources.ball_blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x;

            int y;

            x = pictureBox1.Location.X;//Permet de recuper la corrdonée X de PictureBox1
            y = pictureBox1.Location.Y;//pareil mais pour y

            pictureBox1.Location = new Point(x + sensX, y);
            pictureBox1.Image = deplacement_balle_picture_Box.Properties.Resources.ball_yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x;

            int y;

            x = pictureBox1.Location.X;//Permet de recuper la corrdonée X de PictureBox1
            y = pictureBox1.Location.Y;//pareil mais pour y

            pictureBox1.Location = new Point(x - sensX, y);
            pictureBox1.Image = deplacement_balle_picture_Box.Properties.Resources.ball_green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x;

            int y;

            x = pictureBox1.Location.X;//Permet de recuper la corrdonée X de PictureBox1
            y = pictureBox1.Location.Y;//pareil mais pour y

            pictureBox1.Location = new Point(x, y + sensY);
            pictureBox1.Image = deplacement_balle_picture_Box.Properties.Resources.ball_magenta;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = deplacement_balle_picture_Box.Properties.Resources.ball_red_blur;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            if (x < 0)
            {
                pictureBox1.Location = new Point(0, y);
                deplacementX = deplacementX * -1;
            }
            if (y < 0)
            {
                pictureBox1.Location = new Point(x, 0);
                deplacementY = deplacementY * -1;
            }
            if (x > groupBox1.Size.Width - pictureBox1.Size.Width)
            {
                x = maxX - pictureBox1.Size.Width;
                deplacementX = deplacementX * -1;
            }
            if (y > groupBox1.Size.Height - pictureBox1.Size.Height)
            {
                y = maxY - pictureBox1.Size.Height;
                deplacementY = deplacementY * -1;
            }
            pictureBox1.Location = new Point(x + deplacementX, y + deplacementY);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}