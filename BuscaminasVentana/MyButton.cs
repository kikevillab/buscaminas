using System.Windows.Forms;

namespace BuscaminasVentana
{
    internal class MyButton : Button
    {
        public int fil;
        public int col;

        public MyButton(int fil, int col)
        {
            this.fil = fil;
            this.col = col;
        }
    }
}