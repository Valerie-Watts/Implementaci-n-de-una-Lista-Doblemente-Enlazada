using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ListasEjemplo
{
    internal class Lista //yeah
    {
        private Nodo primero;
        private Nodo ultimo;
        private string nombre;

        public Lista(string nombre)
        {
            this.nombre = nombre;
            primero = ultimo= null;
        }

        public Lista()
        {
            nombre = "Lista";
            primero = ultimo= null;
        }

        public Lista(object dato, string nombre)
        {
            this.nombre = nombre;
            primero = ultimo = new Nodo(dato);
        }

        public bool estaVacia()
        {
            return primero == null;
        }

        public void InsertarUltimo(object elemento)
        {
            if (estaVacia())
            {
                primero=ultimo=new Nodo(elemento);
            }
            else
            {
                Nodo nuevo = new Nodo(elemento);
                nuevo.Anterior = ultimo;
                ultimo.Siguiente = nuevo;
                ultimo = nuevo; 
            }
        }

        public void InsertarPrimero(object elemento)
        {
            if (estaVacia())
            {
                primero = ultimo= new Nodo(elemento);
            }
            else
            {
                Nodo nuevo = new Nodo(elemento);
                nuevo.Siguiente = primero;
                primero.Anterior = nuevo;
                primero = nuevo;
            }
        }

        public object BorrarPrimero()
        {
            if(estaVacia())
            {
                throw new ListaVaciaExcepcion(nombre);
            }

            object ElementoBorrado = primero.Dato;

            if (primero == ultimo)
            {
                primero = ultimo = null;
            }
            else
            {
                primero = primero.Siguiente;
                primero.Anterior = null; 
            }
            return ElementoBorrado;
        }

        public object BorrarUltimo()
        {
            if (estaVacia())
            {
                throw new ListaVaciaExcepcion(nombre);
            }

            object ElementoBorrado = ultimo.Dato;
            
            if (primero == ultimo)
            {
                primero = ultimo = null;
            }
            else
            {
                ultimo = ultimo.Anterior;
                ultimo.Siguiente = null; 
            }
            return ElementoBorrado;

        }

        public void Imprimir()
        {
            if (estaVacia())
            {
                Console.WriteLine("La lista " + nombre + " esta vacía.");
                return;
            }

            Console.WriteLine("Lista " + nombre);

            Nodo actual = primero;

            while (actual != null)
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Siguiente;             
            }
            
           
            Console.WriteLine("\n");
        }

        public void ImprimirAtras()
        {
            if (estaVacia())
            {
                Console.WriteLine("La lista " + nombre + " esta vacía.");
                return;
            }
            Console.WriteLine("Lista " + nombre);

            Nodo actual = ultimo;

            while (actual != null)
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Anterior; 
            }

            Console.WriteLine("\n");
        }

    }
}
