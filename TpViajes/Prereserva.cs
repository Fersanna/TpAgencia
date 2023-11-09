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
    public partial class Prereserva : Form
    {
        PersonasModel model;
        public Prereserva()
        {
            InitializeComponent();
        }

        private void Prereserva_Load(object sender, EventArgs e)
        {
            model = new PersonasModel();
            foreach (var nuevapersona in model.listapersonas)
            {
                var item = new ListViewItem();
                item.Text = nuevapersona.Nombre.ToString();
                item.SubItems.Add(nuevapersona.Apellido);
                item.SubItems.Add(nuevapersona.Apellido);
                item.SubItems.Add(nuevapersona.Edad);
                item.Tag = nuevapersona;

                PersonasListView.Items.Add(item);

            }

        }

        private void Cancelarprereserva_Click(object sender, EventArgs e)
        {
            Menu formulario = new Menu();
            formulario.Show();
            this.Hide();
        }
    }
}
