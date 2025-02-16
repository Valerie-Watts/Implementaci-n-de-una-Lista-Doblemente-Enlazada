using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista("Alumnos"); //lista de alumnos
            

            lista.InsertarUltimo("Chepe");
            lista.InsertarUltimo("Chepota");
            lista.InsertarUltimo("Chepote");
            lista.InsertarUltimo("Chepe Claudia");
            lista.InsertarUltimo("jord");

            Console.WriteLine("Ingrese un elemento al final de la lista: "); //ingresar un nombre al final
            lista.InsertarUltimo(Console.ReadLine());

            Console.WriteLine("Ingrese un elemento al inicio de la lista: "); // ingresar un nombre al inicio
            lista.InsertarPrimero(Console.ReadLine());

            Console.WriteLine("La lista es circular? " + lista.Circular() + "\n");

            Console.WriteLine(lista.BorrarUltimo() + " ha sido borrada de la lista."); //borrar el ultimo de la lista
       
            Console.WriteLine(lista.BorrarPrimero() + " ha sido borrada de la lista."); // borrar el primero de la lista
            lista.Imprimir(); //recorrer la lista/imprimirla
            lista.ImprimirAtras(); //imprimirla al revés
        }
    }
}
