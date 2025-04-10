namespace AndresPa.EjemploClase.Agenda.NuevaPersona;

partial class NuevaPersonaForm
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
        nombreText = new TextBox();
        label1 = new Label();
        label3 = new Label();
        fechaNacimientoText = new TextBox();
        tratamientoCombo = new ComboBox();
        label4 = new Label();
        label5 = new Label();
        tipoDocCombo = new ComboBox();
        label6 = new Label();
        numeroDocText = new TextBox();
        label7 = new Label();
        direccionText = new TextBox();
        label8 = new Label();
        telefonoText = new TextBox();
        okButton = new Button();
        cancelButton = new Button();
        apellidoText = new TextBox();
        label2 = new Label();
        SuspendLayout();
        // 
        // nombreText
        // 
        nombreText.Location = new Point(151, 33);
        nombreText.Name = "nombreText";
        nombreText.Size = new Size(224, 23);
        nombreText.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(151, 15);
        label1.Name = "label1";
        label1.Size = new Size(51, 15);
        label1.TabIndex = 1;
        label1.Text = "Nombre";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(336, 69);
        label3.Name = "label3";
        label3.Size = new Size(117, 15);
        label3.TabIndex = 5;
        label3.Text = "Fecha de nacimiento";
        // 
        // fechaNacimientoText
        // 
        fechaNacimientoText.Location = new Point(336, 87);
        fechaNacimientoText.Name = "fechaNacimientoText";
        fechaNacimientoText.Size = new Size(269, 23);
        fechaNacimientoText.TabIndex = 4;
        // 
        // tratamientoCombo
        // 
        tratamientoCombo.FormattingEnabled = true;
        tratamientoCombo.Location = new Point(23, 33);
        tratamientoCombo.Name = "tratamientoCombo";
        tratamientoCombo.Size = new Size(121, 23);
        tratamientoCombo.TabIndex = 6;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(23, 15);
        label4.Name = "label4";
        label4.Size = new Size(70, 15);
        label4.TabIndex = 7;
        label4.Text = "Tratamiento";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(23, 69);
        label5.Name = "label5";
        label5.Size = new Size(95, 15);
        label5.TabIndex = 9;
        label5.Text = "Tipo documento";
        // 
        // tipoDocCombo
        // 
        tipoDocCombo.FormattingEnabled = true;
        tipoDocCombo.Location = new Point(23, 87);
        tipoDocCombo.Name = "tipoDocCombo";
        tipoDocCombo.Size = new Size(121, 23);
        tipoDocCombo.TabIndex = 8;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(151, 69);
        label6.Name = "label6";
        label6.Size = new Size(132, 15);
        label6.TabIndex = 11;
        label6.Text = "Numero de documento";
        // 
        // numeroDocText
        // 
        numeroDocText.Location = new Point(151, 87);
        numeroDocText.Name = "numeroDocText";
        numeroDocText.Size = new Size(179, 23);
        numeroDocText.TabIndex = 10;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(23, 124);
        label7.Name = "label7";
        label7.Size = new Size(57, 15);
        label7.TabIndex = 13;
        label7.Text = "Direccion";
        // 
        // direccionText
        // 
        direccionText.Location = new Point(23, 142);
        direccionText.Name = "direccionText";
        direccionText.Size = new Size(297, 23);
        direccionText.TabIndex = 12;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(326, 124);
        label8.Name = "label8";
        label8.Size = new Size(52, 15);
        label8.TabIndex = 15;
        label8.Text = "Teléfono";
        // 
        // telefonoText
        // 
        telefonoText.Location = new Point(326, 142);
        telefonoText.Name = "telefonoText";
        telefonoText.Size = new Size(279, 23);
        telefonoText.TabIndex = 14;
        // 
        // okButton
        // 
        okButton.Location = new Point(449, 217);
        okButton.Name = "okButton";
        okButton.Size = new Size(75, 23);
        okButton.TabIndex = 16;
        okButton.Text = "Ok";
        okButton.UseVisualStyleBackColor = true;
        okButton.Click += okButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.Location = new Point(530, 217);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(75, 23);
        cancelButton.TabIndex = 17;
        cancelButton.Text = "Cancelar";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // apellidoText
        // 
        apellidoText.Location = new Point(381, 33);
        apellidoText.Name = "apellidoText";
        apellidoText.Size = new Size(224, 23);
        apellidoText.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(381, 15);
        label2.Name = "label2";
        label2.Size = new Size(51, 15);
        label2.TabIndex = 3;
        label2.Text = "Apellido";
        // 
        // NuevaPersonaForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(618, 264);
        Controls.Add(telefonoText);
        Controls.Add(direccionText);
        Controls.Add(cancelButton);
        Controls.Add(label7);
        Controls.Add(label8);
        Controls.Add(okButton);
        Controls.Add(label6);
        Controls.Add(numeroDocText);
        Controls.Add(label5);
        Controls.Add(tipoDocCombo);
        Controls.Add(label4);
        Controls.Add(tratamientoCombo);
        Controls.Add(label3);
        Controls.Add(fechaNacimientoText);
        Controls.Add(label2);
        Controls.Add(apellidoText);
        Controls.Add(label1);
        Controls.Add(nombreText);
        Name = "NuevaPersonaForm";
        Text = "NuevaPersona";
        Load += NuevaPersona_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox nombreText;
    private Label label1;
    private Label label3;
    private TextBox fechaNacimientoText;
    private ComboBox tratamientoCombo;
    private Label label4;
    private Label label5;
    private ComboBox tipoDocCombo;
    private Label label6;
    private TextBox numeroDocText;
    private Label label7;
    private TextBox direccionText;
    private Label label8;
    private TextBox telefonoText;
    private Button okButton;
    private Button cancelButton;
    private TextBox apellidoText;
    private Label label2;
}