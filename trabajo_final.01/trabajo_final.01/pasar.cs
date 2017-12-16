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
    public partial class pasar : Form
    {
        public pasar()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
                   frmusuario obj123 = new frmusuario();
                obj123.Visible = true;
                Visible = false;

            }

        private void button1_Click(object sender, EventArgs e)
        {
             acciones_auxiliar obj124 = new acciones_auxiliar();
                obj124.Visible = true;
                Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
               acciones_cajera obj125 = new acciones_cajera();
                obj125.Visible = true;
                Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            acciones_tecnico obj126 = new acciones_tecnico();
            obj126.Visible = true;
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           acciones_supervisora obj129 = new acciones_supervisora();
            obj129.Visible = true;
            Visible = false;
        }
        }
    }

