using System;
using System.Drawing;
using System.Windows.Forms;

namespace CIS474_Project
{
    public partial class PassPoint : Form
    {
        SQLStuff sql = new SQLStuff();
        Security hash = new Security();
        private String passedEmail;
        private String passedImage;
        private int xCo;
        private int yCo;
        public PassPoint(String email, String imageID)
        {
            InitializeComponent();
            passedEmail = email;
            passedImage = hash.Sha256(imageID);
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + imageID);
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

            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
            pictureBox1.Invalidate();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool verify = sql.CheckPassImage(passedImage, passedEmail);
            int storedX = sql.GetXPoint(passedEmail);
            int storedY = sql.GetYPoint(passedEmail);

            Point selected = new Point(xCo, yCo);
            Point stored = new Point(storedX, storedY);
            if (PointCompare(selected, stored) && verify == true)
            {
               MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK);
               this.DialogResult = DialogResult.OK;
            }
            else
            {
                warningText.Show();
            }
        }

        bool PointCompare(Point selected, Point actual)
        {
            int x1 = Convert.ToInt32(selected.X);
            int x2 = Convert.ToInt32(actual.X);
            int y1 = Convert.ToInt32(selected.Y);
            int y2 = Convert.ToInt32(actual.Y);
            int dx = x1 - x2;
            int dy = y1 - y2;

            return (dx * dx + dy * dy) < 7 * 7;
        }
    }
}
