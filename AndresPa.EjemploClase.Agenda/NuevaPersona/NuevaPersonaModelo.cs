
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndresPa.EjemploClase.Agenda.NuevaPersona
{
    class NuevaPersonaModelo
    {
        internal string? NuevaPersona(Persona persona)
        {
            //validar TODO.

            //if(algo está mal)
            //{
            //  return "Mensaje de error";
            //}

            if (persona.Tratamiento != "Sr." && persona.Tratamiento != "Sra.")
            {
                return "El tratamiento no es válido";
            }

            if (string.IsNullOrWhiteSpace(persona.Apellido))
            {
                return "El apellido no puede estar vacío";
            }

            if (persona.Apellido.Length > 50)
            {
                return "El apellido no puede tener más de 50 caracteres";
            }

            if (string.IsNullOrWhiteSpace(persona.Nombre))
            {
                return "El nombre no puede estar vacío";
            }

            if (persona.Nombre.Length > 50)
            {
                return "El nombre no puede tener más de 50 caracteres";
            }

            if (persona.TipoDocumento != "DNI" || persona.TipoDocumento != "Pasaporte")
            {
                return "El tipo de documento debe ser DNI o Pasaporte";
            }

            if (persona.Documento < 1000000 || persona.Documento > 99999999)
            {
                return "El número de documento no es válido";
            }

            if (persona.FechaNacimiento > DateTime.Now)
            {
                return "La fecha de nacimiento no puede ser mayor a la fecha actual";
            }

            if (persona.FechaNacimiento < DateTime.Now.AddYears(-120))
            {
                return "La fecha de nacimiento no puede ser menor a 120 años atrás";
            }

            if (string.IsNullOrWhiteSpace(persona.Direccion))
            {
                return "La dirección no puede estar vacía";
            }

            if (persona.Telefono <10_000_000)
            {
                return "El telefono debe tener al menos 8 dígitos";
            }

            //este ejemplo es simple, pero hay veces
            //que para llegar al "if" tengo que hacer cuentas.


            //hacer lo que haiga que hacer para guardar la persona

            return null; //null indica que no hay errores.
        }

        //Esto está mal, y es un tiro en el pie:
        internal string? NuevaPersona(string apellido, string nombre, string etcétera) => throw new NotImplementedException();
    }
}
