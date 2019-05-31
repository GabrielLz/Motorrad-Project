namespace Final_System
{
    partial class Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caixa));
            this.DataGrid_Produtos = new System.Windows.Forms.DataGridView();
            this.DataGrid_Carrinho = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Modelo = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Preco = new System.Windows.Forms.MaskedTextBox();
            this.Txt_ValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Marca = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Nome = new System.Windows.Forms.MaskedTextBox();
            this.Txt_ID = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Categoria = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Quantidade = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Adicionar = new System.Windows.Forms.Button();
            this.Btn_Finalizar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Carrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid_Produtos
            // 
            this.DataGrid_Produtos.AllowUserToOrderColumns = true;
            this.DataGrid_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Produtos.Location = new System.Drawing.Point(461, 28);
            this.DataGrid_Produtos.Name = "DataGrid_Produtos";
            this.DataGrid_Produtos.Size = new System.Drawing.Size(653, 281);
            this.DataGrid_Produtos.TabIndex = 88;
            this.DataGrid_Produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Produtos_CellClick);
            // 
            // DataGrid_Carrinho
            // 
            this.DataGrid_Carrinho.AllowUserToOrderColumns = true;
            this.DataGrid_Carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Carrinho.Location = new System.Drawing.Point(461, 341);
            this.DataGrid_Carrinho.Name = "DataGrid_Carrinho";
            this.DataGrid_Carrinho.Size = new System.Drawing.Size(653, 288);
            this.DataGrid_Carrinho.TabIndex = 89;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 93;
            this.label8.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(241, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 94;
            this.label7.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 95;
            this.label3.Text = "Preço (R$):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(158, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 96;
            this.label10.Text = "Valor Total (R$):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 97;
            this.label4.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 98;
            this.label6.Text = "Categoria:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(241, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 16);
            this.label9.TabIndex = 99;
            this.label9.Text = "Quantidade a ser vendida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 100;
            this.label5.Text = "ID:";
            // 
            // Txt_Modelo
            // 
            this.Txt_Modelo.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Modelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Modelo.Location = new System.Drawing.Point(244, 245);
            this.Txt_Modelo.Mask = "aaaaaaaaaaaaaaaaaa";
            this.Txt_Modelo.Name = "Txt_Modelo";
            this.Txt_Modelo.Size = new System.Drawing.Size(88, 13);
            this.Txt_Modelo.TabIndex = 101;
            // 
            // Txt_Preco
            // 
            this.Txt_Preco.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Preco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Preco.Location = new System.Drawing.Point(22, 245);
            this.Txt_Preco.Mask = "0000000000";
            this.Txt_Preco.Name = "Txt_Preco";
            this.Txt_Preco.Size = new System.Drawing.Size(115, 13);
            this.Txt_Preco.TabIndex = 103;
            // 
            // Txt_ValorTotal
            // 
            this.Txt_ValorTotal.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_ValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_ValorTotal.Location = new System.Drawing.Point(161, 470);
            this.Txt_ValorTotal.Mask = "000000000000000";
            this.Txt_ValorTotal.Name = "Txt_ValorTotal";
            this.Txt_ValorTotal.Size = new System.Drawing.Size(88, 13);
            this.Txt_ValorTotal.TabIndex = 102;
            this.Txt_ValorTotal.Text = "0";
            // 
            // Txt_Marca
            // 
            this.Txt_Marca.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Marca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Marca.Location = new System.Drawing.Point(244, 210);
            this.Txt_Marca.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.Txt_Marca.Name = "Txt_Marca";
            this.Txt_Marca.Size = new System.Drawing.Size(194, 13);
            this.Txt_Marca.TabIndex = 104;
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nome.Location = new System.Drawing.Point(22, 210);
            this.Txt_Nome.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(194, 13);
            this.Txt_Nome.TabIndex = 105;
            // 
            // Txt_ID
            // 
            this.Txt_ID.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_ID.Location = new System.Drawing.Point(22, 175);
            this.Txt_ID.Mask = "00000";
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(36, 13);
            this.Txt_ID.TabIndex = 106;
            // 
            // Txt_Categoria
            // 
            this.Txt_Categoria.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Categoria.Location = new System.Drawing.Point(22, 280);
            this.Txt_Categoria.Mask = "aaaaaaaaaaaaaaaaaaa";
            this.Txt_Categoria.Name = "Txt_Categoria";
            this.Txt_Categoria.Size = new System.Drawing.Size(115, 13);
            this.Txt_Categoria.TabIndex = 107;
            this.Txt_Categoria.ValidatingType = typeof(System.DateTime);
            // 
            // Txt_Quantidade
            // 
            this.Txt_Quantidade.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Quantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Quantidade.Location = new System.Drawing.Point(244, 279);
            this.Txt_Quantidade.Mask = "00000";
            this.Txt_Quantidade.Name = "Txt_Quantidade";
            this.Txt_Quantidade.Size = new System.Drawing.Size(95, 13);
            this.Txt_Quantidade.TabIndex = 108;
            this.Txt_Quantidade.ValidatingType = typeof(System.DateTime);
            // 
            // Btn_Adicionar
            // 
            this.Btn_Adicionar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Adicionar.FlatAppearance.BorderSize = 0;
            this.Btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Adicionar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Adicionar.Location = new System.Drawing.Point(77, 519);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(125, 85);
            this.Btn_Adicionar.TabIndex = 109;
            this.Btn_Adicionar.Text = "Adicionar ao Carrinho";
            this.Btn_Adicionar.UseVisualStyleBackColor = false;
            this.Btn_Adicionar.Click += new System.EventHandler(this.Btn_Adicionar_Click);
            // 
            // Btn_Finalizar
            // 
            this.Btn_Finalizar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Finalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Finalizar.FlatAppearance.BorderSize = 0;
            this.Btn_Finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Finalizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Finalizar.Location = new System.Drawing.Point(207, 519);
            this.Btn_Finalizar.Name = "Btn_Finalizar";
            this.Btn_Finalizar.Size = new System.Drawing.Size(125, 85);
            this.Btn_Finalizar.TabIndex = 110;
            this.Btn_Finalizar.Text = "Finalizar:";
            this.Btn_Finalizar.UseVisualStyleBackColor = false;
            this.Btn_Finalizar.Click += new System.EventHandler(this.Btn_Finalizar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 111;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(241, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 112;
            this.label11.Text = "Pesquisar:";
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Voltar.FlatAppearance.BorderSize = 0;
            this.Btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Voltar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(0, 590);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(77, 38);
            this.Btn_Voltar.TabIndex = 113;
            this.Btn_Voltar.Text = "Sair";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(461, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 28);
            this.panel1.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 115;
            this.label1.Text = "Produtos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(152)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 33);
            this.panel2.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(752, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 116;
            this.label2.Text = "Carrinho";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Location = new System.Drawing.Point(12, 308);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 33);
            this.panel3.TabIndex = 116;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel4.Location = new System.Drawing.Point(33, 308);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 33);
            this.panel4.TabIndex = 116;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(152)))));
            this.panel5.Location = new System.Drawing.Point(12, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 130);
            this.panel5.TabIndex = 116;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(152)))));
            this.panel6.Location = new System.Drawing.Point(33, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 130);
            this.panel6.TabIndex = 116;
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 628);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_Finalizar);
            this.Controls.Add(this.Btn_Adicionar);
            this.Controls.Add(this.Txt_Quantidade);
            this.Controls.Add(this.Txt_Categoria);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Txt_Marca);
            this.Controls.Add(this.Txt_ValorTotal);
            this.Controls.Add(this.Txt_Preco);
            this.Controls.Add(this.Txt_Modelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataGrid_Carrinho);
            this.Controls.Add(this.DataGrid_Produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Caixa";
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.Caixa_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Caixa_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Caixa_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Caixa_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Carrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Produtos;
        private System.Windows.Forms.DataGridView DataGrid_Carrinho;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox Txt_Modelo;
        private System.Windows.Forms.MaskedTextBox Txt_Preco;
        private System.Windows.Forms.MaskedTextBox Txt_ValorTotal;
        private System.Windows.Forms.MaskedTextBox Txt_Marca;
        private System.Windows.Forms.MaskedTextBox Txt_Nome;
        private System.Windows.Forms.MaskedTextBox Txt_ID;
        private System.Windows.Forms.MaskedTextBox Txt_Categoria;
        private System.Windows.Forms.MaskedTextBox Txt_Quantidade;
        private System.Windows.Forms.Button Btn_Adicionar;
        private System.Windows.Forms.Button Btn_Finalizar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}