using CIS474_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CIS474_Project
{
    public partial class PassImageCreation : Form
    {
        Random rand = new Random();
        Security hash = new Security();
        SQLStuff sql = new SQLStuff();
        private int xCo;
        private int yCo;
        private int randImage;
        private String username;
        private String email;
        private String password;
        private String imageID;
        int[] priming = { 1, 3, 2, 3, 2, 3, 2, 4, 1, 1, 4, 1, 1, 1, 3, 4, 2, 1, 2, 2, 1, 2, 1, 3, 2 };



        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public PassImageCreation(String passedUsername, String passedEmail, String passedPassword)
        {
            InitializeComponent();
            randImage = rand.Next(1, 25);
            username = passedUsername;
            email = passedEmail;
            password = passedPassword;
            imageID = hash.Sha256(randImage.ToString());

            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + randImage.ToString());

        }

        private void revealButton_Click(object sender, EventArgs e)
        {
            timer.Tick += new System.EventHandler(timerTick);
            timer.Start();
            revealButton.Enabled = false;
        }

        private void timerTick(object sender, EventArgs e)
        {
            int primingType = priming[randImage - 1];
            if (imagePrimer.Width != 0 && imagePrimer.Height != 0)
            {
                switch (primingType)
                {
                    case 1:
                        topCurtain();
                        break;
                   
                    case 2:
                        bottomCurtain();
                        break;
                    
                    case 3:
                        rightCurtain();
                        break;
                    
                    case 4:
                        leftCurtain();
                        break; 
                    
                    default:
                        topCurtain();
                        break;
                }
            }
            else
            {
                imagePrimer.Hide();
                pictureBox1.Enabled = true;
                timer.Stop();

                confirmButton.Show();
                helpText.Text = "Choose a point on the image to use as a passpoint. Make sure to pick somehwere that you'll remember, as you'll need this to log in later.\n\nHit 'Confirm' to create your account.";
            }
        }

        private void leftCurtain()
        {
            timer.Interval = 20;
            imagePrimer.Width--;
            imagePrimer.Left += 1;
        }

        private void rightCurtain()
        {
            timer.Interval = 20;
            imagePrimer.Width--;
        }

        private void bottomCurtain()
        {
            timer.Interval = 50;
            imagePrimer.Height--;
        }

        private void topCurtain()
        {
            timer.Interval = 50;
            imagePrimer.Height--;
            imagePrimer.Top += 1;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int xMargin = xCo - 7;
            int yMargin = yCo - 7;
            e.Graphics.DrawEllipse(new Pen(System.Drawing.Color.Red), new Rectangle(xMargin, yMargin, 14, 14));
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            xCo = e.X;
            yCo = e.Y;

            confirmButton.Enabled = true;

            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
            pictureBox1.Invalidate();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            
            sql.InsertData(username, email, password, imageID, xCo, yCo);
            this.DialogResult = DialogResult.OK;

        }
    }
}
