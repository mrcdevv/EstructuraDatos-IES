using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class ListaSimple
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
                if (nuevo.Codigo <= primero.Codigo)
                {
                    nuevo.Siguiente = primero;
                    primero = nuevo;
                }
                else
                {
                    Nodo Anterior = primero;
                    Nodo Auxiliar = primero;

                    while (nuevo.Codigo > Auxiliar.Codigo)
                    {
                        Anterior =  Auxiliar;
                        Auxiliar = Auxiliar.Siguiente;

                        if(Auxiliar == null)
                        {
                            break;
                        }
                    }

                    Anterior.Siguiente = nuevo;
                    nuevo.Siguiente = Auxiliar;

                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if(primero.Codigo == Codigo)
            {
                primero = primero.Siguiente;
            }
            else
            {
                Nodo Anterior = primero;
                Nodo Auxiliar = primero;

                while (Auxiliar.Codigo != Codigo)
                {
                    Anterior = Auxiliar;
                    Auxiliar = Auxiliar.Siguiente;
                }

                Anterior.Siguiente = Auxiliar.Siguiente;
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
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
    }
}
