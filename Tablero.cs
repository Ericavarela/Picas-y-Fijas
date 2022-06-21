using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picas_y_Fijas
{
    public partial class Tablero : Form
    {
        string nombreJugador1;
        string nombreJugador2;

        public Tablero()
        {
        }

        public Tablero(string jugador1, string jugador2)
        {
            InitializeComponent();
            nombreJugador1 = jugador1;
            nombreJugador2 = jugador2;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
