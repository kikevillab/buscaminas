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
    public partial class Form1 : Form
    {
        private Tablero tablero;
        private int filas;
        private int columnas;
        private int dificultad;
        private Button[,] buttons;

        public Form1()
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
                    this.filas = 20;
                    this.columnas = 20;
                    this.dificultad = 40;
                    break;
                case "A":
                    this.filas = 50;
                    this.columnas = 50;
                    this.dificultad = 60;
                    break;                    
            }

            //MessageBox.Show("F" + filas + "C" + columnas + "D" + dificultad);
            InicializarJuego();
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
                    buttons[i, j] = new MyButton(i+1, j+1);
                    buttons[i, j].Image = global::BuscaminasVentana.Properties.Resources.empty;
                    buttons[i, j].Click += new EventHandler(Click_button);
                    buscaminasTableLayout.Controls.Add(buttons[i, j]);

                }
        }

        private void Click_button(object sender, EventArgs e)
        {
            MyButton button = (MyButton)sender;
            tablero.Levantar(button.fil, button.col);
            if (tablero.esBomba(button.fil, button.col))
            {
                buttons[button.fil-1, button.col-1].Image = global::BuscaminasVentana.Properties.Resources.bomba;
                MessageBox.Show("Has perdido");
                InicializarJuego();
            }
            ActualizarTablero();

        }

        private void ActualizarTablero()
        {
            foreach(MyButton btn in buttons)
            {
                pintarCasilla(btn.fil, btn.col);
            }
        }

        private void pintarCasilla(int fil, int col)
        {
            if(tablero.casillaLevantada(fil, col))
            {
                buttons[fil-1, col-1].Text = tablero.casilla(fil, col);
            }
        }
    }
}
