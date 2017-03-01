using BuscaminasVentana.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaminasVentana
{
    public partial class Buscaminas : Form
    {
        private Tablero tablero;
        private int filas;
        private int columnas;
        private int dificultad;
        private Button[,] buttons;
        private int puntuacion;

        public Buscaminas()
        {
            InitializeComponent();
        }

        private void handleGame(object sender, EventArgs e)
        {
            //MessageBox.Show("hola");
            switch(((RadioButton)sender).Tag.ToString())
            {
                case "B":
                    this.filas = 5;
                    this.columnas = 5;
                    this.dificultad = 20;
                    break;
                case "M":
                    this.filas = 10;
                    this.columnas = 10;
                    this.dificultad = 40;
                    break;
                case "A":
                    this.filas = 20;
                    this.columnas = 20;
                    this.dificultad = 60;
                    break;                    
            }

            //MessageBox.Show("F" + filas + "C" + columnas + "D" + dificultad);
            RemoveAllButtons();
            InicializarJuego();
        }

        private void RemoveAllButtons()
        {
            buscaminasTableLayout.Controls.Clear();
        }

        private void InicializarJuego()
        {
            tablero = new Tablero(this.filas, this.columnas, this.dificultad);
            buscaminasTableLayout.RowCount = this.filas;
            buscaminasTableLayout.ColumnCount = this.columnas;
            buttons = new Button[this.filas, this.columnas];
            for(int i=0; i <this.filas; i++)
                for(int j=0; j<this.columnas; j++)
                {
                    buttons[i, j] = new CasillaButton(i + 1, j + 1);
                    buttons[i, j].Click += new EventHandler(LevantarCasilla);
                    buscaminasTableLayout.Controls.Add(buttons[i, j]);

                }

            puntuacion = 0;
            lbl_puntuacionValor.Text = puntuacion+"";

        }

        private void LevantarCasilla(object sender, EventArgs e)
        {
            CasillaButton button = (CasillaButton)sender;
            tablero.Levantar(button.fil, button.col);
            if (tablero.esBomba(button.fil, button.col))
            {
                MostrarTablero();
                MessageBox.Show("Has perdido");
                buscaminasEntities ctx = new buscaminasEntities();
                ctx.Puntuaciones.Add(new Puntuacione(puntuacion, "perdedor"));
                ctx.SaveChanges();                                
            }
            puntuacion++;
            ActualizarTablero();
            if (tablero.SoloBombas())
            {
                MessageBox.Show("Has ganado");
                buscaminasEntities ctx = new buscaminasEntities();
                ctx.Puntuaciones.Add(new Puntuacione(puntuacion, "ganador"));
                ctx.SaveChanges();
            }

        }

        private void ReiniciarJuego()
        {
            tablero = new Tablero(this.filas, this.columnas, this.dificultad);
            puntuacion = 0;
            ActualizarTablero();
        }

        private void ActualizarTablero()
        {
            foreach(CasillaButton btn in buttons)
            {
                pintarCasilla(btn);
            }

            lbl_puntuacionValor.Text = puntuacion + "";
        }

        private void MostrarTablero()
        {
            foreach (CasillaButton btn in buttons)
            {
                tablero.Levantar(btn.fil, btn.col);
                pintarCasilla(btn);
            }
        }

        private void pintarCasilla(CasillaButton casilla)
        {
            if(tablero.casillaLevantada(casilla.fil, casilla.col))
            {
                if (tablero.esBomba(casilla.fil, casilla.col))
                    casilla.pintarBomba();
                else
                    casilla.pintarCasilla(tablero.casilla(casilla.fil, casilla.col));
            }
            else
            {
                casilla.pintarVacio();
            }
        }
    }
}
