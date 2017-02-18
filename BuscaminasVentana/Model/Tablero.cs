using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasVentana.Model
{
    class Tablero
    {
        private int fils;
        private int cols;
        private Casilla[,] casillas;
        private int porcentajeBombas;

        private bool bombaEncontrada;
        private int numeroBombas;
        private int v;

        public Tablero(int fils, int cols)
        {
            this.fils = fils + 2;
            this.cols = cols + 2;
            this.porcentajeBombas = 20;
        }

        public Tablero(int fils, int cols, int porcentaje) : this(fils, cols)
        {
            porcentajeBombas = porcentaje;
            InicializarTablero();
        }

        public void InicializarTablero()
        {
            casillas = new Casilla[this.fils, this.cols];
            for (int f = 0; f < this.fils; f++)
                for (int c = 0; c < this.cols; c++)
                    casillas[f, c] = new Casilla();

            InicializarBombas();
            RellenarBorde();
        }

        private void RellenarBorde()
        {
            for (int i = 0; i < cols; i++)
            {
                casillas[0, i].SumarUno();
                casillas[fils-1, i].SumarUno();
            }
                
            for (int i = 0; i < fils; i++)
            {
                casillas[i, 0].SumarUno();
                casillas[i, cols-1].SumarUno();
            }
                
        }

        private void InicializarBombas()
        {
            Random rnd = new Random();
            for (int f = 1; f < fils-1; f++)
                for (int c = 1; c < cols-1; c++)
                    if(rnd.Next(100) < porcentajeBombas)
                    {
                        casillas[f, c].ponerBomba();
                        SumaUnosAlrededor(f, c);
                        numeroBombas++;
                    }
        }

        internal bool BombaEncontrada()
        {
            return bombaEncontrada;
        }

        internal bool SoloBombas()
        {
            return numeroBombas == (fils - 2) * (cols - 2);
        }

        private void SumaUnosAlrededor(int f, int c)
        {
            for (int i = f - 1; i <= f + 1; i++)
                for (int j = c - 1; j <= c + 1; j++)
                    casillas[i, j].SumarUno();
        }

        internal bool esBomba(int fil, int col)
        {
            return casillas[fil, col].esBomba();
        }

        internal void Levantar(int fila, int columna)
        {
            if(!casillas[fila, columna].Levantada())
            {
                casillas[fila, columna].Levantar();
                if (casillas[fila, columna].esVacia())
                {
                    for (int i = fila - 1; i <= fila + 1; i++)
                        for (int j = columna - 1; j <= columna + 1; j++)
                            Levantar(i, j);
                }
                else if (casillas[fila, columna].esBomba())
                {
                    bombaEncontrada = true;
                }
            }
            
        }

        internal string casilla(int fil, int col)
        {
            return casillas[fil, col].ToString();
        }

        internal bool casillaLevantada(int fil, int col)
        {
            return casillas[fil, col].Levantada();
        }

        public override string ToString()
        {
            string msg = "";
            for (int f = 1; f < fils - 1; f++)
            {
                for (int c = 1; c < cols - 1; c++)
                    msg += casillas[f, c] + " ";

                msg += "\n";
            }
                
            return msg;
        }
    }
}
