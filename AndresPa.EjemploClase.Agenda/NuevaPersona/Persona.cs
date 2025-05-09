﻿namespace AndresPa.EjemploClase.Agenda.NuevaPersona;

internal class Persona
{
    public int Id { get; set; } //Id de la persona 

    //string => tiene valor.
    //string? => puede no tener valor.
    public string Tratamiento { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string TipoDocumento { get; set; } = string.Empty;
    public int Documento { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Direccion { get; set; } = string.Empty;
    public long Telefono { get; set; }
}