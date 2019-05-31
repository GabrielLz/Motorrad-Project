namespace Final_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bnt_Login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicBox_Minimize = new System.Windows.Forms.PictureBox();
            this.PicBox_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_User = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Login_Normal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_ID
            // 
            this.Txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_ID.Location = new System.Drawing.Point(60, 401);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(70, 13);
            this.Txt_ID.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "ID:";
            // 
            // Bnt_Login
            // 
            this.Bnt_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bnt_Login.FlatAppearance.BorderSize = 0;
            this.Bnt_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bnt_Login.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Login.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Bnt_Login.Location = new System.Drawing.Point(60, 420);
            this.Bnt_Login.Name = "Bnt_Login";
            this.Bnt_Login.Size = new System.Drawing.Size(97, 45);
            this.Bnt_Login.TabIndex = 18;
            this.Bnt_Login.Text = "Log In";
            this.Bnt_Login.UseVisualStyleBackColor = true;
            this.Bnt_Login.Click += new System.EventHandler(this.Bnt_Login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.PicBox_Minimize);
            this.panel1.Controls.Add(this.PicBox_Close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 271);
            this.panel1.TabIndex = 17;
            // 
            // PicBox_Minimize
            // 
            this.PicBox_Minimize.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PicBox_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBox_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("PicBox_Minimize.Image")));
            this.PicBox_Minimize.Location = new System.Drawing.Point(276, 0);
            this.PicBox_Minimize.Name = "PicBox_Minimize";
            this.PicBox_Minimize.Size = new System.Drawing.Size(34, 24);
            this.PicBox_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox_Minimize.TabIndex = 1;
            this.PicBox_Minimize.TabStop = false;
            this.PicBox_Minimize.Click += new System.EventHandler(this.PicBox_Minimize_Click);
            this.PicBox_Minimize.MouseLeave += new System.EventHandler(this.PicBox_Minimize_MouseLeave);
            this.PicBox_Minimize.MouseHover += new System.EventHandler(this.PicBox_Minimize_MouseHover);
            // 
            // PicBox_Close
            // 
            this.PicBox_Close.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PicBox_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("PicBox_Close.Image")));
            this.PicBox_Close.Location = new System.Drawing.Point(310, 0);
            this.PicBox_Close.Name = "PicBox_Close";
            this.PicBox_Close.Size = new System.Drawing.Size(25, 24);
            this.PicBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox_Close.TabIndex = 1;
            this.PicBox_Close.TabStop = false;
            this.PicBox_Close.Click += new System.EventHandler(this.PicBox_Close_Click);
            this.PicBox_Close.MouseLeave += new System.EventHandler(this.PicBox_Close_MouseLeave);
            this.PicBox_Close.MouseHover += new System.EventHandler(this.PicBox_Close_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-63, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password:";
            // 
            // Txt_Password
            // 
            this.Txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Password.Location = new System.Drawing.Point(60, 354);
            this.Txt_Password.Multiline = true;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(223, 23);
            this.Txt_Password.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "User:";
            // 
            // Txt_User
            // 
            this.Txt_User.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_User.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_User.Location = new System.Drawing.Point(60, 308);
            this.Txt_User.Multiline = true;
            this.Txt_User.Name = "Txt_User";
            this.Txt_User.Size = new System.Drawing.Size(223, 23);
            this.Txt_User.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "as ADM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "as employee";
            // 
            // Login_Normal
            // 
            this.Login_Normal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Normal.FlatAppearance.BorderSize = 0;
            this.Login_Normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Normal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Normal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Login_Normal.Location = new System.Drawing.Point(185, 420);
            this.Login_Normal.Name = "Login_Normal";
            this.Login_Normal.Size = new System.Drawing.Size(97, 45);
            this.Login_Normal.TabIndex = 22;
            this.Login_Normal.Text = "Log In";
            this.Login_Normal.UseVisualStyleBackColor = true;
            this.Login_Normal.Click += new System.EventHandler(this.Login_Normal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 486);
            this.Controls.Add(this.Login_Normal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bnt_Login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bnt_Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PicBox_Minimize;
        private System.Windows.Forms.PictureBox PicBox_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_User;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Login_Normal;
    }
}

