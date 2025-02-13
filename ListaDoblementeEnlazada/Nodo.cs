using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEjemplo
{
    internal class Nodo
    {
        private object dato;
        private Nodo siguiente;
        private Nodo anterior;

        public Nodo(object dato, Nodo siguiente, Nodo anterior)
        {
            Dato = dato;            
            Siguiente = siguiente;
            Anterior = anterior; 
        }

        public Nodo(object dato)
        {
            this.dato = dato;
            this.siguiente = null;
            this.anterior = null;
        }

        public Nodo()
        {
            this.dato = "";
            this.siguiente = null;
            this.anterior = null;
        }

        public object GetDato()
        {
            return this.dato;
        }

        public void SetDato(object dato)
        {
            this.dato = dato;
        }

        public object Dato
        {
            get { return this.dato; }
            set { this.dato = value; }

        }

        public Nodo Siguiente
        { 
            get { return this.siguiente; }
            set { this.siguiente = value; }
            
        }
        public Nodo Anterior
        {
            get { return this.anterior; }
            set { this.anterior = value; }

        }
    }
}
