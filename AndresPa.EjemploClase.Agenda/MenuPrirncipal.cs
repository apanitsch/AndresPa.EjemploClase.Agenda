using AndresPa.EjemploClase.Agenda.NuevaPersona;

namespace AndresPa.EjemploClase.Agenda;

public partial class MenuPrirncipal : Form
{
    public MenuPrirncipal() => InitializeComponent();

    private void nuevaPersonaButton_Click(object sender, EventArgs e)
    {
        _ = new NuevaPersonaForm();
    }
}
