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
    public partial class entrada : Form
    {
        public entrada()
        {
            InitializeComponent();
        }

        private void entrada_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmusuario obj123 = new frmusuario();
            obj123.Visible = true;
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txttelefono.Clear();
            txtmarca.Clear();
            txtserial.Clear();
            txtotros.Clear();
            txtcliente.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            SQLiteConnection conectado = new SQLiteConnection("data source =base.s3db;Version=3;");
            conectado.Open();

            string comando = "insert into trabajo values (null,'" + txtnombre.Text + "','" + txttelefono.Text + "','" + cboarticulo.Text + "','" + txtmarca.Text + "','" + txtserial.Text + "','" + txtcliente.Text + "',null ,'" + txtotros.Text + "'," + dateTimePicker1 + ",null ,'en curso',null,null,null,null)";
            SQLiteCommand datos = new SQLiteCommand (comando,conectado);
            if (datos.ExecuteNonQuery() > 0)
                MessageBox.Show("usuario creado");
           
        }

        }
    }

