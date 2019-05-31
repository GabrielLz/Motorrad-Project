namespace Final_System
{
    partial class ADM_Screen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADM_Screen));
            this.label2 = new System.Windows.Forms.Label();
            this.Pic_Box_Minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pic_box_Close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Caixa = new System.Windows.Forms.Button();
            this.Btn_Deslogar = new System.Windows.Forms.Button();
            this.Btn_Funcionarios = new System.Windows.Forms.Button();
            this.Btn_Clientes = new System.Windows.Forms.Button();
            this.Btn_Produtos = new System.Windows.Forms.Button();
            this.Lbl_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_box_Close)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "ADM";
            // 
            // Pic_Box_Minimize
            // 
            this.Pic_Box_Minimize.BackColor = System.Drawing.SystemColors.Control;
            this.Pic_Box_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Box_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Box_Minimize.Image")));
            this.Pic_Box_Minimize.Location = new System.Drawing.Point(782, 0);
            this.Pic_Box_Minimize.Name = "Pic_Box_Minimize";
            this.Pic_Box_Minimize.Size = new System.Drawing.Size(35, 24);
            this.Pic_Box_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Box_Minimize.TabIndex = 18;
            this.Pic_Box_Minimize.TabStop = false;
            this.Pic_Box_Minimize.Click += new System.EventHandler(this.Pic_Box_Minimize_Click);
            this.Pic_Box_Minimize.MouseLeave += new System.EventHandler(this.Pic_Box_Minimize_MouseLeave);
            this.Pic_Box_Minimize.MouseHover += new System.EventHandler(this.Pic_Box_Minimize_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(227, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Pic_box_Close
            // 
            this.Pic_box_Close.BackColor = System.Drawing.SystemColors.Control;
            this.Pic_box_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_box_Close.Image = ((System.Drawing.Image)(resources.GetObject("Pic_box_Close.Image")));
            this.Pic_box_Close.Location = new System.Drawing.Point(817, 0);
            this.Pic_box_Close.Name = "Pic_box_Close";
            this.Pic_box_Close.Size = new System.Drawing.Size(23, 24);
            this.Pic_box_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_box_Close.TabIndex = 19;
            this.Pic_box_Close.TabStop = false;
            this.Pic_box_Close.Click += new System.EventHandler(this.Pic_box_Close_Click);
            this.Pic_box_Close.MouseLeave += new System.EventHandler(this.Pic_box_Close_MouseLeave);
            this.Pic_box_Close.MouseHover += new System.EventHandler(this.Pic_box_Close_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.Btn_Caixa);
            this.panel1.Controls.Add(this.Btn_Deslogar);
            this.panel1.Controls.Add(this.Btn_Funcionarios);
            this.panel1.Controls.Add(this.Btn_Clientes);
            this.panel1.Controls.Add(this.Btn_Produtos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 79);
            this.panel1.TabIndex = 16;
            // 
            // Btn_Caixa
            // 
            this.Btn_Caixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Caixa.FlatAppearance.BorderSize = 0;
            this.Btn_Caixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Caixa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Caixa.Location = new System.Drawing.Point(534, 0);
            this.Btn_Caixa.Name = "Btn_Caixa";
            this.Btn_Caixa.Size = new System.Drawing.Size(165, 79);
            this.Btn_Caixa.TabIndex = 12;
            this.Btn_Caixa.Text = "Caixa";
            this.Btn_Caixa.UseVisualStyleBackColor = true;
            this.Btn_Caixa.Click += new System.EventHandler(this.Btn_Caixa_Click);
            // 
            // Btn_Deslogar
            // 
            this.Btn_Deslogar.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Deslogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Deslogar.FlatAppearance.BorderSize = 0;
            this.Btn_Deslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Deslogar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Deslogar.Location = new System.Drawing.Point(700, 0);
            this.Btn_Deslogar.Name = "Btn_Deslogar";
            this.Btn_Deslogar.Size = new System.Drawing.Size(140, 79);
            this.Btn_Deslogar.TabIndex = 12;
            this.Btn_Deslogar.Text = "Deslogar";
            this.Btn_Deslogar.UseVisualStyleBackColor = false;
            this.Btn_Deslogar.Click += new System.EventHandler(this.Btn_Deslogar_Click);
            // 
            // Btn_Funcionarios
            // 
            this.Btn_Funcionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Funcionarios.FlatAppearance.BorderSize = 0;
            this.Btn_Funcionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Funcionarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Funcionarios.Location = new System.Drawing.Point(354, 0);
            this.Btn_Funcionarios.Name = "Btn_Funcionarios";
            this.Btn_Funcionarios.Size = new System.Drawing.Size(178, 79);
            this.Btn_Funcionarios.TabIndex = 12;
            this.Btn_Funcionarios.Text = "Funcionários";
            this.Btn_Funcionarios.UseVisualStyleBackColor = true;
            this.Btn_Funcionarios.Click += new System.EventHandler(this.Btn_Funcionarios_Click);
            // 
            // Btn_Clientes
            // 
            this.Btn_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clientes.FlatAppearance.BorderSize = 0;
            this.Btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clientes.Location = new System.Drawing.Point(176, 0);
            this.Btn_Clientes.Name = "Btn_Clientes";
            this.Btn_Clientes.Size = new System.Drawing.Size(177, 79);
            this.Btn_Clientes.TabIndex = 12;
            this.Btn_Clientes.Text = "Clientes";
            this.Btn_Clientes.UseVisualStyleBackColor = true;
            this.Btn_Clientes.Click += new System.EventHandler(this.Btn_Clientes_Click);
            // 
            // Btn_Produtos
            // 
            this.Btn_Produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Produtos.FlatAppearance.BorderSize = 0;
            this.Btn_Produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Produtos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Produtos.Location = new System.Drawing.Point(0, 0);
            this.Btn_Produtos.Name = "Btn_Produtos";
            this.Btn_Produtos.Size = new System.Drawing.Size(175, 79);
            this.Btn_Produtos.TabIndex = 12;
            this.Btn_Produtos.Text = "Produtos";
            this.Btn_Produtos.UseVisualStyleBackColor = true;
            this.Btn_Produtos.Click += new System.EventHandler(this.Btn_Produtos_Click);
            // 
            // Lbl_time
            // 
            this.Lbl_time.AutoSize = true;
            this.Lbl_time.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_time.Location = new System.Drawing.Point(637, 4);
            this.Lbl_time.Name = "Lbl_time";
            this.Lbl_time.Size = new System.Drawing.Size(35, 17);
            this.Lbl_time.TabIndex = 23;
            this.Lbl_time.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ADM_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 264);
            this.Controls.Add(this.Lbl_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pic_Box_Minimize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pic_box_Close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADM_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADM_Screen";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ADM_Screen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ADM_Screen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ADM_Screen_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_box_Close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Pic_Box_Minimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Pic_box_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Deslogar;
        private System.Windows.Forms.Button Btn_Caixa;
        private System.Windows.Forms.Button Btn_Funcionarios;
        private System.Windows.Forms.Button Btn_Clientes;
        private System.Windows.Forms.Button Btn_Produtos;
        private System.Windows.Forms.Label Lbl_time;
        private System.Windows.Forms.Timer timer1;
    }
}