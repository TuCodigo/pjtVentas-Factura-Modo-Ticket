using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjtVentas.Formulario
{
    public partial class frmConsultar : Form
    {
        string Opcion;
        public frmConsultar(string opcion)
        {
            Opcion = opcion;
            InitializeComponent();
        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {
            if (Opcion == "P")
            {
               dataGridView1.DataSource=ClassFunciones.clsFunciones.EjecutaQueryConsulta("", "C");
                btnElegir.Visible = true;
                btnCancelar.Visible = true;
            }
            else {
                dataGridView1.DataSource = ClassFunciones.clsFunciones.EjecutaQueryConsulta("", "CDV");
                btnElegir.Visible = false;
                btnCancelar.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult D = DialogResult.Cancel;
            this.Close();

         
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            ClassBT.clsProducto.idProducto =int.Parse( dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ClassBT.clsProducto.NombreProducto = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ClassBT.clsProducto.Precio = float.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            this.Close();
        }
    }
}
