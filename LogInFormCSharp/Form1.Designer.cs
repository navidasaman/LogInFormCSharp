namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            blueBlobCircle = new PictureBox();
            userIcon = new PictureBox();
            LogInButton = new Button();
            Username = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)blueBlobCircle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Light", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(330, -1);
            label1.Name = "label1";
            label1.Size = new Size(160, 67);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            label1.Click += label1_Click;
            // 
            // blueBlobCircle
            // 
            blueBlobCircle.Image = (Image)resources.GetObject("blueBlobCircle.Image");
            blueBlobCircle.Location = new Point(-3, -1);
            blueBlobCircle.Name = "blueBlobCircle";
            blueBlobCircle.Size = new Size(561, 493);
            blueBlobCircle.TabIndex = 1;
            blueBlobCircle.TabStop = false;
            blueBlobCircle.Click += pictureBox1_Click;
            // 
            // userIcon
            // 
            userIcon.Image = (Image)resources.GetObject("userIcon.Image");
            userIcon.Location = new Point(357, 90);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(101, 103);
            userIcon.TabIndex = 2;
            userIcon.TabStop = false;
            userIcon.Click += pictureBox2_Click;
            // 
            // LogInButton
            // 
            LogInButton.AutoEllipsis = true;
            LogInButton.BackColor = Color.LightSkyBlue;
            LogInButton.BackgroundImage = (Image)resources.GetObject("LogInButton.BackgroundImage");
            LogInButton.BackgroundImageLayout = ImageLayout.Center;
            LogInButton.FlatAppearance.BorderColor = Color.White;
            LogInButton.FlatAppearance.BorderSize = 0;
            LogInButton.FlatStyle = FlatStyle.Flat;
            LogInButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LogInButton.ForeColor = SystemColors.Desktop;
            LogInButton.Location = new Point(302, 327);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(208, 54);
            LogInButton.TabIndex = 3;
            LogInButton.Text = "Log In";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += button1_Click;
            // 
            // Username
            // 
            Username.AcceptsReturn = true;
            Username.AcceptsTab = true;
            Username.BackColor = SystemColors.ButtonFace;
            Username.Cursor = Cursors.SizeAll;
            Username.ForeColor = SystemColors.WindowFrame;
            Username.Location = new Point(302, 223);
            Username.Name = "Username";
            Username.Size = new Size(208, 31);
            Username.TabIndex = 4;
            Username.Text = "Username";
            Username.UseWaitCursor = true;
            Username.TextChanged += Username_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(302, 274);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 31);
            textBox1.TabIndex = 5;
            textBox1.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(554, 494);
            Controls.Add(textBox1);
            Controls.Add(Username);
            Controls.Add(LogInButton);
            Controls.Add(userIcon);
            Controls.Add(label1);
            Controls.Add(blueBlobCircle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)blueBlobCircle).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox blueBlobCircle;
        private PictureBox userIcon;
        private Button LogInButton;
        private TextBox Username;
        private TextBox textBox1;
    }
}