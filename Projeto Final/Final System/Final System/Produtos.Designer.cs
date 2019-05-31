namespace Final_System
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.Txt_Quantidade = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Txt_Categoria = new System.Windows.Forms.MaskedTextBox();
            this.Txt_ID = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Nome = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Marca = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Preco = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Modelo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGrid_Produtos = new System.Windows.Forms.DataGridView();
            this.Btn_Deletar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Adicionar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_Pesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Quantidade
            // 
            this.Txt_Quantidade.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Quantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Quantidade.Location = new System.Drawing.Point(34, 389);
            this.Txt_Quantidade.Mask = "aaaaaa";
            this.Txt_Quantidade.Name = "Txt_Quantidade";
            this.Txt_Quantidade.Size = new System.Drawing.Size(95, 13);
            this.Txt_Quantidade.TabIndex = 102;
            this.Txt_Quantidade.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 101;
            this.label9.Text = "Quantidade:";
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Voltar.FlatAppearance.BorderSize = 0;
            this.Btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Voltar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(0, 409);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(69, 33);
            this.Btn_Voltar.TabIndex = 100;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Txt_Categoria
            // 
            this.Txt_Categoria.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Categoria.Location = new System.Drawing.Point(34, 352);
            this.Txt_Categoria.Mask = "aaaaaaaaaaaaaaaaaaa";
            this.Txt_Categoria.Name = "Txt_Categoria";
            this.Txt_Categoria.Size = new System.Drawing.Size(98, 13);
            this.Txt_Categoria.TabIndex = 99;
            this.Txt_Categoria.ValidatingType = typeof(System.DateTime);
            // 
            // Txt_ID
            // 
            this.Txt_ID.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_ID.Location = new System.Drawing.Point(34, 177);
            this.Txt_ID.Mask = "00000";
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(36, 13);
            this.Txt_ID.TabIndex = 98;
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nome.Location = new System.Drawing.Point(34, 212);
            this.Txt_Nome.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(194, 13);
            this.Txt_Nome.TabIndex = 97;
            this.Txt_Nome.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txt_Nome_MaskInputRejected);
            // 
            // Txt_Marca
            // 
            this.Txt_Marca.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Marca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Marca.Location = new System.Drawing.Point(34, 247);
            this.Txt_Marca.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.Txt_Marca.Name = "Txt_Marca";
            this.Txt_Marca.Size = new System.Drawing.Size(194, 13);
            this.Txt_Marca.TabIndex = 96;
            // 
            // Txt_Preco
            // 
            this.Txt_Preco.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Preco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Preco.Location = new System.Drawing.Point(34, 317);
            this.Txt_Preco.Mask = "0000000000";
            this.Txt_Preco.Name = "Txt_Preco";
            this.Txt_Preco.Size = new System.Drawing.Size(88, 13);
            this.Txt_Preco.TabIndex = 95;
            // 
            // Txt_Modelo
            // 
            this.Txt_Modelo.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Modelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Modelo.Location = new System.Drawing.Point(34, 282);
            this.Txt_Modelo.Mask = "aaaaaaaaaaaaaaaaaa";
            this.Txt_Modelo.Name = "Txt_Modelo";
            this.Txt_Modelo.Size = new System.Drawing.Size(88, 13);
            this.Txt_Modelo.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 93;
            this.label5.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 92;
            this.label6.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 91;
            this.label4.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 90;
            this.label2.Text = "Preço (R$):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 89;
            this.label3.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 88;
            this.label1.Text = "Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // DataGrid_Produtos
            // 
            this.DataGrid_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Produtos.Location = new System.Drawing.Point(243, -1);
            this.DataGrid_Produtos.Name = "DataGrid_Produtos";
            this.DataGrid_Produtos.Size = new System.Drawing.Size(506, 357);
            this.DataGrid_Produtos.TabIndex = 86;
            this.DataGrid_Produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Produtos_CellClick);
            // 
            // Btn_Deletar
            // 
            this.Btn_Deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(152)))));
            this.Btn_Deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Deletar.FlatAppearance.BorderSize = 0;
            this.Btn_Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Deletar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Deletar.Location = new System.Drawing.Point(577, 356);
            this.Btn_Deletar.Name = "Btn_Deletar";
            this.Btn_Deletar.Size = new System.Drawing.Size(172, 85);
            this.Btn_Deletar.TabIndex = 84;
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
            this.Btn_Editar.Location = new System.Drawing.Point(408, 356);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(169, 85);
            this.Btn_Editar.TabIndex = 83;
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
            this.Btn_Adicionar.Location = new System.Drawing.Point(243, 356);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(166, 85);
            this.Btn_Adicionar.TabIndex = 82;
            this.Btn_Adicionar.Text = "Adicionar";
            this.Btn_Adicionar.UseVisualStyleBackColor = false;
            this.Btn_Adicionar.Click += new System.EventHandler(this.Btn_Adicionar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(120, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 104;
            this.label11.Text = "Pesquisar:";
            // 
            // Txt_Pesquisar
            // 
            this.Txt_Pesquisar.Location = new System.Drawing.Point(123, 174);
            this.Txt_Pesquisar.Name = "Txt_Pesquisar";
            this.Txt_Pesquisar.Size = new System.Drawing.Size(100, 20);
            this.Txt_Pesquisar.TabIndex = 103;
            this.Txt_Pesquisar.TextChanged += new System.EventHandler(this.Txt_Pesquisar_TextChanged);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 441);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Txt_Pesquisar);
            this.Controls.Add(this.Txt_Quantidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Txt_Categoria);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Txt_Marca);
            this.Controls.Add(this.Txt_Preco);
            this.Controls.Add(this.Txt_Modelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataGrid_Produtos);
            this.Controls.Add(this.Btn_Deletar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Adicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Produtos_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Produtos_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Produtos_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Txt_Quantidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.MaskedTextBox Txt_Categoria;
        private System.Windows.Forms.MaskedTextBox Txt_ID;
        private System.Windows.Forms.MaskedTextBox Txt_Nome;
        private System.Windows.Forms.MaskedTextBox Txt_Marca;
        private System.Windows.Forms.MaskedTextBox Txt_Preco;
        private System.Windows.Forms.MaskedTextBox Txt_Modelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DataGrid_Produtos;
        private System.Windows.Forms.Button Btn_Deletar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Adicionar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_Pesquisar;
    }
}