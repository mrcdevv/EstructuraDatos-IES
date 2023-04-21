using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class ListaDoble
    {

        private Nodo pri;
        private Nodo ult;

        public Nodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public Nodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(Nodo nuevo)
        {
            if(Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                if(nuevo.Codigo <= Primero.Codigo)
                {
                    nuevo.Siguiente = Primero;
                    Primero.Anterior = nuevo;
                    Primero = nuevo;
                } 
                else
                {
                    if (nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = nuevo;
                        nuevo.Anterior = Ultimo;
                        Ultimo = nuevo;
                    }
                    else
                    {
                        Nodo Aux = Primero;
                        Nodo Ant = Primero;

                        while(nuevo.Codigo > Aux.Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }

                        Ant.Siguiente = nuevo;
                        nuevo.Siguiente = Aux;
                        nuevo.Anterior = Ant;
                        Aux.Anterior = nuevo;
                    }
                }
            }
        }

        public void Eliminar( Int32 codigo)
        {
            if(Primero.Codigo == codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if(Primero.Codigo == codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if(Ultimo.Codigo == codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        Nodo Aux = Primero;
                        Nodo Ant = Primero;

                        while(codigo > Aux.Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }

                        Ant.Siguiente = Aux.Siguiente;
                        Aux = Aux.Siguiente;
                        Aux.Anterior = Ant;
                    }
                }
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            Nodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            Nodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            Nodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
    }
}
