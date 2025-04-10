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

    //Yo soy presentador
    public partial class NuevaPersonaForm : Form
    {
        private NuevaPersonaModelo modelo;

        public NuevaPersonaForm()
        {
            InitializeComponent();
        }

        private void NuevaPersona_Load(object sender, EventArgs e)
        {
            //Esto es lo primero que se ejecuta de "MI" funcionalidad.
            modelo = new NuevaPersonaModelo();



        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //Validar los minimo necesario para pasarle los datos
            //al modelo.

            //tomar los valores de los controles y realizar validaciones minimas.....
            var tratamiento = tratamientoCombo.SelectedValue.ToString();
            var apellido = apellidoText.Text;
            var nombre = nombreText.Text;
            var tipoDocumento = tipoDocCombo.SelectedValue.ToString();
            var numeroDocumento = numeroDocText.Text;

            if (!int.TryParse(numeroDocumento, out int numeroDocInteger))
            {
                MessageBox.Show("El número de documento no es un número");
                return;
            }

            var fechaNacimiento = fechaNacimientoText.Text;

            if (!DateTime.TryParse(fechaNacimiento, out DateTime fechaNacDateTime))
            {
                MessageBox.Show("La fecha de nacimiento no es una fecha válida");
                return;
            }

            var direccion = direccionText.Text;

            var telefono = telefonoText.Text;

            if (!long.TryParse(telefono, out long telefonoLong))
            {
                MessageBox.Show("El teléfono no es un número");
                return;
            }

            //para poder hacer esto: construir un objeto persona
            var persona = new Persona
            {
                Tratamiento = tratamiento,
                Apellido = apellido,
                Nombre = nombre,
                TipoDocumento = tipoDocumento,
                Documento = numeroDocInteger,
                FechaNacimiento = fechaNacDateTime,
                Direccion = direccion,
                Telefono = telefonoLong
            };

            //... y poder pasárselo al modelo, que realiza
            //el resto de las validaciones y devuelve un
            //mensaje de error si hace falta.
            var error = modelo.NuevaPersona(persona);

            if (error == null)
            {
                //todo bien, hacer algo. Cerrarse?
            }
            else
            {
                MessageBox.Show(error);
            }
        }
    }
}
