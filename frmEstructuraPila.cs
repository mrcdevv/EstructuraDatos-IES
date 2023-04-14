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
    public partial class frmEstructuraPila : Form
    {
        public frmEstructuraPila()
        {
            InitializeComponent();
        }

        Pila objPila = new Pila();

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Nodo objNodo = new Nodo();

            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            objPila.Agregar(objNodo);
            objPila.Recorrer(dgvDatos);
            objPila.Recorrer(lstDatos);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objPila.primero != null)
            {
                txtCodigoElim.Text = objPila.primero.Codigo.ToString();
                txtNombreElim.Text = objPila.primero.Nombre;
                txtTramiteElim.Text = objPila.primero.Tramite;

                objPila.Eliminar();
                objPila.Recorrer(dgvDatos);
                objPila.Recorrer(lstDatos);
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
