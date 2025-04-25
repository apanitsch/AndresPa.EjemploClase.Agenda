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
        personasList = new ListView();
        documentoCol = new ColumnHeader();
        apellidoCol = new ColumnHeader();
        nombreCol = new ColumnHeader();
        edicionGroup = new GroupBox();
        modificarButton = new Button();
        borrarButton = new Button();
        nuevaButton = new Button();
        filtrosGroup = new GroupBox();
        button1 = new Button();
        textBox1 = new TextBox();
        label9 = new Label();
        textBox2 = new TextBox();
        label10 = new Label();
        label11 = new Label();
        textBox3 = new TextBox();
        edicionGroup.SuspendLayout();
        filtrosGroup.SuspendLayout();
        SuspendLayout();
        // 
        // nombreText
        // 
        nombreText.Location = new Point(152, 62);
        nombreText.Name = "nombreText";
        nombreText.Size = new Size(224, 23);
        nombreText.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(152, 44);
        label1.Name = "label1";
        label1.Size = new Size(51, 15);
        label1.TabIndex = 1;
        label1.Text = "Nombre";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(337, 98);
        label3.Name = "label3";
        label3.Size = new Size(117, 15);
        label3.TabIndex = 5;
        label3.Text = "Fecha de nacimiento";
        // 
        // fechaNacimientoText
        // 
        fechaNacimientoText.Location = new Point(337, 116);
        fechaNacimientoText.Name = "fechaNacimientoText";
        fechaNacimientoText.Size = new Size(269, 23);
        fechaNacimientoText.TabIndex = 4;
        // 
        // tratamientoCombo
        // 
        tratamientoCombo.FormattingEnabled = true;
        tratamientoCombo.Location = new Point(24, 62);
        tratamientoCombo.Name = "tratamientoCombo";
        tratamientoCombo.Size = new Size(121, 23);
        tratamientoCombo.TabIndex = 6;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(24, 44);
        label4.Name = "label4";
        label4.Size = new Size(70, 15);
        label4.TabIndex = 7;
        label4.Text = "Tratamiento";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(24, 98);
        label5.Name = "label5";
        label5.Size = new Size(95, 15);
        label5.TabIndex = 9;
        label5.Text = "Tipo documento";
        // 
        // tipoDocCombo
        // 
        tipoDocCombo.FormattingEnabled = true;
        tipoDocCombo.Location = new Point(24, 116);
        tipoDocCombo.Name = "tipoDocCombo";
        tipoDocCombo.Size = new Size(121, 23);
        tipoDocCombo.TabIndex = 8;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(152, 98);
        label6.Name = "label6";
        label6.Size = new Size(132, 15);
        label6.TabIndex = 11;
        label6.Text = "Numero de documento";
        // 
        // numeroDocText
        // 
        numeroDocText.Location = new Point(152, 116);
        numeroDocText.Name = "numeroDocText";
        numeroDocText.Size = new Size(179, 23);
        numeroDocText.TabIndex = 10;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(24, 153);
        label7.Name = "label7";
        label7.Size = new Size(57, 15);
        label7.TabIndex = 13;
        label7.Text = "Direccion";
        // 
        // direccionText
        // 
        direccionText.Location = new Point(24, 171);
        direccionText.Name = "direccionText";
        direccionText.Size = new Size(297, 23);
        direccionText.TabIndex = 12;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(327, 153);
        label8.Name = "label8";
        label8.Size = new Size(52, 15);
        label8.TabIndex = 15;
        label8.Text = "Teléfono";
        // 
        // telefonoText
        // 
        telefonoText.Location = new Point(327, 171);
        telefonoText.Name = "telefonoText";
        telefonoText.Size = new Size(279, 23);
        telefonoText.TabIndex = 14;
        // 
        // okButton
        // 
        okButton.Location = new Point(450, 216);
        okButton.Name = "okButton";
        okButton.Size = new Size(75, 23);
        okButton.TabIndex = 16;
        okButton.Text = "Ok";
        okButton.UseVisualStyleBackColor = true;
        okButton.Click += okButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.Location = new Point(531, 216);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(75, 23);
        cancelButton.TabIndex = 17;
        cancelButton.Text = "Cancelar";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Click += cancelButton_Click;
        // 
        // apellidoText
        // 
        apellidoText.Location = new Point(382, 62);
        apellidoText.Name = "apellidoText";
        apellidoText.Size = new Size(224, 23);
        apellidoText.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(382, 44);
        label2.Name = "label2";
        label2.Size = new Size(51, 15);
        label2.TabIndex = 3;
        label2.Text = "Apellido";
        // 
        // personasList
        // 
        personasList.CheckBoxes = true;
        personasList.Columns.AddRange(new ColumnHeader[] { documentoCol, apellidoCol, nombreCol });
        personasList.FullRowSelect = true;
        personasList.Location = new Point(28, 168);
        personasList.Name = "personasList";
        personasList.Size = new Size(624, 255);
        personasList.TabIndex = 18;
        personasList.UseCompatibleStateImageBehavior = false;
        personasList.View = View.Details;
        // 
        // documentoCol
        // 
        documentoCol.Text = "Documento";
        documentoCol.Width = 200;
        // 
        // apellidoCol
        // 
        apellidoCol.Text = "Apellido";
        apellidoCol.Width = 200;
        // 
        // nombreCol
        // 
        nombreCol.Text = "Nombre";
        nombreCol.Width = 200;
        // 
        // edicionGroup
        // 
        edicionGroup.Controls.Add(label4);
        edicionGroup.Controls.Add(nombreText);
        edicionGroup.Controls.Add(cancelButton);
        edicionGroup.Controls.Add(telefonoText);
        edicionGroup.Controls.Add(okButton);
        edicionGroup.Controls.Add(label1);
        edicionGroup.Controls.Add(direccionText);
        edicionGroup.Controls.Add(apellidoText);
        edicionGroup.Controls.Add(label2);
        edicionGroup.Controls.Add(label7);
        edicionGroup.Controls.Add(fechaNacimientoText);
        edicionGroup.Controls.Add(label8);
        edicionGroup.Controls.Add(label3);
        edicionGroup.Controls.Add(tratamientoCombo);
        edicionGroup.Controls.Add(label6);
        edicionGroup.Controls.Add(tipoDocCombo);
        edicionGroup.Controls.Add(numeroDocText);
        edicionGroup.Controls.Add(label5);
        edicionGroup.Enabled = false;
        edicionGroup.Location = new Point(28, 452);
        edicionGroup.Name = "edicionGroup";
        edicionGroup.Size = new Size(624, 264);
        edicionGroup.TabIndex = 19;
        edicionGroup.TabStop = false;
        edicionGroup.Text = "edicionGroup";
        // 
        // modificarButton
        // 
        modificarButton.Location = new Point(464, 429);
        modificarButton.Name = "modificarButton";
        modificarButton.Size = new Size(188, 23);
        modificarButton.TabIndex = 20;
        modificarButton.Text = "Modificar persona";
        modificarButton.UseVisualStyleBackColor = true;
        modificarButton.Click += modificarButton_Click;
        // 
        // borrarButton
        // 
        borrarButton.Location = new Point(318, 429);
        borrarButton.Name = "borrarButton";
        borrarButton.Size = new Size(140, 23);
        borrarButton.TabIndex = 21;
        borrarButton.Text = "Borrar persona";
        borrarButton.UseVisualStyleBackColor = true;
        borrarButton.Click += borrarButton_Click;
        // 
        // nuevaButton
        // 
        nuevaButton.Location = new Point(187, 429);
        nuevaButton.Name = "nuevaButton";
        nuevaButton.Size = new Size(125, 23);
        nuevaButton.TabIndex = 22;
        nuevaButton.Text = "Nueva persona";
        nuevaButton.UseVisualStyleBackColor = true;
        nuevaButton.Click += nuevaButton_Click;
        // 
        // filtrosGroup
        // 
        filtrosGroup.Controls.Add(button1);
        filtrosGroup.Controls.Add(textBox1);
        filtrosGroup.Controls.Add(label9);
        filtrosGroup.Controls.Add(textBox2);
        filtrosGroup.Controls.Add(label10);
        filtrosGroup.Controls.Add(label11);
        filtrosGroup.Controls.Add(textBox3);
        filtrosGroup.Location = new Point(33, 16);
        filtrosGroup.Name = "filtrosGroup";
        filtrosGroup.Size = new Size(619, 136);
        filtrosGroup.TabIndex = 23;
        filtrosGroup.TabStop = false;
        filtrosGroup.Text = "Mostrar.... (\"filtros\")";
        // 
        // button1
        // 
        button1.Location = new Point(530, 88);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 18;
        button1.Text = "Buscar";
        button1.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(19, 46);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(224, 23);
        textBox1.TabIndex = 12;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(19, 28);
        label9.Name = "label9";
        label9.Size = new Size(108, 15);
        label9.TabIndex = 13;
        label9.Text = "Nombre (contiene)";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(249, 46);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(224, 23);
        textBox2.TabIndex = 14;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(249, 28);
        label10.Name = "label10";
        label10.Size = new Size(108, 15);
        label10.TabIndex = 15;
        label10.Text = "Apellido (contiene)";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(479, 28);
        label11.Name = "label11";
        label11.Size = new Size(110, 15);
        label11.TabIndex = 17;
        label11.Text = "Documento (xacto)";
        // 
        // textBox3
        // 
        textBox3.Location = new Point(479, 46);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(134, 23);
        textBox3.TabIndex = 16;
        // 
        // NuevaPersonaForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(664, 728);
        Controls.Add(filtrosGroup);
        Controls.Add(nuevaButton);
        Controls.Add(borrarButton);
        Controls.Add(modificarButton);
        Controls.Add(edicionGroup);
        Controls.Add(personasList);
        Name = "NuevaPersonaForm";
        Text = "NuevaPersona";
        Load += NuevaPersona_Load;
        edicionGroup.ResumeLayout(false);
        edicionGroup.PerformLayout();
        filtrosGroup.ResumeLayout(false);
        filtrosGroup.PerformLayout();
        ResumeLayout(false);
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
    private ListView personasList;
    private GroupBox edicionGroup;
    private Button modificarButton;
    private Button borrarButton;
    private Button nuevaButton;
    private ColumnHeader documentoCol;
    private ColumnHeader apellidoCol;
    private ColumnHeader nombreCol;
    private GroupBox filtrosGroup;
    private Button button1;
    private TextBox textBox1;
    private Label label9;
    private TextBox textBox2;
    private Label label10;
    private Label label11;
    private TextBox textBox3;
}