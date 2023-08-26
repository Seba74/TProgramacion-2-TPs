namespace Practico2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LNya = new Label();
            LDni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            LModificar = new Label();
            BGuardar = new Button();
            BEliminar = new Button();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            panel1 = new Panel();
            TTarjeta = new Label();
            CMaster = new CheckBox();
            CVisa = new CheckBox();
            CNaranja = new CheckBox();
            TTelefono = new TextBox();
            LTelefono = new Label();
            BSalir = new Button();
            RBVaron = new RadioButton();
            RBMujer = new RadioButton();
            LTitle = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(14, 16);
            LNya.Name = "LNya";
            LNya.Size = new Size(107, 15);
            LNya.TabIndex = 0;
            LNya.Text = "Nombre y Apellido";
            LNya.Click += LNya_Click;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(30, 74);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 1;
            LDni.Text = "DNI";
            LDni.Click += LDni_Click;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(30, 112);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido";
            LApellido.Click += LApellido_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.BackColor = SystemColors.AppWorkspace;
            LNombre.Location = new Point(30, 157);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 3;
            LNombre.Text = "Nombre";
            LNombre.Click += LNombre_Click;
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(140, 16);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 4;
            LModificar.Text = "modificar";
            LModificar.Click += LModificar_Click;
            // 
            // BGuardar
            // 
            BGuardar.BackgroundImage = Properties.Resources.guardar;
            BGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            BGuardar.Location = new Point(37, 434);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(57, 61);
            BGuardar.TabIndex = 5;
            BGuardar.TextAlign = ContentAlignment.BottomCenter;
            BGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += button1_Click;
            // 
            // BEliminar
            // 
            BEliminar.BackgroundImage = Properties.Resources.eliminar1;
            BEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            BEliminar.Location = new Point(230, 434);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(58, 61);
            BEliminar.TabIndex = 6;
            BEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += button2_Click;
            // 
            // TDni
            // 
            TDni.Location = new Point(151, 66);
            TDni.Multiline = true;
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 7;
            TDni.TextChanged += textBox1_TextChanged;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(151, 104);
            TApellido.Multiline = true;
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 8;
            TApellido.TextChanged += textBox2_TextChanged;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(151, 149);
            TNombre.Multiline = true;
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 9;
            TNombre.TextChanged += textBox3_TextChanged;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(TTarjeta);
            panel1.Controls.Add(CMaster);
            panel1.Controls.Add(LModificar);
            panel1.Controls.Add(CVisa);
            panel1.Controls.Add(LNya);
            panel1.Controls.Add(CNaranja);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(TDni);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(LTelefono);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(LDni);
            panel1.Controls.Add(LApellido);
            panel1.Location = new Point(37, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 327);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // TTarjeta
            // 
            TTarjeta.AutoSize = true;
            TTarjeta.Location = new Point(30, 233);
            TTarjeta.Name = "TTarjeta";
            TTarjeta.Size = new Size(99, 15);
            TTarjeta.TabIndex = 16;
            TTarjeta.Text = "Tarjeta de Credito";
            // 
            // CMaster
            // 
            CMaster.AutoSize = true;
            CMaster.Location = new Point(151, 299);
            CMaster.Name = "CMaster";
            CMaster.Size = new Size(85, 19);
            CMaster.TabIndex = 15;
            CMaster.Text = "Mastercard";
            CMaster.UseVisualStyleBackColor = true;
            CMaster.CheckedChanged += CMaster_CheckedChanged;
            // 
            // CVisa
            // 
            CVisa.AutoSize = true;
            CVisa.Location = new Point(151, 265);
            CVisa.Name = "CVisa";
            CVisa.Size = new Size(47, 19);
            CVisa.TabIndex = 14;
            CVisa.Text = "Visa";
            CVisa.UseVisualStyleBackColor = true;
            CVisa.CheckedChanged += CVisa_CheckedChanged;
            // 
            // CNaranja
            // 
            CNaranja.AutoSize = true;
            CNaranja.Location = new Point(151, 229);
            CNaranja.Name = "CNaranja";
            CNaranja.Size = new Size(67, 19);
            CNaranja.TabIndex = 13;
            CNaranja.Text = "Naranja";
            CNaranja.UseVisualStyleBackColor = true;
            CNaranja.CheckedChanged += CNaranja_CheckedChanged;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(151, 194);
            TTelefono.Multiline = true;
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(100, 23);
            TTelefono.TabIndex = 12;
            TTelefono.TextChanged += TTelefono_TextChanged;
            TTelefono.KeyPress += TTelefono_KeyPress;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(30, 197);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(52, 15);
            LTelefono.TabIndex = 11;
            LTelefono.Text = "Telefono";
            // 
            // BSalir
            // 
            BSalir.BackColor = Color.Transparent;
            BSalir.BackgroundImage = Properties.Resources.salir;
            BSalir.BackgroundImageLayout = ImageLayout.Zoom;
            BSalir.ForeColor = Color.Transparent;
            BSalir.Location = new Point(487, 453);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(74, 61);
            BSalir.TabIndex = 11;
            BSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            BSalir.UseVisualStyleBackColor = false;
            BSalir.Click += BSalir_Click;
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Checked = true;
            RBVaron.Location = new Point(373, 216);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(55, 19);
            RBVaron.TabIndex = 12;
            RBVaron.TabStop = true;
            RBVaron.Text = "Varon";
            RBVaron.UseVisualStyleBackColor = true;
            RBVaron.CheckedChanged += RBVaron_CheckedChanged;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(478, 216);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(56, 19);
            RBMujer.TabIndex = 13;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;
            // 
            // LTitle
            // 
            LTitle.AutoSize = true;
            LTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LTitle.ForeColor = Color.RoyalBlue;
            LTitle.Location = new Point(213, 22);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(173, 29);
            LTitle.TabIndex = 14;
            LTitle.Text = "Nuevo Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.man;
            pictureBox1.Location = new Point(383, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 519);
            Controls.Add(pictureBox1);
            Controls.Add(LTitle);
            Controls.Add(RBMujer);
            Controls.Add(RBVaron);
            Controls.Add(BSalir);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Pequeño Formulario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNya;
        private Label LDni;
        private Label LApellido;
        private Label LNombre;
        private Label LModificar;
        private Button BGuardar;
        private Button BEliminar;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private Panel panel1;
        private TextBox TTelefono;
        private Label LTelefono;
        private CheckBox CNaranja;
        private CheckBox CMaster;
        private CheckBox CVisa;
        private Label TTarjeta;
        private Button BSalir;
        private RadioButton RBVaron;
        private RadioButton RBMujer;
        private Label LTitle;
        private PictureBox pictureBox1;
    }
}