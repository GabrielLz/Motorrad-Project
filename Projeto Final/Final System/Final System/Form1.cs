using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SQLite;
using System.Threading;

namespace Final_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArredondaCantosdoForm();
        }
        Thread TH;
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=MotorradDB.db;Version=3;New=False;Compress=true;");
        }
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from MotorradTB_ADMs";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];

            sql_con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
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

        private void PicBox_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PicBox_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;

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
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void PicBox_Close_MouseHover(object sender, EventArgs e)
        {
            PicBox_Close.BackColor = Color.Red;
        }

        private void PicBox_Close_MouseLeave(object sender, EventArgs e)
        {
            PicBox_Close.BackColor = Color.White;
        }

        private void PicBox_Minimize_MouseHover(object sender, EventArgs e)
        {
            PicBox_Minimize.BackColor = Color.DeepSkyBlue;
        }

        private void PicBox_Minimize_MouseLeave(object sender, EventArgs e)
        {
            PicBox_Minimize.BackColor = Color.White;
        }

        private void Bnt_Login_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlcon = new SQLiteConnection(sql_con);
            try
            {
                sql_con.Open();
                string Query = "SELECT * from MotorradTB_ADMs where ID='" + this.Txt_ID.Text + "' and User ='" + this.Txt_User.Text + "' and Password='" + this.Txt_Password.Text + "' ";

                SQLiteCommand CreateCommand = new SQLiteCommand(Query, sql_con);
                CreateCommand.ExecuteNonQuery();
                SQLiteDataReader DR = CreateCommand.ExecuteReader();

                

                int count = 0;
                while (DR.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    this.Close();
                    TH = new Thread(OpenFormADM);
                    TH.SetApartmentState(ApartmentState.STA);
                    TH.Start();
                }
                else if (count < 1)
                {
                    MessageBox.Show("Usuario, senha e/ou ID estão incorretos!", "Erro");
                    this.Close();
                    TH = new Thread(OpenForm1);
                    TH.SetApartmentState(ApartmentState.STA);
                    TH.Start();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
        public void OpenForm1()
        {
            Application.Run(new Form1());
        }
        private void OpenFormADM()
        {
            Application.Run(new ADM_Screen());
        }
        private void OpenFormNonADM()
        {
            Application.Run(new NonADM_Screen());
        }

        private void Login_Normal_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlcon = new SQLiteConnection(sql_con);
            try
            {
                sql_con.Open();
                string Query = "SELECT * from MotorradTB_FuncionariosLogin where ID='" + this.Txt_ID.Text + "' and User ='" + this.Txt_User.Text + "' and Password='" + this.Txt_Password.Text + "' ";

                SQLiteCommand CreateCommand = new SQLiteCommand(Query, sql_con);
                CreateCommand.ExecuteNonQuery();
                SQLiteDataReader DR = CreateCommand.ExecuteReader();



                int count = 0;
                while (DR.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    this.Close();
                    TH = new Thread(OpenFormNonADM);
                    TH.SetApartmentState(ApartmentState.STA);
                    TH.Start();
                }
                else if (count < 1)
                {
                    MessageBox.Show("Usuario, senha e/ou ID estão incorretos!", "Erro");
                    this.Close();
                    TH = new Thread(OpenForm1);
                    TH.SetApartmentState(ApartmentState.STA);
                    TH.Start();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        
    }
}
