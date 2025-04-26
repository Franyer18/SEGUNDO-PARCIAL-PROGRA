using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Forms
{
    public partial class TXTNOMBRE : Form
    {
        private TextBox txtNombre;
        private TextBox txtEdad;
        private List<Jugador> jugadores = new List<Jugador>();

        public TXTNOMBRE()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("Por favor, ingrese una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            jugadores.Add(new Jugador { Nombre = nombre, Edad = edad });
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            // Lógica para actualizar el DataGridView
        }

        private void textNOMBRE_TextChanged(object sender, EventArgs e)
        {
            // Lógica para manejar el evento TextChanged
        }
    }

    public class Jugador
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}


