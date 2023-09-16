namespace CIS474_Project
{
    partial class PassImageCreation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassImageCreation));
            this.revealButton = new System.Windows.Forms.Button();
            this.helpText = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.imagePrimer = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imagePrimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // revealButton
            // 
            this.revealButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.revealButton.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revealButton.Location = new System.Drawing.Point(735, 151);
            this.revealButton.Name = "revealButton";
            this.revealButton.Size = new System.Drawing.Size(137, 35);
            this.revealButton.TabIndex = 3;
            this.revealButton.Text = "Reveal Image";
            this.revealButton.UseVisualStyleBackColor = true;
            this.revealButton.Click += new System.EventHandler(this.revealButton_Click);
            // 
            // helpText
            // 
            this.helpText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpText.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.helpText.Location = new System.Drawing.Point(732, 199);
            this.helpText.Name = "helpText";
            this.helpText.Size = new System.Drawing.Size(157, 160);
            this.helpText.TabIndex = 4;
            this.helpText.Text = "Click the button above to reveal your passimage.";
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmButton.Enabled = false;
            this.confirmButton.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.confirmButton.Location = new System.Drawing.Point(735, 374);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(137, 33);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Visible = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // imagePrimer
            // 
            this.imagePrimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imagePrimer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imagePrimer.Location = new System.Drawing.Point(33, 91);
            this.imagePrimer.Name = "imagePrimer";
            this.imagePrimer.Size = new System.Drawing.Size(640, 360);
            this.imagePrimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePrimer.TabIndex = 1;
            this.imagePrimer.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(33, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.confirmButton);
            this.panel1.Controls.Add(this.imagePrimer);
            this.panel1.Controls.Add(this.helpText);
            this.panel1.Controls.Add(this.revealButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(67, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 517);
            this.panel1.TabIndex = 6;
            // 
            // PassImageCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 655);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "PassImageCreation";
            this.Text = "Create New Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.imagePrimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imagePrimer;
        private System.Windows.Forms.Button revealButton;
        private System.Windows.Forms.Label helpText;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Panel panel1;
    }
}