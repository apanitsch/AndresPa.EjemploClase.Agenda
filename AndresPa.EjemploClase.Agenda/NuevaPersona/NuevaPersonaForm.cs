using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndresPa.EjemploClase.Agenda.NuevaPersona
{

    //Yo soy el "presentador"
    public partial class NuevaPersonaForm : Form
    {
        private NuevaPersonaModelo modelo;
        private int personaEnEdicionId;

        public NuevaPersonaForm()
        {
            InitializeComponent();
        }

        private void NuevaPersona_Load(object sender, EventArgs e)
        {
            //Esto es lo primero que se ejecuta de "MI" funcionalidad.
            modelo = new NuevaPersonaModelo();
            ActualizarLista();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //Validar los minimo necesario para pasarle los datos
            //al modelo.

            if (!int.TryParse(numeroDocText.Text, out int numeroDocInteger))
            {
                MessageBox.Show("El número de documento no es un número");
                return;
            }

            if (!DateTime.TryParse(fechaNacimientoText.Text, out DateTime fechaNacDateTime))
            {
                MessageBox.Show("La fecha de nacimiento no es una fecha válida");
                return;
            }

            if (!long.TryParse(telefonoText.Text, out long telefonoLong))
            {
                MessageBox.Show("El teléfono no es un número");
                return;
            }

            //... y poder pasárselo al modelo, que realiza
            //el resto de las validaciones y devuelve un
            //mensaje de error si hace falta.
            string error;

            var persona = new Persona
            {
                Tratamiento = tratamientoCombo.SelectedValue?.ToString() ?? string.Empty,
                Apellido = apellidoText.Text,
                Nombre = nombreText.Text,
                TipoDocumento = tipoDocCombo.SelectedValue?.ToString() ?? string.Empty,
                Documento = numeroDocInteger,
                FechaNacimiento = fechaNacDateTime,
                Direccion = direccionText.Text,
                Telefono = telefonoLong
            };

            if (personaEnEdicionId == 0) //si estoy dando de alta (lo puse en el boton "nueva")
            {
                error = modelo.NuevaPersona(persona);
            }
            else //si estoy modificando (lo puse en el boton "modificar")
            {
                persona.Id = personaEnEdicionId;
                error = modelo.ModificarPersona(persona);
            }

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            //hay que actualizar la lista.
            ActualizarLista();
        }

        private void nuevaButton_Click(object sender, EventArgs e)
        {
            personaEnEdicionId = 0; //no hay persona en edicion.

            filtrosGroup.Enabled = false;
            personasList.Enabled = false;
            nuevaButton.Enabled = false;
            borrarButton.Enabled = false;
            modificarButton.Enabled = false;
            edicionGroup.Enabled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            filtrosGroup.Enabled = true;
            personasList.Enabled = true;
            nuevaButton.Enabled = true;
            borrarButton.Enabled = true;
            modificarButton.Enabled = true;
            edicionGroup.Enabled = false;
        }

        private void ActualizarLista()
        {
            //Limpiar la lista de personas
            personasList.Items.Clear();

            foreach (var persona in modelo.Personas)
            {
                ListViewItem personaItem = new ListViewItem();
                personaItem.Text = $"{persona.TipoDocumento} {persona.Documento}"; //1er columna
                personaItem.SubItems.Add(persona.Nombre); //2da columna (1er subitem)
                personaItem.SubItems.Add(persona.Apellido); //3ra columna (2do subitem)
                personaItem.Tag = persona.Id; //guardar algun tipo de referencia (Id, documento, numero de...)

                personasList.Items.Add(personaItem);
            }
        }

        private void borrarButton_Click(object sender, EventArgs e)
        {
            if (personasList.SelectedItems.Count == 0)
            {
                MessageBox.Show("No hay ninguna persona seleccionada");
                return;
            }

            var personaSeleccionadaId = (int)personasList.SelectedItems[0].Tag;

            var error = modelo.Borrar(personaSeleccionadaId);

            if (error != null) //si hay un error.
            {
                MessageBox.Show(error);
                return;
            }

            //Actualizar la lista de personas.
            ActualizarLista();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            if (personasList.SelectedItems.Count == 0)
            {
                MessageBox.Show("No hay ninguna persona seleccionada");
                return;
            }

            personaEnEdicionId = (int)personasList.SelectedItems[0].Tag;

            var persona = modelo.ObtenerPersona(personaEnEdicionId);

            //cargar los de la persona en los controles.
            tratamientoCombo.SelectedValue = persona.Tratamiento;
            nombreText.Text = persona.Nombre;
            apellidoText.Text = persona.Apellido;
            tipoDocCombo.SelectedValue = persona.TipoDocumento;
            numeroDocText.Text = persona.Documento.ToString();
            fechaNacimientoText.Text = persona.FechaNacimiento.ToString("yyyy-MM-dd");
            direccionText.Text = persona.Direccion;
            telefonoText.Text = persona.Telefono.ToString();

            filtrosGroup.Enabled = false;
            personasList.Enabled = false;
            nuevaButton.Enabled = false;
            borrarButton.Enabled = false;
            modificarButton.Enabled = false;
            edicionGroup.Enabled = true;
        }
    }
}
