using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("El Gran Juego de las Torres de Hanoi");
            Console.WriteLine("3 Torres");
            Pila Aux = new Pila();
            Pila Fin = new Pila();
            // Keep the console window open in debug mode.
            Console.WriteLine("Escribe el numero de discos que hay en la primera pila");
            int discos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Has seleccionado " + discos + " discos");
            Pila Ini = new Pila(discos);
            Hanoi hanoi = new Hanoi();
            int movimientos = hanoi.iterativo(discos, Ini, Fin, Aux);
            Console.WriteLine("Completado en "+movimientos+" movimientos");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
