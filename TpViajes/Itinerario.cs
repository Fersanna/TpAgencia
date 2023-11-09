using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPagenciadeviajes
{
    public partial class Itinerario : Form
    {
        public ListView ListView1 { get; set; }

        public Itinerario(Vuelos vueloSeleccionado)
        {
            InitializeComponent();
            ListView1 = new ListView();
            // Crea un nuevo ListViewItem con los datos obtenidos
            ListViewItem listItem = new ListViewItem(new[] {
            vueloSeleccionado.Asiento,
            vueloSeleccionado.Origen,
            vueloSeleccionado.Destino,
            vueloSeleccionado.FechaSalida.ToLongDateString(),
            vueloSeleccionado.FechaLlegada.ToLongDateString(),
            vueloSeleccionado.Clase,
            vueloSeleccionado.Pasajeros.ToString(),
            vueloSeleccionado.Precio,
            vueloSeleccionado.Codigo
        });

            // Agregar el ListViewItem a la lista de ListView1
            ListView1.Items.Add(listItem);

        }

        private void Itinerario_Load(object sender, EventArgs e)
        {
       
        }

        private void Cancerlarreserva_Click(object sender, EventArgs e)
        {
            Menu formulario = new Menu();
            formulario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VuelosForm formulario = new VuelosForm();
            formulario.Show();
            this.Hide();
        }
    }
}
