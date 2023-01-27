using System.Media;

namespace deplacement_balle_picture_Box
{
    public partial class Form1 : Form
    {
        readonly int sensX = 10;
        readonly int sensY = 10;
        readonly int maxX = 785;
        readonly int maxY = 432;
        int deplacementX = -10;
        int deplacementY = 10;
        bool FIN = true;
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

        private bool verif(Point hBal, Point bBal, Point hBar, Point bBar, int sizeBarre, int cote)
        {
            if (cote == 1)
                return ((hBal.X >= hBar.X && hBal.X <= hBar.X + sizeBarre) && ((hBal.Y >= hBar.Y && hBal.Y <= bBar.Y) || (bBal.Y >= hBar.Y && bBal.Y <= bBar.Y)));
            else
                return ((hBal.X <= hBar.X && hBal.X >= hBar.X - sizeBarre) && ((hBal.Y >= hBar.Y && hBal.Y <= bBar.Y) || (bBal.Y >= hBar.Y && bBal.Y <= bBar.Y)));
        }

        private void rebondissement(int balleX, int balleY, int cote)
        {
            int hauteur_Balle = pictureBox1.Size.Height;
            int largeur_Balle = pictureBox1.Size.Width;
            PictureBox raquette;
            if (cote == 1)//droite
                raquette = raquetteDroite;
            else
                raquette = raquetteGauche;
            //
            Point haut_gauche_barre= new Point(raquette.Location.X, raquette.Location.Y);
            Point haut_droite_barre= new Point(raquette.Location.X + raquette.Size.Width, raquette.Location.Y);
            Point bas_gauche_barre = new Point(raquette.Location.X, raquette.Location.Y + raquette.Size.Height);
            Point bas_droite_barre = new Point(raquette.Location.X + raquette.Size.Width, raquette.Location.Y + raquette.Size.Height);
            //
            Point haut_gauche_balle= new Point(balleX, balleY) ;
            Point haut_droite_balle= new Point(balleX + largeur_Balle, balleY);
            Point bas_gauche_balle = new Point(balleX, balleY + hauteur_Balle);
            Point bas_droite_balle = new Point(balleX + largeur_Balle, balleY + hauteur_Balle);
            //
            if (verif(haut_droite_balle, bas_droite_balle, haut_gauche_barre, bas_gauche_barre, raquette.Size.Width, cote))
            {
                deplacementX *= -1;
                SoundPlayer player = new SoundPlayer(deplacement_balle_picture_Box.Properties.Resources.drip_goku);
                player.Play();
            }
            else if (verif(haut_gauche_balle, bas_gauche_balle, haut_droite_barre, bas_droite_barre, raquette.Size.Width, cote))
            {
                deplacementX *= -1;
                SoundPlayer player = new SoundPlayer(deplacement_balle_picture_Box.Properties.Resources.bounce_song);
                player.Play();
            }
        }

        private int end_Game()
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (x > 757)
                return 1;
            if (x <= 14)
                return 2;
            return 0; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            rebondissement(x, y, 1);
            rebondissement(x, y, 2);
            //////////////////////////
            if (FIN == false)
                return;
            //////////////////////////
            SoundPlayer player = new SoundPlayer(deplacement_balle_picture_Box.Properties.Resources.bounce_song2);
            if (x < 0)
            {
                pictureBox1.Location = new Point(0, y);
                deplacementX = deplacementX * -1;
                player.Play();
            }
            if (y < 0)
            {
                pictureBox1.Location = new Point(x, 0);
                deplacementY = deplacementY * -1;
                player.Play();
            }
            if (x > groupBox1.Size.Width - pictureBox1.Size.Width)
            {
                x = maxX - pictureBox1.Size.Width;
                deplacementX = deplacementX * -1;
                player.Play();

            }
            if (y > groupBox1.Size.Height - pictureBox1.Size.Height)
            {
                y = maxY - pictureBox1.Size.Height;
                deplacementY = deplacementY * -1;
                player.Play();
            }
            pictureBox1.Location = new Point(x + deplacementX, y + deplacementY);
            ///////////////
            x = raquetteDroite.Location.X;
            y = raquetteDroite.Location.Y;

            if (y < 0)
                raquetteDroite.Location = new Point(x, 0);
            else if (y > 280)
                raquetteDroite.Location = new Point(x, 280);
            ///////////////
            x = raquetteGauche.Location.X;
            y = raquetteGauche.Location.Y;

            if (y < 0)
                raquetteGauche.Location = new Point(x, 0);
            else if (y > 280)
                raquetteGauche.Location = new Point(x, 280);
            /////////////////////:
            if (end_Game() != 0)
            {
                FIN = false;
                player = new SoundPlayer(deplacement_balle_picture_Box.Properties.Resources.loos_song);
                player.Play();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)//si on appuye sur fleche du bas
            { 
                int x = raquetteDroite.Location.X;
                int y = raquetteDroite.Location.Y;

                if (y >= 0)
                    raquetteDroite.Location = new Point(x, y + sensY);
            }
            else if (e.KeyCode == Keys.Up)//si on appuye sur fleche du haut
            {
                int x = raquetteDroite.Location.X;
                int y = raquetteDroite.Location.Y;

                if (y <= 280)
                    raquetteDroite.Location = new Point(x, y - sensY);
            }
            if (e.KeyCode == Keys.W)//si on appuye sur w
            {
                int x = raquetteGauche.Location.X;
                int y = raquetteGauche.Location.Y;

                if (y >= 0)
                    raquetteGauche.Location = new Point(x, y + sensY);
            }
            else if (e.KeyCode == Keys.Q)//si on appuye sur Q
            {
                int x = raquetteGauche.Location.X;
                int y = raquetteGauche.Location.Y;

                if (y <= 280)
                     raquetteGauche.Location = new Point(x, y - sensY);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}