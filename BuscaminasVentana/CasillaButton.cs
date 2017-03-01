using System.Windows.Forms;

namespace BuscaminasVentana
{
    internal class CasillaButton : Button
    {
        public int fil;
        public int col;

        public CasillaButton(int fil, int col)
        {
            this.fil = fil;
            this.col = col;
            this.pintarVacio();
            this.Width = this.Height ;
        }

        public void pintarBomba()
        {
            this.Image = global::BuscaminasVentana.Properties.Resources.bomba;
        }

        public void pintarCasilla(string valor)
        {
            this.Text = valor;
            this.Image = global::BuscaminasVentana.Properties.Resources.empty;
        }

        public void pintarVacio()
        {
            this.BackColor = System.Drawing.Color.DarkGray;
        }
    }
}