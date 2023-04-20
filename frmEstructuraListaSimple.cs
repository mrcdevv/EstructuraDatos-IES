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
    public partial class frmEstructuraListaSimple : Form
    {
        public frmEstructuraListaSimple()
        {
            InitializeComponent();
        }

        ListaSimple objLista = new ListaSimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();

            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            objLista.Agregar(objNodo);
            objLista.Recorrer(dgvDatos);
            objLista.Recorrer(lstDatos);
            objLista.Recorrer(lstCodigo);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

            //lstCodigo.Items.Add(objNodo.Codigo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCodigo.Items != null)
            {
                Int32 cod = Convert.ToInt32(lstCodigo.Text);

                objLista.Eliminar(cod);
                objLista.Recorrer(dgvDatos);
                objLista.Recorrer(lstDatos);
                objLista.Recorrer(lstCodigo);
            }
        }

        private void frmEstructuraListaSimple_Load(object sender, EventArgs e)
        {
            

        }
    }
}
