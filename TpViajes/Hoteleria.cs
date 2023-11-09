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
    public partial class Hoteleria : Form
    {
        public Hoteleria()
        {
            InitializeComponent();
        }

        private void hotelcontinuar_Click(object sender, EventArgs e)
        {
            Itinerario formulario = new Itinerario();
            formulario.Show();

        }
    }
}
