using System;
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
            Lista lista = new Lista("Alumnos");

            lista.InsertarPrimero("Chepe");
            lista.InsertarUltimo("Chepota");
            lista.InsertarUltimo("Chepote");
            lista.InsertarUltimo("Chepe Claudia");
            lista.InsertarUltimo("jord");
            Console.WriteLine(lista.BorrarUltimo() + " ha sido borrada de la lista.");
       
            Console.WriteLine(lista.BorrarPrimero() + " ha sido borrada de la lista.");
            lista.Imprimir();
            lista.ImprimirAtras();
        }
    }
}
