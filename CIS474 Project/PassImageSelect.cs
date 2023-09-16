using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CIS474_Project
{
    public partial class PassImageSelect : Form
    {
        Random rand = new Random();
        private String passedEmail;
        List<String> imageID = new List<String>();
        public PassImageSelect(String email)
        {
            InitializeComponent();

            passedEmail = email;
            int startingSize = 24;

            List<Button> buttons = new List<Button>
            {
                button1,  button2,  button3,  button4,  button5,
                button6,  button7,  button8,  button9,  button10,
                button11, button12, button13, button14, button15,
                button16, button17, button18, button19, button20,
                button21, button22, button23, button24, button25
            };
            List<int> passImages = new List<int>
            { 
                 1,  2,  3,  4,  5,
                 6,  7,  8,  9, 10,
                11, 12, 13, 14, 15,
                16, 17, 18, 19, 20,
                21, 22, 23, 24, 25
            };

            foreach (Button button in buttons)
            { 
                int randIndex = rand.Next(0, startingSize);
                button.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + passImages[randIndex].ToString());
                imageID.Add(passImages[randIndex].ToString());
                passImages.RemoveAt(randIndex);
                startingSize--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[0]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[1]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[2]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[3]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[4]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[5]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[6]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[7]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[8]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[9]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[10]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[11]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[12]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[13]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[14]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[15]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[16]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[17]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[18]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[19]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[20]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[21]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[22]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[23]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            PassPoint passPoint = new PassPoint(passedEmail, imageID[24]);
            this.Hide();
            DialogResult result = passPoint.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                passPoint.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        
    }
}
