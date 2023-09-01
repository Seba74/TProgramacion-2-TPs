namespace Practico5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            DTFecha = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            RMujer = new RadioButton();
            RHombre = new RadioButton();
            TFoto = new TextBox();
            TSaldo = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            LSaldo = new Label();
            LSexo = new Label();
            LFecha = new Label();
            LApellido = new Label();
            LNombre = new Label();
            openFileDialog1 = new OpenFileDialog();
            PUsuario = new PictureBox();
            dataGridView1 = new DataGridView();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            Ruta = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(DTFecha);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(RMujer);
            panel1.Controls.Add(RHombre);
            panel1.Controls.Add(TFoto);
            panel1.Controls.Add(TSaldo);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(LSaldo);
            panel1.Controls.Add(LSexo);
            panel1.Controls.Add(LFecha);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LNombre);
            panel1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(140, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 434);
            panel1.TabIndex = 0;
            // 
            // DTFecha
            // 
            DTFecha.CalendarFont = new Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DTFecha.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DTFecha.Format = DateTimePickerFormat.Short;
            DTFecha.Location = new Point(286, 164);
            DTFecha.Name = "DTFecha";
            DTFecha.Size = new Size(104, 28);
            DTFecha.TabIndex = 13;
            DTFecha.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.guardar1;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(270, 385);
            button2.Name = "button2";
            button2.Size = new Size(73, 43);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(27, 328);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Foto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RMujer
            // 
            RMujer.AutoSize = true;
            RMujer.BackColor = Color.Transparent;
            RMujer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RMujer.Location = new Point(248, 211);
            RMujer.Name = "RMujer";
            RMujer.Size = new Size(66, 24);
            RMujer.TabIndex = 10;
            RMujer.TabStop = true;
            RMujer.Text = "Mujer";
            RMujer.UseVisualStyleBackColor = false;
            // 
            // RHombre
            // 
            RHombre.AutoSize = true;
            RHombre.BackColor = Color.Transparent;
            RHombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RHombre.Location = new Point(144, 211);
            RHombre.Name = "RHombre";
            RHombre.Size = new Size(84, 24);
            RHombre.TabIndex = 9;
            RHombre.TabStop = true;
            RHombre.Text = "Hombre";
            RHombre.UseVisualStyleBackColor = false;
            // 
            // TFoto
            // 
            TFoto.BackColor = Color.Peru;
            TFoto.Location = new Point(134, 328);
            TFoto.Multiline = true;
            TFoto.Name = "TFoto";
            TFoto.Size = new Size(224, 33);
            TFoto.TabIndex = 8;
            TFoto.TextChanged += TFoto_TextChanged;
            // 
            // TSaldo
            // 
            TSaldo.BackColor = Color.Peru;
            TSaldo.Location = new Point(134, 265);
            TSaldo.Multiline = true;
            TSaldo.Name = "TSaldo";
            TSaldo.Size = new Size(224, 33);
            TSaldo.TabIndex = 7;
            TSaldo.TextChanged += TSaldo_TextChanged;
            TSaldo.KeyPress += TSaldo_KeyPress;
            // 
            // TApellido
            // 
            TApellido.BackColor = Color.Peru;
            TApellido.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TApellido.Location = new Point(134, 107);
            TApellido.Multiline = true;
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(224, 33);
            TApellido.TabIndex = 6;
            TApellido.TextChanged += textBox2_TextChanged;
            TApellido.KeyPress += textBox2_KeyPress;
            // 
            // TNombre
            // 
            TNombre.BackColor = Color.Peru;
            TNombre.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TNombre.Location = new Point(134, 46);
            TNombre.Multiline = true;
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(224, 33);
            TNombre.TabIndex = 5;
            TNombre.KeyPress += textBox1_KeyPress;
            // 
            // LSaldo
            // 
            LSaldo.AutoSize = true;
            LSaldo.BackColor = Color.Transparent;
            LSaldo.Font = new Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LSaldo.Location = new Point(27, 268);
            LSaldo.Name = "LSaldo";
            LSaldo.Size = new Size(75, 33);
            LSaldo.TabIndex = 4;
            LSaldo.Text = "Saldo";
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.BackColor = Color.Transparent;
            LSexo.Font = new Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LSexo.Location = new Point(27, 211);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(64, 33);
            LSexo.TabIndex = 3;
            LSexo.Text = "Sexo";
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.BackColor = Color.Transparent;
            LFecha.Font = new Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LFecha.Location = new Point(27, 162);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(253, 33);
            LFecha.TabIndex = 2;
            LFecha.Text = "Fecha de Nacimiento";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.BackColor = Color.Transparent;
            LApellido.Font = new Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.Location = new Point(27, 107);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(110, 33);
            LApellido.TabIndex = 1;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.BackColor = Color.Transparent;
            LNombre.Font = new Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.Location = new Point(27, 46);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(101, 33);
            LNombre.TabIndex = 0;
            LNombre.Text = "Nombre";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // PUsuario
            // 
            PUsuario.BackColor = Color.Transparent;
            PUsuario.Image = (Image)resources.GetObject("PUsuario.Image");
            PUsuario.Location = new Point(681, 38);
            PUsuario.Name = "PUsuario";
            PUsuario.Size = new Size(321, 434);
            PUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            PUsuario.TabIndex = 1;
            PUsuario.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Apellido, Nombre, FechaNacimiento, Sexo, Eliminar, Saldo, Foto, Ruta });
            dataGridView1.Location = new Point(140, 530);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(862, 161);
            dataGridView1.TabIndex = 2;
            dataGridView1.AutoSizeRowsModeChanged += dataGridView1_AutoSizeRowsModeChanged;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Apellido
            // 
            Apellido.Frozen = true;
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 114;
            // 
            // Nombre
            // 
            Nombre.Frozen = true;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 112;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.Frozen = true;
            FechaNacimiento.HeaderText = "FechaDeNacimiento";
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.ReadOnly = true;
            FechaNacimiento.Width = 231;
            // 
            // Sexo
            // 
            Sexo.Frozen = true;
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            Sexo.Width = 86;
            // 
            // Eliminar
            // 
            Eliminar.Frozen = true;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Width = 95;
            // 
            // Saldo
            // 
            Saldo.Frozen = true;
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            Saldo.ReadOnly = true;
            Saldo.Width = 92;
            // 
            // Foto
            // 
            Foto.Frozen = true;
            Foto.HeaderText = "Foto";
            Foto.Name = "Foto";
            Foto.ReadOnly = true;
            Foto.Width = 61;
            // 
            // Ruta
            // 
            Ruta.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Ruta.DefaultCellStyle = dataGridViewCellStyle1;
            Ruta.Frozen = true;
            Ruta.HeaderText = "Ruta";
            Ruta.Name = "Ruta";
            Ruta.ReadOnly = true;
            Ruta.Width = 82;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1170, 715);
            Controls.Add(dataGridView1);
            Controls.Add(PUsuario);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LNombre;
        private RadioButton RMujer;
        private RadioButton RHombre;
        private TextBox TFoto;
        private TextBox TSaldo;
        private TextBox TApellido;
        private TextBox TNombre;
        private Label LSaldo;
        private Label LSexo;
        private Label LFecha;
        private Label LApellido;
        private Button button2;
        private Button button1;
        private DateTimePicker DTFecha;
        private OpenFileDialog openFileDialog1;
        private PictureBox PUsuario;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn Ruta;
    }
}