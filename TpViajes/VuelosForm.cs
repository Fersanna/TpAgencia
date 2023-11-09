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
    public partial class VuelosForm : Form
    {
        VuelosModel model;
        public ListView ListView1 { get; set; }


        public VuelosForm()
        {
            InitializeComponent();
            OrigenVuelosComboBox.SelectedIndex = 0;
            DestinoVuelosComboBox.SelectedIndex = 0;
            VuelosListView.MouseClick += VuelosListView_MouseClick;


        }


        private void VuelosListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ListViewItem selectedItem = VuelosListView.HitTest(e.Location).Item;

                if (selectedItem != null)
                {
                    // Obtén los datos de la fila seleccionada y crea un objeto Vuelos
                    Vuelos vueloSeleccionado = new Vuelos
                    {
                        Asiento = selectedItem.SubItems[0].Text,
                        Origen = selectedItem.SubItems[1].Text,
                        Destino = selectedItem.SubItems[2].Text,
                        FechaSalida = DateTime.Parse(selectedItem.SubItems[3].Text),
                        FechaLlegada = DateTime.Parse(selectedItem.SubItems[4].Text),
                        Clase = selectedItem.SubItems[5].Text,
                        Pasajeros = selectedItem.SubItems[6].Text,
                        Precio = selectedItem.SubItems[7].Text,
                        Codigo = selectedItem.SubItems[8].Text,
                        // Asigna otros valores según tus necesidades
                    };

                    // Crea una instancia de Itinerario y pasa el objeto Vuelos
                    Itinerario itinerarioForm = new Itinerario(vueloSeleccionado);

                    // Muestra el formulario Itinerario
                    itinerarioForm.Show();
                    this.Hide();
                }
            }



            private void Vuelos_Load(object sender, EventArgs e)
            {
                model = new VuelosModel();

                if (VuelosListView != null)
                {
                    foreach (var item in model.vuelosDiponibles)
                    {
                        var items = new ListViewItem();
                        items.Text = item.Asiento;
                        items.SubItems.Add(item.Origen.ToString());
                        items.SubItems.Add(item.Destino.ToString());
                        items.SubItems.Add(item.FechaSalida.ToLongDateString());
                        items.SubItems.Add(item.FechaLlegada.ToLongDateString());
                        items.SubItems.Add(item.Pasajeros.ToString());
                        items.SubItems.Add(item.Clase.ToString());
                        items.SubItems.Add(item.Precio);
                        items.SubItems.Add(item.Codigo);

                        items.Tag = item;

                        VuelosListView.Items.Add(items);

                    }
                }

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void VuelosOrigen_SelectedIndexChanged(object sender, EventArgs e)
            {


            }

            private void radioButton4_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void Buscarvuelo_Click(object sender, EventArgs e)
            {
                // Obtén las clases seleccionadas
                var clasesSeleccionadas = ClasescheckedListBox.CheckedItems.Cast<string>().ToList();

                // Si no se ha seleccionado ninguna clase, mostrar un mensaje al usuario
                if (clasesSeleccionadas.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione al menos una clase antes de buscar vuelos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtén el origen y destino seleccionados
                string origenSeleccionado = OrigenVuelosComboBox.SelectedItem.ToString();
                string destinoSeleccionado = DestinoVuelosComboBox.SelectedItem.ToString();
                DateTime fechaSalida = FechaSalidaPicker.Value.Date;
                DateTime fechaLlegada = FechaLlegadaPicker.Value.Date;
                // Filtra los vuelos según las clases seleccionadas, origen y destino
                var vuelosFiltrados = model.vuelosDiponibles
                    .Where(v =>
                        (clasesSeleccionadas.Count == 0 || clasesSeleccionadas.Contains(v.Clase)) &&
                        (string.IsNullOrEmpty(origenSeleccionado) || v.Origen == origenSeleccionado) &&
                        (string.IsNullOrEmpty(destinoSeleccionado) || v.Destino == destinoSeleccionado) &&
                        v.FechaSalida.Date.Equals(fechaSalida) &&
                        v.FechaLlegada.Date.Equals(fechaLlegada)

                    )
                    .ToList();
                // Limpia los elementos existentes en VuelosListView
                VuelosListView.Items.Clear();

                // Agrega los vuelos filtrados al VuelosListView
                foreach (var vuelos in vuelosFiltrados)
                {
                    var listItem = new ListViewItem();
                    listItem.Text = vuelos.Asiento;
                    listItem.SubItems.Add(vuelos.Origen.ToString());
                    listItem.SubItems.Add(vuelos.Destino.ToString());
                    listItem.SubItems.Add(vuelos.FechaSalida.ToLongDateString());
                    listItem.SubItems.Add(vuelos.FechaLlegada.ToLongDateString());
                    listItem.SubItems.Add(vuelos.Clase.ToString());
                    listItem.SubItems.Add(vuelos.Pasajeros.ToString());
                    listItem.SubItems.Add(vuelos.Precio);
                    listItem.SubItems.Add(vuelos.Codigo);

                    VuelosListView.Items.Add(listItem);
                }
            }

            private void groupBox2_Enter(object sender, EventArgs e)
            {

            }

            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            {

            }

            private void CancelarBtn_Click(object sender, EventArgs e)
            {
                VuelosListView.Items.Clear();

                foreach (var item in model.vuelosDiponibles)
                {
                    var items = new ListViewItem();
                    items.Text = item.Asiento;
                    items.SubItems.Add(item.Origen.ToString());
                    items.SubItems.Add(item.Destino.ToString());
                    items.SubItems.Add(item.FechaSalida.ToLongDateString());
                    items.SubItems.Add(item.FechaLlegada.ToLongDateString());
                    items.SubItems.Add(item.Pasajeros.ToString());
                    items.SubItems.Add(item.Clase.ToString());
                    items.SubItems.Add(item.Precio);
                    items.SubItems.Add(item.Codigo);

                    items.Tag = item;

                    VuelosListView.Items.Add(items);

                }
            }
        }
    } 
}





