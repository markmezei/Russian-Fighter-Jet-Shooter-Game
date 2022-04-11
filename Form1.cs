using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FighterJet
{
    public partial class Form1 : Form
    {
        int score = 0;
        int speed = 10;
        int enemySpeed = 3;
        int missileSpeed;
        bool moveLeft, moveRight, shooting;

        public Form1()
        {
            InitializeComponent();
            Timer.Start();
            backgroundSoundPlayer(); 
        }

        private void backgroundSoundPlayer()
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\Mark\Documents\Programozás\Fighter Jet Shooter Game\Resources\soviet march.wav");
            sound.Play();
        }

        private void SoundEffect()
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\Mark\Documents\Programozás\Fighter Jet Shooter Game\Resources\putin.wav");
            sound.Play();
        }
        private void jetIsMoving(object sender, KeyEventArgs key)
        {
            if(key.KeyCode == Keys.A)
            {
                moveLeft = true;
            }
            if(key.KeyCode == Keys.D)
            {
                moveRight = true;
            }

        }

        private void jetIsntMoving(object sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.A)
            {
                moveLeft = false;
            }
            if (key.KeyCode == Keys.D)
            {
                moveRight = false;
            }
            if (key.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;

                missile.Top = jet.Top - 30;
                missile.Left = jet.Left + (jet.Width / 2);

            }
        }
     
        private void gameplay(object sender, EventArgs e)
        {
            Random random = new Random();
            text.Text = score.ToString();
            soviet_jet.Top += enemySpeed;
            russian_jet.Top += enemySpeed;

            if (moveLeft == true && jet.Left > 0)
            {
                jet.Left -= speed;
            }
        
            if(moveRight == true && jet.Left < 900)
            {
                jet.Left += speed;
            }
            

            if(shooting == true)
            {
                missileSpeed = 20;
                missile.Top -= missileSpeed;
            }
            else
            {
                missile.Left = -250;
                missileSpeed = 0;
            }
            if(missile.Top < -30)
            {
                shooting = false;
            }
            if(missile.Bounds.IntersectsWith(soviet_jet.Bounds))
            {
                score++;
                soviet_jet.Top = -450;
                soviet_jet.Left = random.Next(0, 850);
                shooting = false;
            }
            if(missile.Bounds.IntersectsWith(russian_jet.Bounds))
            {
                score++;
                russian_jet.Top = -450;
                russian_jet.Left = random.Next(0, 850);
                shooting = false;
            }
            if (jet.Bounds.IntersectsWith(soviet_jet.Bounds) || jet.Bounds.IntersectsWith(russian_jet.Bounds) || jet.Bounds.IntersectsWith(putin_jet.Bounds))
            {
                GameOver();
            }
            if(score == 5)
            {
                enemySpeed = 5;
                speed = 10;
            }
            if(score == 15)
            {
                enemySpeed = 10; 
                speed = 13;
            }
            if(score >= 20)
            {
                russian_jet.Top = -450;
                soviet_jet.Top = -450;
                speed = 15;
                putin_jet.Top += 2;
                jet.Left = 420;
            }

        }

        private void GameOver()
        {
            Timer.Stop();
            end.Text += "GAME OVER!";
            SoundEffect();

        }
    }
}
