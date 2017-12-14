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
    public partial class frmusuario : Form
    {
        public frmusuario()
        {
            InitializeComponent();
        }

        private void frmusuario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nuevo_usuario frm2 = new nuevo_usuario();

            frm2.Show();
         
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
