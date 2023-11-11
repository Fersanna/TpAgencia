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
       

        public VuelosForm()
        {
            InitializeComponent();
            
           


        }


        private void VuelosListView_MouseClick(object sender, MouseEventArgs e)
        {
                if (VuelosListView.SelectedItems.Count>0)
            {    
                //Seleccionamos la Row del vuelo elegido
                ListViewItem selectedItem = VuelosListView.SelectedItems[0];

                if (selectedItem != null && selectedItem.SubItems != null)
                {
                    // Asegúrate de que la columna "Codigo" exista antes de intentar acceder a ella
                    if (selectedItem.SubItems.ContainsKey("Codigo"))
                    {
                        string vueloCodigo = selectedItem.SubItems["Codigo"].Text;
                        model.AgregarVuelosAlItinerario(vueloCodigo);
                        MessageBox.Show("Se ha añadido correctamente el vuelo al presupuesto.");
                    }
                }

            else
            {
                MessageBox.Show("Por favor, seleccione un hotel para agregar al presupuesto.");
            }

        }
                
        }



            private void Vuelos_Load(object sender, EventArgs e)
            {
                model = new VuelosModel();
               OrigenVuelosComboBox.SelectedIndex = 0;
               DestinoVuelosComboBox.SelectedIndex = 0;
   
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






