namespace TPagenciadeviajes
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Prereserva_Click(object sender, EventArgs e)
        {
            Prereserva formulario = new Prereserva();
            formulario.ShowDialog();
            this.Hide();
        }

        private void Itinerario_Click(object sender, EventArgs e)
        {
            Itinerario formulario = new Itinerario();
            formulario.Show();
            this.Hide();
        }

        private void Reserva_Click(object sender, EventArgs e)
        {
            Reserva formulario = new Reserva();
            formulario.Show();
            this.Hide();
        }
    }
}