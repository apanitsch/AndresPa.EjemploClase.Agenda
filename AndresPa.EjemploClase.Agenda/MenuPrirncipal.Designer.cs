namespace AndresPa.EjemploClase.Agenda;

partial class MenuPrirncipal
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        nuevaPersonaButton = new Button();
        SuspendLayout();
        // 
        // nuevaPersonaButton
        // 
        nuevaPersonaButton.Location = new Point(43, 42);
        nuevaPersonaButton.Name = "nuevaPersonaButton";
        nuevaPersonaButton.Size = new Size(167, 23);
        nuevaPersonaButton.TabIndex = 0;
        nuevaPersonaButton.Text = "Nueva Persona";
        nuevaPersonaButton.UseVisualStyleBackColor = true;
        nuevaPersonaButton.Click += nuevaPersonaButton_Click;
        // 
        // MenuPrirncipal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(nuevaPersonaButton);
        Name = "MenuPrirncipal";
        Text = "MenuPrirncipal";
        ResumeLayout(false);
    }

    #endregion

    private Button nuevaPersonaButton;
}