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
    public partial class nuevo_usuario : Form
    {
        

        
        public nuevo_usuario()
        {
            InitializeComponent();
            SQLiteConnection conectado = new SQLiteConnection("data source = C:\\sistema\\base.db;Version=3;");
    
               
            
            try {
                conectado.Open();
                

        }
            catch (Exception)
            {
                MessageBox.Show("error");

            }

        }


       







        private void consulta()
        {
            

        }

        private void cargardatos()
        {
            

            
           
        }








        
    

        private void nuevo_usuario_Load(object sender, EventArgs e)
        {
       
           
           

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                frmusuario obj123 = new frmusuario();
                obj123.Visible = true;
                Visible = false;

            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            
            
            SQLiteConnection conectado = new SQLiteConnection("data source =base.s3db;Version=3;");
            conectado.Open();
        
            string comando = "insert into usuarios values (null,'" +txtnusuario.Text+"','"+cbocargo.Text+"','"+txtncontraseña.Text+"' )";
            SQLiteCommand datos = new SQLiteCommand (comando,conectado);
            if (datos.ExecuteNonQuery() > 0)
                MessageBox.Show("usuario creado");
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            SQLiteConnection cadenaconexion = new SQLiteConnection("data source = C:/Users/tony stark/Documents/Visual Studio 2013/Projects/trabajo_final.01/trabajo_final.01/bin/Debug/usuario.sqlite");
            cadenaconexion.Open();
            
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("select * from usuario ", cadenaconexion);
            DataTable tabla = new DataTable("usuario");
            adaptador.Fill(tabla);
            
        }

        private void txtnusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            txtnusuario.Clear();
            txtncontraseña.Clear();
           
        }
    }
}
