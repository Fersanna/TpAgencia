namespace Repaso
{
    public partial class PersonasForm : Form
    {
        PersonasFormModel model;

        public PersonasForm()
        {
            InitializeComponent();
        }

        private void PersonasForm_Load(object sender, EventArgs e)
        {
            model = new PersonasFormModel();

            foreach (var persona in model.Personas)
            {
                var item = new ListViewItem();
                item.Text = persona.Nombre.ToString();
                item.SubItems.Add(persona.Apellido);
                item.SubItems.Add(persona.Documento.ToString());
                item.SubItems.Add(persona.Telefono);
                item.Tag = persona;

                PersonaslistView.Items.Add(item);
            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            if (PersonaslistView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una fial", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Persona personaSeleccionada = (Persona)PersonaslistView.SelectedItems[0].Tag;

            ListaPersonasGroupBox.Enabled = false;
            EditgroupBox.Enabled = true;

            NombreTextBox.Text = personaSeleccionada.Nombre;
            ApellidoTextBox.Text = personaSeleccionada.Apellido;
            DocumentoTextBox.Text = personaSeleccionada.Documento.ToString();
            TelefonoTextBox.Text = personaSeleccionada.Telefono;



        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {

            if (PersonaslistView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una fial", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Persona personaAborrar = (Persona)PersonaslistView.SelectedItems[0].Tag;

            DialogResult result = MessageBox.Show($"Esta Seguro que desea borrar a {personaAborrar.Apellido + personaAborrar.Nombre}", "", MessageBoxButtons.YesNo);

            if (DialogResult.Yes == result)
            {
                var error = model.Borrar(personaAborrar);
                PersonaslistView.SelectedItems[0].Remove();

                if (error != null)
                {
                    MessageBox.Show(error, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }





        }

        private void NombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void ApellidoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {

            ListaPersonasGroupBox.Enabled = true;
            EditgroupBox.Enabled = false;

            NombreTextBox.Text = "";
            ApellidoTextBox.Text = "";
            DocumentoTextBox.Text = "";
            TelefonoTextBox.Text = "";
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            Persona personaNuevosDatos = new Persona();

            personaNuevosDatos.Nombre = NombreTextBox.Text;

            if (!int.TryParse(DocumentoTextBox.Text, out int documento))
            {
                MessageBox.Show("Debe ingresar un numero");

            }
        
            personaNuevosDatos.Documento = documento;

            personaNuevosDatos.Telefono= TelefonoTextBox.Text;
            personaNuevosDatos.Apellido=ApellidoTextBox.Text;

            Persona personaSeleccionada = new Persona();

            model.Modificar (personaNuevosDatos, personaSeleccionada);

            var item = new ListViewItem();

            item.Text = personaSeleccionada.Nombre.ToString();
            item.SubItems[0].Text =personaSeleccionada.Apellido;
            item.SubItems.Add(personaSeleccionada.Documento.ToString());
            item.SubItems.Add(personaSeleccionada.Telefono);
      

            
        }
    }
}