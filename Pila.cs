using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class Pila
    {

        public Nodo primero;

        public void Agregar(Nodo nuevo)
        {
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                nuevo.Siguiente = primero;
                primero = nuevo;
            }
        }

        public void Eliminar()
        {
            if(primero != null)
            {
                primero = primero.Siguiente;
            }

        }

        public void Recorrer(DataGridView Grilla)
        {
            Nodo aux = primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            Nodo aux = primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            Nodo aux = primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }

    }
}
