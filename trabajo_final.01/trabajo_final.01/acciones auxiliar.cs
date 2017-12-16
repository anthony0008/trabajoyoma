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
    public partial class acciones_auxiliar : Form
    {
        public acciones_auxiliar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                frmusuario obj123 = new frmusuario();
                obj123.Visible = true;
                Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                entrada obj123 = new entrada();
                obj123.Visible = true;
                Visible = false;

            }
        }
    }
}
