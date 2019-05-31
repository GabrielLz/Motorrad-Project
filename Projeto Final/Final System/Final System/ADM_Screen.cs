using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;

namespace Final_System
{
    public partial class ADM_Screen : Form
    {
        public ADM_Screen()
        {
            InitializeComponent();
            ArredondaCantosdoForm();
            timer1.Start();
        }
        Thread TH;
        public void ArredondaCantosdoForm()
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));


            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);


            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);


            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, this.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);


            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            PastaGrafica.AddPie(this.Width - 24, this.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
        }

        private void Pic_box_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar? Você será deslogado!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Pic_Box_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Pic_box_Close_MouseHover(object sender, EventArgs e)
        {
            Pic_box_Close.BackColor = Color.Red;
        }

        private void Pic_box_Close_MouseLeave(object sender, EventArgs e)
        {
            Pic_box_Close.BackColor = Color.WhiteSmoke;
        }

        private void Pic_Box_Minimize_MouseHover(object sender, EventArgs e)
        {
            Pic_Box_Minimize.BackColor = Color.DeepSkyBlue;
        }

        private void Pic_Box_Minimize_MouseLeave(object sender, EventArgs e)
        {
            Pic_Box_Minimize.BackColor = Color.WhiteSmoke;
        }
        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;

        private void ADM_Screen_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
        }

        private void ADM_Screen_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }

        private void ADM_Screen_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }
        private void OpenFormProdutos()
        {
            Application.Run(new Produtos());
        }
        private void OpenFormClientes()
        {
            Application.Run(new Clientes());
        }
        private void OpenFormFuncionarios()
        {
            Application.Run(new Funcionarios());
        }
        private void OpenFormHistorico()
        {
            
        }
        private void OpenFormCaixa()
        {
            Application.Run(new Caixa());
        }
        private void OpenForm1()
        {
            Application.Run(new Form1());
        }

        private void Btn_Produtos_Click(object sender, EventArgs e)
        {
            TH = new Thread(OpenFormProdutos);
            TH.SetApartmentState(ApartmentState.STA);
            TH.Start();
        }

        private void Btn_Clientes_Click(object sender, EventArgs e)
        {
            TH = new Thread(OpenFormClientes);
            TH.SetApartmentState(ApartmentState.STA);
            TH.Start();
        }

        private void Btn_Funcionarios_Click(object sender, EventArgs e)
        {
            TH = new Thread(OpenFormFuncionarios);
            TH.SetApartmentState(ApartmentState.STA);
            TH.Start();
        }

        private void Btn_Historico_Click(object sender, EventArgs e)
        {
            TH = new Thread(OpenFormHistorico);
            TH.SetApartmentState(ApartmentState.STA);
            TH.Start();
        }

        private void Btn_Caixa_Click(object sender, EventArgs e)
        {
            TH = new Thread(OpenFormCaixa);
            TH.SetApartmentState(ApartmentState.STA);
            TH.Start();
        }

        private void Btn_Deslogar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deslogar?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                TH = new Thread(OpenForm1);
                TH.SetApartmentState(ApartmentState.STA);
                TH.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.Lbl_time.Text = datetime.ToString();
        }
    }
}
