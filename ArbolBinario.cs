using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class ArbolBinario
    {
        private Nodo Inicio;

        public Nodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }

        public void Agregar(Nodo nuevo)
        {
            nuevo.Izquierda = null;
            nuevo.Derecha = null;

            if(Raiz == null)
            {
                Raiz = nuevo;
            }
            else
            {
                Nodo nodoPadre = Raiz;
                Nodo aux = Raiz;

                while (aux != null)
                {
                    nodoPadre = aux;
                    if (nuevo.Codigo < aux.Codigo)
                    {
                        aux = aux.Izquierda;
                    }
                    else
                    {
                        aux = aux.Derecha;
                    }
                }

                if(nuevo.Codigo < nodoPadre.Codigo)
                {
                    nodoPadre.Izquierda = nuevo;
                }
                else
                {
                    nodoPadre.Derecha = nuevo;
                }
            }
        }


        public void Recorrer(ListBox lista)
        {
            lista.Items.Clear();
            InOrderAsc(lista, Raiz);
        }

        
        public void InOrderAsc(ListBox lst, Nodo R)
        {
            if(R.Izquierda != null)
            {
                InOrderAsc(lst, R.Izquierda);  //I
            }
            lst.Items.Add(R.Codigo); // R
            if(R.Derecha != null) 
            {
                InOrderAsc(lst, R.Derecha); //D
            }
        }


        public void InOrderDesc(ListBox lst, Nodo R)
        {
            if (R.Derecha != null)
            {
                InOrderDesc(lst, R.Derecha); //D
            }
            lst.Items.Add(R.Codigo); //R
            if (R.Izquierda != null)
            {
                InOrderDesc(lst, R.Izquierda);  //I
            }
        }
    }
}


// InOrden: (I-R-D)ASC - (D-R-I)DESC
// PreOrden: R-I-D
// PostOrden: I-D-R
