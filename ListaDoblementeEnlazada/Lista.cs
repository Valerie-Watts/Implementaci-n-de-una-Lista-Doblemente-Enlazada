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
        private Nodo primero; // Primer nodo de la lista
        private Nodo ultimo;  // Último nodo de la lista
        private string nombre; // Nombre de la lista

        // Constructor con nombre personalizado
        public Lista(string nombre)
        {
            this.nombre = nombre;
            primero = ultimo = null;
        }

        // Constructor sin parámetros, usa "Lista" como nombre por defecto
        public Lista()
        {
            nombre = "Lista";
            primero = ultimo = null;
        }

        // Constructor con un dato inicial, creando un nodo y haciendo la lista circular
        public Lista(object dato, string nombre)
        {
            this.nombre = nombre;
            primero = ultimo = new Nodo(dato);
            primero.Siguiente = primero; // Apunta a sí mismo, formando un ciclo
            primero.Anterior = primero;
        }

        // Verifica si la lista está vacía
        public bool estaVacia()
        {
            return primero == null;
        }

        // Verifica si la lista es circular
        public bool Circular()
        {
            if (estaVacia())
                return false;
            return ultimo.Siguiente == primero && primero.Anterior == ultimo;
        }

        // Inserta un elemento al final de la lista
        public void InsertarUltimo(object elemento)
        {
            if (estaVacia())
            {
                primero = ultimo = new Nodo(elemento);
                primero.Siguiente = primero; // Se conecta a sí mismo
                primero.Anterior = primero;
            }
            else
            {
                Nodo nuevo = new Nodo(elemento);
                nuevo.Anterior = ultimo;
                nuevo.Siguiente = primero; // Se conecta con el primero
                ultimo.Siguiente = nuevo;
                primero.Anterior = nuevo;
                ultimo = nuevo; // Nuevo nodo ahora es el último
            }
        }

        // Inserta un elemento al inicio de la lista
        public void InsertarPrimero(object elemento)
        {
            if (estaVacia())
            {
                primero = ultimo = new Nodo(elemento);
                primero.Anterior = primero;
                primero.Siguiente = primero;
            }
            else
            {
                Nodo nuevo = new Nodo(elemento);
                nuevo.Siguiente = primero;
                nuevo.Anterior = ultimo;
                primero.Anterior = nuevo;
                ultimo.Siguiente = nuevo;
                primero = nuevo; // Nuevo nodo ahora es el primero
            }
        }

        // Elimina y devuelve el primer elemento de la lista
        public object BorrarPrimero()
        {
            if (estaVacia())
            {
                throw new ListaVaciaExcepcion(nombre);
            }

            object ElementoBorrado = primero.Dato;

            if (primero == ultimo) // Si solo hay un elemento
            {
                primero = ultimo = null;
            }
            else
            {
                primero = primero.Siguiente;
                primero.Anterior = ultimo;
                ultimo.Siguiente = primero; // Mantiene la circularidad
            }
            return ElementoBorrado;
        }

        // Elimina y devuelve el último elemento de la lista
        public object BorrarUltimo()
        {
            if (estaVacia())
            {
                throw new ListaVaciaExcepcion(nombre);
            }

            object ElementoBorrado = ultimo.Dato;

            if (primero == ultimo) // Si solo hay un elemento
            {
                primero = ultimo = null;
            }
            else
            {
                ultimo = ultimo.Anterior;
                ultimo.Siguiente = primero;
                primero.Anterior = ultimo; // Mantiene la circularidad
            }
            return ElementoBorrado;
        }

        // Imprime la lista desde el primer nodo en adelante
        public void Imprimir()
        {
            if (estaVacia())
            {
                Console.WriteLine("La lista " + nombre + " esta vacía.");
                return;
            }

            Console.WriteLine("Lista " + nombre);

            Nodo actual = primero;

            do
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Siguiente;
            } while (actual != primero); // Se detiene al volver al inicio

            Console.WriteLine("\n");
        }

        // Imprime la lista desde el último nodo hacia atrás
        public void ImprimirAtras()
        {
            if (estaVacia())
            {
                Console.WriteLine("La lista " + nombre + " esta vacía.");
                return;
            }
            Console.WriteLine("Lista " + nombre);

            Nodo actual = ultimo;

            do
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Anterior;
            } while (actual != ultimo); // Se detiene al volver al final

            Console.WriteLine("\n");
        }

    }
}
