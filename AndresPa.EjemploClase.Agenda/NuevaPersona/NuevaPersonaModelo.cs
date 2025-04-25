
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndresPa.EjemploClase.Agenda.NuevaPersona
{
    class NuevaPersonaModelo
    {
        public List<Persona> Personas { get; } = new List<Persona>
        {
            new Persona { Id=1, Apellido = "Martinez", Nombre = "Lucia", Documento = 23456789, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1985, 5, 10), Direccion = "Av. Siempreviva 742", Telefono = 1123456789 },
            new Persona { Id=2, Apellido = "Rodriguez", Nombre = "Carlos", Documento = 34567890, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1978, 11, 23), Direccion = "Calle 9 de Julio 100", Telefono = 1167891234 },
            new Persona { Id=3, Apellido = "Lopez", Nombre = "Ana", Documento = 45678901, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1992, 3, 15), Direccion = "Mitre 456", Telefono = 1145678901 },
            new Persona { Id=4, Apellido = "Fernandez", Nombre = "Jorge", Documento = 56789012, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1980, 7, 8), Direccion = "Belgrano 789", Telefono = 1134567890 },
            new Persona { Id=5, Apellido = "Perez", Nombre = "Laura", Documento = 67890123, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1995, 9, 30), Direccion = "San Martin 321", Telefono = 1156789012 },
            new Persona { Id=6, Apellido = "Gomez", Nombre = "Mariano", Documento = 78901234, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1988, 2, 19), Direccion = "Lavalle 654", Telefono = 1178901234 },
            new Persona { Id=7, Apellido = "Diaz", Nombre = "Valeria", Documento = 89012345, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1993, 4, 21), Direccion = "Rivadavia 987", Telefono = 1190123456 },
            new Persona { Id=8, Apellido = "Sanchez", Nombre = "Luis", Documento = 90123456, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1975, 6, 5), Direccion = "Alsina 159", Telefono = 1101234567 },
            new Persona { Id=9, Apellido = "Ramirez", Nombre = "Paula", Documento = 10234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1987, 12, 12), Direccion = "Moreno 753", Telefono = 1112345678 },
            new Persona { Id=10, Apellido = "Torres", Nombre = "Hernan", Documento = 11234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1991, 1, 17), Direccion = "Urquiza 888", Telefono = 1123456780 },
            new Persona { Id=11, Apellido = "Silva", Nombre = "Camila", Documento = 12234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1989, 10, 9), Direccion = "Francia 555", Telefono = 1134567891 },
            new Persona { Id=12, Apellido = "Alvarez", Nombre = "Federico", Documento = 13234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1996, 8, 26), Direccion = "Italia 333", Telefono = 1145678902 },
            new Persona { Id=13, Apellido = "Romero", Nombre = "Natalia", Documento = 14234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1982, 9, 2), Direccion = "España 111", Telefono = 1156789013 },
            new Persona { Id=14, Apellido = "Molina", Nombre = "Sergio", Documento = 15234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1994, 7, 14), Direccion = "Portugal 789", Telefono = 1167890123 },
            new Persona { Id=15, Apellido = "Acosta", Nombre = "Juliana", Documento = 16234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1990, 6, 11), Direccion = "Brasil 246", Telefono = 1178901235 },
            new Persona { Id=16, Apellido = "Medina", Nombre = "Esteban", Documento = 17234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1983, 5, 20), Direccion = "Chile 357", Telefono = 1189012345 },
            new Persona { Id=17, Apellido = "Castro", Nombre = "Noelia", Documento = 18234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1986, 3, 3), Direccion = "Bolivia 468", Telefono = 1190123457 },
            new Persona { Id=18, Apellido = "Ortiz", Nombre = "Martin", Documento = 19234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1979, 2, 1), Direccion = "Paraguay 579", Telefono = 1101234568 },
            new Persona { Id=19, Apellido = "Ruiz", Nombre = "Florencia", Documento = 20234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1997, 1, 28), Direccion = "Venezuela 690", Telefono = 1112345679 },
            new Persona { Id=20, Apellido = "Morales", Nombre = "Leonardo", Documento = 21234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1984, 4, 17), Direccion = "Peru 801", Telefono = 1123456781 },
            new Persona { Id=21, Apellido = "Benitez", Nombre = "Daniela", Documento = 22234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1998, 12, 25), Direccion = "Uruguay 912", Telefono = 1134567892 },
            new Persona { Id=22, Apellido = "Herrera", Nombre = "Ignacio", Documento = 23234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1990, 11, 19), Direccion = "Ecuador 1023", Telefono = 1145678903 },
            new Persona { Id=23, Apellido = "Vega", Nombre = "Romina", Documento = 24234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1981, 8, 13), Direccion = "Colombia 1134", Telefono = 1156789014 },
            new Persona { Id=24, Apellido = "Campos", Nombre = "Pablo", Documento = 25234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1985, 6, 6), Direccion = "Mexico 1245", Telefono = 1167890124 },
            new Persona { Id=25, Apellido = "Rojas", Nombre = "Carolina", Documento = 26234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1992, 2, 29), Direccion = "Cuba 1356", Telefono = 1178901236 },
            new Persona { Id=26, Apellido = "Navarro", Nombre = "Franco", Documento = 27234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1980, 10, 18), Direccion = "Panamá 1467", Telefono = 1189012346 },
            new Persona { Id=27, Apellido = "Cabrera", Nombre = "Melina", Documento = 28234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1993, 9, 9), Direccion = "Honduras 1578", Telefono = 1190123458 },
            new Persona { Id=28, Apellido = "Ibarra", Nombre = "Gabriel", Documento = 29234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1987, 7, 7), Direccion = "Guatemala 1689", Telefono = 1101234569 },
            new Persona { Id=29, Apellido = "Luna", Nombre = "Milagros", Documento = 30234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1994, 5, 5), Direccion = "Nicaragua 1790", Telefono = 1112345680 },
            new Persona { Id=30, Apellido = "Ponce", Nombre = "Tomas", Documento = 31234567, TipoDocumento = "DNI", FechaNacimiento = new DateTime(1986, 3, 3), Direccion = "Puerto Rico 1901", Telefono = 1123456782 }                
        };

        internal string? Borrar(int personaSeleccionadaId)
        {
            //TODO: validaciones, si son necesarias.

            //no me pongo a validar si el id es válido.
            //si me llega acá un id inválido, el error no está aca.
            Personas.RemoveAll(p => p.Id == personaSeleccionadaId);
            return null;
        }

        internal string ModificarPersona(Persona personaModificada)
        {
            var personaOriginal = ObtenerPersona(personaModificada.Id);

            personaOriginal.TipoDocumento = personaModificada.TipoDocumento;
            personaOriginal.Documento = personaModificada.Documento;
            personaOriginal.Tratamiento = personaModificada.Tratamiento;
            personaOriginal.Apellido = personaModificada.Apellido;
            personaOriginal.Nombre = personaModificada.Nombre;                        
            personaOriginal.FechaNacimiento = personaModificada.FechaNacimiento;
            personaOriginal.Direccion = personaModificada.Direccion;
            personaOriginal.Telefono = personaModificada.Telefono;

            return null;
        }

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

            if (persona.Telefono < 10_000_000)
            {
                return "El telefono debe tener al menos 8 dígitos";
            }

            //valido que el tipo/numero de documento no exista.            

            foreach (var personaEx in Personas)
            {
                if (personaEx.Documento == persona.Documento && personaEx.TipoDocumento == persona.TipoDocumento)
                {
                    return "Ya existe una persona con ese documento y tipo de documento";
                }
            }

            /*
            //Lo mismo pero abreviado. (LINQ)
            if (Personas.Any(p => p.Documento == persona.Documento && p.TipoDocumento == persona.TipoDocumento))
            {
                return "Ya existe una persona con ese documento y tipo de documento";
            }*/


            //hacer lo que haiga que hacer para guardar la persona
            Personas.Add(persona);


            return null; //null indica que no hay errores.
        }

        internal Persona ObtenerPersona(int personaEnEdicionId)
        {
            return Personas.Single(p => p.Id == personaEnEdicionId);
        }
    }
}
