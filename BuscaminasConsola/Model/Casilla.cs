using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasConsola.Model
{
    class Casilla
    {
        private bool bomba;

        private int valor;

        private bool levantada;

        internal Casilla()
        {
            levantada = false;
            valor = 0;
            bomba = false;
        }

        internal void Levantar()
        {
            levantada = true;
        }

        internal void ponerBomba()
        {
            bomba = true;
        }

        internal void SumarUno()
        {
            valor++;
        }

        public override string ToString()
        {
            if (!levantada) return "X";
            else if (bomba) return "B";
            else if (valor > 0) return "" + valor;
            else return "-";
        }

        internal bool esVacia()
        {
            return valor == 0;
        }

        internal bool esBomba()
        {
            return bomba;
        }

        internal bool Levantada()
        {
            return levantada;
        }
    }
}
