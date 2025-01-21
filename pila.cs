using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIUMIU1 {
    internal class pila 
    {
        private nodo cima = null;
        private int contador = 0;
        public void push (string nom) 
        {
            nodo nuevo = new nodo();
            nuevo.Nombre=nom;
            nuevo.Siguiente=cima;
            cima = nuevo;
            contador++;
        }
        public void mostrar (ListBox list) 
        {
            nodo 
        }
    }
}
