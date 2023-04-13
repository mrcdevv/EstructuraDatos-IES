using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmEstructuraCola : Form
    {
        public frmEstructuraCola()
        {
            InitializeComponent();
        }

        private void frmEstructuraCola_Load(object sender, EventArgs e)
        {

        }

        Cola objCola = new Cola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();

            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            objCola.Agregar(objNodo);
            objCola.Recorrer(dgvDatos);
            objCola.Recorrer(lstDatos);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(objCola.primero != null)
            {
                txtCodigoElim.Text = objCola.primero.Codigo.ToString();
                txtNombreElim.Text = objCola.primero.Nombre;
                txtTramiteElim.Text = objCola.primero.Tramite;

                objCola.Eliminar();
                objCola.Recorrer(dgvDatos);
                objCola.Recorrer(lstDatos);
            }
            else
            {
                txtCodigoElim.Text = "";
                txtNombreElim.Text = "";
                txtTramiteElim.Text = "";
            }
        }
    }
}
