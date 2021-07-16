using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjtVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            
            MostrarFormulario("V");
        }


        private void MostrarFormulario(string opcion)
        {
            
            Form f=new Form();
           


            switch (opcion)
            {
                case "V":
                    f = new Formulario.frmVender();
                    break;
                case "NP":
                    f = new Formulario.frmNuevoProducto();
                    break;
                case "C":
                    f = new Formulario.frmConsultar("C");
                    break;
                case "A":
                    f = new Formulario.frmAyuda();
                    break;
                case "H":
                    f = new Formulario.frmHerramientas();
                    break;


            }

            panel1.Controls.Clear();

            f.Dock = DockStyle.Fill;
                f.TopLevel = false;
                panel1.Controls.Add(f);
                f.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarFormulario("NP");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarFormulario("C");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarFormulario("H");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarFormulario("A");
        }
    }
}
