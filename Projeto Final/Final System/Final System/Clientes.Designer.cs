namespace Final_System
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Txt_DataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.Txt_DataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.Txt_ID = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Nome = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Fixo = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Celular = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGrid_Clientes = new System.Windows.Forms.DataGridView();
            this.Btn_Deletar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Adicionar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Numero = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Endereco = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Voltar.FlatAppearance.BorderSize = 0;
            this.Btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Voltar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(-1, 439);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(69, 33);
            this.Btn_Voltar.TabIndex = 68;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Txt_DataCadastro
            // 
            this.Txt_DataCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_DataCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_DataCadastro.Location = new System.Drawing.Point(32, 406);
            this.Txt_DataCadastro.Mask = "00/00/0000";
            this.Txt_DataCadastro.Name = "Txt_DataCadastro";
            this.Txt_DataCadastro.Size = new System.Drawing.Size(64, 13);
            this.Txt_DataCadastro.TabIndex = 67;
            this.Txt_DataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // Txt_DataNascimento
            // 
            this.Txt_DataNascimento.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_DataNascimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_DataNascimento.Location = new System.Drawing.Point(32, 371);
            this.Txt_DataNascimento.Mask = "00/00/0000";
            this.Txt_DataNascimento.Name = "Txt_DataNascimento";
            this.Txt_DataNascimento.Size = new System.Drawing.Size(64, 13);
            this.Txt_DataNascimento.TabIndex = 66;
            this.Txt_DataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // Txt_ID
            // 
            this.Txt_ID.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_ID.Location = new System.Drawing.Point(32, 164);
            this.Txt_ID.Mask = "00000";
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(36, 13);
            this.Txt_ID.TabIndex = 65;
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nome.Location = new System.Drawing.Point(32, 199);
            this.Txt_Nome.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(239, 13);
            this.Txt_Nome.TabIndex = 64;
            // 
            // Txt_Fixo
            // 
            this.Txt_Fixo.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Fixo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Fixo.Location = new System.Drawing.Point(32, 304);
            this.Txt_Fixo.Mask = "(99) 0000-0000";
            this.Txt_Fixo.Name = "Txt_Fixo";
            this.Txt_Fixo.Size = new System.Drawing.Size(88, 13);
            this.Txt_Fixo.TabIndex = 62;
            // 
            // Txt_Celular
            // 
            this.Txt_Celular.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Celular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Celular.Location = new System.Drawing.Point(32, 269);
            this.Txt_Celular.Mask = "(99) 00000-0000";
            this.Txt_Celular.Name = "Txt_Celular";
            this.Txt_Celular.Size = new System.Drawing.Size(88, 13);
            this.Txt_Celular.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 59;
            this.label7.Text = "Data de cadastro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Data de nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Fixo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Celular:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nome completo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // DataGrid_Clientes
            // 
            this.DataGrid_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Clientes.Location = new System.Drawing.Point(301, -1);
            this.DataGrid_Clientes.Name = "DataGrid_Clientes";
            this.DataGrid_Clientes.Size = new System.Drawing.Size(530, 393);
            this.DataGrid_Clientes.TabIndex = 52;
            this.DataGrid_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Clientes_CellClick);
            // 
            // Btn_Deletar
            // 
            this.Btn_Deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(152)))));
            this.Btn_Deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Deletar.FlatAppearance.BorderSize = 0;
            this.Btn_Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Deletar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Deletar.Location = new System.Drawing.Point(665, 387);
            this.Btn_Deletar.Name = "Btn_Deletar";
            this.Btn_Deletar.Size = new System.Drawing.Size(166, 85);
            this.Btn_Deletar.TabIndex = 50;
            this.Btn_Deletar.Text = "Deletar";
            this.Btn_Deletar.UseVisualStyleBackColor = false;
            this.Btn_Deletar.Click += new System.EventHandler(this.Btn_Deletar_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(152)))));
            this.Btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Editar.FlatAppearance.BorderSize = 0;
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Location = new System.Drawing.Point(489, 387);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(177, 85);
            this.Btn_Editar.TabIndex = 49;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = false;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Adicionar
            // 
            this.Btn_Adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(152)))));
            this.Btn_Adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Adicionar.FlatAppearance.BorderSize = 0;
            this.Btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Adicionar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Adicionar.Location = new System.Drawing.Point(301, 387);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(188, 85);
            this.Btn_Adicionar.TabIndex = 48;
            this.Btn_Adicionar.Text = "Adicionar";
            this.Btn_Adicionar.UseVisualStyleBackColor = false;
            this.Btn_Adicionar.Click += new System.EventHandler(this.Btn_Adicionar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(218, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 71;
            this.label8.Text = "Número:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 72;
            this.label9.Text = "Endereço:";
            // 
            // Txt_Numero
            // 
            this.Txt_Numero.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Numero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Numero.Location = new System.Drawing.Point(221, 336);
            this.Txt_Numero.Mask = "00000";
            this.Txt_Numero.Name = "Txt_Numero";
            this.Txt_Numero.Size = new System.Drawing.Size(63, 13);
            this.Txt_Numero.TabIndex = 69;
            this.Txt_Numero.ValidatingType = typeof(System.DateTime);
            // 
            // Txt_Endereco
            // 
            this.Txt_Endereco.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Endereco.Location = new System.Drawing.Point(32, 336);
            this.Txt_Endereco.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.Txt_Endereco.Name = "Txt_Endereco";
            this.Txt_Endereco.Size = new System.Drawing.Size(183, 13);
            this.Txt_Endereco.TabIndex = 70;
            this.Txt_Endereco.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(168, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 106;
            this.label11.Text = "Pesquisar:";
            // 
            // Txt_Pesquisar
            // 
            this.Txt_Pesquisar.Location = new System.Drawing.Point(171, 163);
            this.Txt_Pesquisar.Name = "Txt_Pesquisar";
            this.Txt_Pesquisar.Size = new System.Drawing.Size(100, 20);
            this.Txt_Pesquisar.TabIndex = 105;
            this.Txt_Pesquisar.TextChanged += new System.EventHandler(this.Txt_Pesquisar_TextChanged);
            // 
            // Txt_Email
            // 
            this.Txt_Email.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Email.Location = new System.Drawing.Point(31, 231);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(239, 13);
            this.Txt_Email.TabIndex = 107;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 471);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Txt_Pesquisar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txt_Numero);
            this.Controls.Add(this.Txt_Endereco);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Txt_DataCadastro);
            this.Controls.Add(this.Txt_DataNascimento);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Txt_Fixo);
            this.Controls.Add(this.Txt_Celular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataGrid_Clientes);
            this.Controls.Add(this.Btn_Deletar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Adicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Clientes_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Clientes_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Clientes_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.MaskedTextBox Txt_DataCadastro;
        private System.Windows.Forms.MaskedTextBox Txt_DataNascimento;
        private System.Windows.Forms.MaskedTextBox Txt_ID;
        private System.Windows.Forms.MaskedTextBox Txt_Nome;
        private System.Windows.Forms.MaskedTextBox Txt_Fixo;
        private System.Windows.Forms.MaskedTextBox Txt_Celular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DataGrid_Clientes;
        private System.Windows.Forms.Button Btn_Deletar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Adicionar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox Txt_Numero;
        private System.Windows.Forms.MaskedTextBox Txt_Endereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_Pesquisar;
        private System.Windows.Forms.TextBox Txt_Email;
    }
}