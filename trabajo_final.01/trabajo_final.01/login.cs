using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace trabajo_final._01
{
    public partial class frmusuario : Form
    {
        public frmusuario()
        {
            InitializeComponent();
            SQLiteConnection conectado = new SQLiteConnection("data source =base.s3db;Version=3;");
            conectado.Open();
        }

        public void login(string usuario, string contraseña)
        {
        
           SQLiteConnection conectado = new SQLiteConnection("data source =base.s3db;Version=3;");
            conectado.Open();
            try
            {


                SQLiteCommand cn = new SQLiteCommand("Select pueto from usuarios  where nombre =@us  AND contraseña =@con", conectado);
                cn.Parameters.AddWithValue("us", usuario);
                cn.Parameters.AddWithValue("con", contraseña);
                SQLiteDataAdapter sda = new SQLiteDataAdapter(cn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {

                    if (dt.Rows[1][2].ToString() == "auxiliar")
                    {
                        acciones_auxiliar obj5 = new acciones_auxiliar();
                    }
                    else if (dt.Rows[1][2].ToString() == "cajero")
                    {
                        acciones_cajera obj6 = new acciones_cajera();
                    }
                    else if (dt.Rows[1][2].ToString() == "tecnico")
                    {
                        acciones_tecnico obj7 = new acciones_tecnico();
                    }
                    else if (dt.Rows[1][2].ToString() == "supervisor")
                    {
                        acciones_supervisora obj8 = new acciones_supervisora();

                    }
                    else 
                    {
                        MessageBox.Show("ese");

                    }

                }
               



            }
           
            finally
            { }

        }


        private void frmusuario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            contraseña obj = new contraseña();
            obj.Visible = true;
            Visible = false;


        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login(this.txtusuario.Text, txtcontraseña.Text);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            pasar obj130 = new pasar();
            obj130.Visible = true;
            Visible = false;
        }
    }
}
    

