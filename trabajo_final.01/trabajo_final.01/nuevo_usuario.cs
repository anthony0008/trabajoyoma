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
        }

        private void consulta()
        {
            SQLiteConnection cadenaconexion = new SQLiteConnection("data source = C:/Users/tony stark/Documents/Visual Studio 2013/Projects/trabajo_final.01/trabajo_final.01/bin/Debug/usuario.sqlite");
            cadenaconexion.Open();

        }

        private void cargardatos()
        {
            SQLiteConnection cadenaconexion = new SQLiteConnection("data source = C:/Users/tony stark/Documents/Visual Studio 2013/Projects/trabajo_final.01/trabajo_final.01/bin/Debug/usuario.sqlite");
            cadenaconexion.Open();

            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("select * from usuario ", cadenaconexion);
            DataTable tabla = new DataTable("usuarios");
            adaptador.Fill(tabla);
            dgvmostrar.DataSource = tabla;
        }








        
    

        private void nuevo_usuario_Load(object sender, EventArgs e)
        {
       
           
           

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
           

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
            dgvmostrar.DataSource = tabla;
        }
    }
}
