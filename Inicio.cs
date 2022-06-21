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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        //Construtor para pasar del primero formulario al segundo
        private void botonEmpezar_Click(object sender, EventArgs e)
        {
            using (Tablero ventanaTablero = new Tablero(Jugador1.Text, Jugador2.Text))
                ventanaTablero.ShowDialog();
           

        }

        private void jugador1(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            botonEmpezar.Enabled = false;
        }
        //Metodo para inabilitar el boton de "EMPEZAR" cuando no se han llenado correctamente los campos
        private void controlBotones()
        {
            if(Jugador1.Text.Trim()!= string.Empty && Jugador1.Text.All(Char.IsLetter))
            {
                botonEmpezar.Enabled = true;
                errorProvider1.SetError(Jugador1, "");
            }
            else
            {
                if (!(Jugador1.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(Jugador1, "El nombre solo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(Jugador1, "Debe introducir su nombre");
                }
                botonEmpezar.Enabled = false;
                Jugador1.Focus();
            }
            if (Jugador2.Text.Trim() != string.Empty && Jugador1.Text.All(Char.IsLetter))
            {
                botonEmpezar.Enabled = true;
                errorProvider1.SetError(Jugador2, "");
            }
            else
            {
                if (!(Jugador2.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(Jugador2, "El nombre solo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(Jugador2, "Debe introducir su nombre");
                }
                botonEmpezar.Enabled = false;
                Jugador2.Focus();
            }
        }
        private void Jugador1_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void Jugador2_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void botonEmpezar_Click_1(object sender, EventArgs e)
        {
            String name1 = Jugador1.Text;
            String name2 = Jugador2.Text;
            Tablero m = new Tablero();
            m.Show();
        }
    }
}
