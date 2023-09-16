namespace CIS474_Project
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.newUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.passWarningText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newEmail = new System.Windows.Forms.TextBox();
            this.usernameWarningText = new System.Windows.Forms.Label();
            this.emailWarningText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newUsername
            // 
            this.newUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newUsername.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.newUsername.Location = new System.Drawing.Point(314, 116);
            this.newUsername.Name = "newUsername";
            this.newUsername.Size = new System.Drawing.Size(213, 22);
            this.newUsername.TabIndex = 0;
            this.newUsername.Leave += new System.EventHandler(this.newUsername_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Username:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Create Password:";
            // 
            // newPassword
            // 
            this.newPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPassword.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.newPassword.Location = new System.Drawing.Point(314, 209);
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '*';
            this.newPassword.Size = new System.Drawing.Size(213, 22);
            this.newPassword.TabIndex = 2;
            // 
            // continueButton
            // 
            this.continueButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.continueButton.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(357, 310);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(117, 29);
            this.continueButton.TabIndex = 4;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.label3.Location = new System.Drawing.Point(13, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password:";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPassword.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.confirmPassword.Location = new System.Drawing.Point(314, 258);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '*';
            this.confirmPassword.Size = new System.Drawing.Size(213, 22);
            this.confirmPassword.TabIndex = 3;
            // 
            // passWarningText
            // 
            this.passWarningText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passWarningText.AutoSize = true;
            this.passWarningText.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.passWarningText.ForeColor = System.Drawing.Color.Red;
            this.passWarningText.Location = new System.Drawing.Point(410, 133);
            this.passWarningText.MaximumSize = new System.Drawing.Size(140, 0);
            this.passWarningText.Name = "passWarningText";
            this.passWarningText.Size = new System.Drawing.Size(136, 14);
            this.passWarningText.TabIndex = 7;
            this.passWarningText.Text = "[warning text goes here]";
            this.passWarningText.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.label4.Location = new System.Drawing.Point(13, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Email:";
            // 
            // newEmail
            // 
            this.newEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newEmail.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.newEmail.Location = new System.Drawing.Point(314, 164);
            this.newEmail.Name = "newEmail";
            this.newEmail.Size = new System.Drawing.Size(213, 22);
            this.newEmail.TabIndex = 1;
            this.newEmail.Leave += new System.EventHandler(this.newEmail_Leave);
            // 
            // usernameWarningText
            // 
            this.usernameWarningText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usernameWarningText.AutoSize = true;
            this.usernameWarningText.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.usernameWarningText.ForeColor = System.Drawing.Color.Red;
            this.usernameWarningText.Location = new System.Drawing.Point(410, 40);
            this.usernameWarningText.MaximumSize = new System.Drawing.Size(140, 0);
            this.usernameWarningText.Name = "usernameWarningText";
            this.usernameWarningText.Size = new System.Drawing.Size(136, 14);
            this.usernameWarningText.TabIndex = 10;
            this.usernameWarningText.Text = "Username already exists";
            this.usernameWarningText.Visible = false;
            // 
            // emailWarningText
            // 
            this.emailWarningText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailWarningText.AutoSize = true;
            this.emailWarningText.BackColor = System.Drawing.Color.Honeydew;
            this.emailWarningText.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.emailWarningText.ForeColor = System.Drawing.Color.Red;
            this.emailWarningText.Location = new System.Drawing.Point(410, 88);
            this.emailWarningText.MaximumSize = new System.Drawing.Size(140, 0);
            this.emailWarningText.Name = "emailWarningText";
            this.emailWarningText.Size = new System.Drawing.Size(111, 14);
            this.emailWarningText.TabIndex = 11;
            this.emailWarningText.Text = "Email already exists";
            this.emailWarningText.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.emailWarningText);
            this.panel1.Controls.Add(this.usernameWarningText);
            this.panel1.Controls.Add(this.passWarningText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(123, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 299);
            this.panel1.TabIndex = 12;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newEmail);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.newUsername);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "CreateAccount";
            this.Text = "Create New Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmPassword;
        public System.Windows.Forms.Label passWarningText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newEmail;
        public System.Windows.Forms.Label usernameWarningText;
        public System.Windows.Forms.Label emailWarningText;
        private System.Windows.Forms.Panel panel1;
    }
}