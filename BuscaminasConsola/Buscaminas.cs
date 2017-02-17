using BuscaminasConsola.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasConsola
{
    class Buscaminas
    {
        static void Main(string[] args)
        {
            new Buscaminas().run();
        }

        private Tablero tablero;

        public Buscaminas()
        {
            tablero = new Tablero(5, 5);
        }

        private void run()
        {
            
            while(!JuegoFinalizado())
            {
                //visualiza tablero
                Console.WriteLine(tablero);
                //lee fila
                Console.WriteLine("Introduce la fila: ");
                int fila = Convert.ToInt32(Console.ReadLine());
                //lee col
                Console.WriteLine("Introduce la columna: ");
                int columna = Convert.ToInt32(Console.ReadLine());
                //levanta casilla (fill, col)
                
                tablero.Levantar(fila, columna);
                //fin while
            }
            //while
            Console.WriteLine(tablero);
            if (tablero.BombaEncontrada())
                Console.WriteLine("FAIL!");
            else if (tablero.SoloBombas())
                Console.WriteLine("Winner!");

            Console.Read();
        }

        private bool JuegoFinalizado()
        {
            return tablero.BombaEncontrada() || tablero.SoloBombas();
        }
    }
}
