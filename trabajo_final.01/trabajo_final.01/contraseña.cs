using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_final._01
{
    public partial class contraseña : Form
    {
        public contraseña()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contraseña_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmusuario obj1 = new frmusuario();
            obj1.Visible = true;
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcontraseña.Text  == "1")
                 {
                     nuevo_usuario obj2 = new nuevo_usuario();
                     obj2.Visible = true;
                     Visible = false;

        }
            else
            {
                MessageBox.Show ("error de contraseña");

            }
                

        }
    }
}
