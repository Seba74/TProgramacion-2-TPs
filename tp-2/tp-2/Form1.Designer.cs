namespace tp_2
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
            LNyA = new Label();
            TDni = new Label();
            TApellido = new Label();
            TNombre = new Label();
            BGuardar = new Button();
            BCancelar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // LNyA
            // 
            LNyA.AutoSize = true;
            LNyA.Location = new Point(36, 32);
            LNyA.Name = "LNyA";
            LNyA.Size = new Size(110, 15);
            LNyA.TabIndex = 0;
            LNyA.Text = "Nombre y Apellido:";
            // 
            // TDni
            // 
            TDni.AutoSize = true;
            TDni.Location = new Point(36, 86);
            TDni.Name = "TDni";
            TDni.Size = new Size(27, 15);
            TDni.TabIndex = 1;
            TDni.Text = "DNI";
            // 
            // TApellido
            // 
            TApellido.AutoSize = true;
            TApellido.Location = new Point(36, 122);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(51, 15);
            TApellido.TabIndex = 2;
            TApellido.Text = "Apellido";
            TApellido.Click += label1_Click;
            // 
            // TNombre
            // 
            TNombre.AutoSize = true;
            TNombre.Location = new Point(36, 155);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(51, 15);
            TNombre.TabIndex = 3;
            TNombre.Text = "Nombre";
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(36, 201);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 4;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // BCancelar
            // 
            BCancelar.Location = new Point(145, 201);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(75, 23);
            BCancelar.TabIndex = 5;
            BCancelar.Text = "Eliminar";
            BCancelar.UseVisualStyleBackColor = true;
            BCancelar.Click += BCancelar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 23);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(114, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(137, 23);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(162, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 9;
            label1.Text = "modificar";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(BCancelar);
            Controls.Add(BGuardar);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(TDni);
            Controls.Add(LNyA);
            Name = "Form1";
            Text = "Pequeño Formulario";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNyA;
        private Label TDni;
        private Label TApellido;
        private Label TNombre;
        private Button BGuardar;
        private Button BCancelar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
    }
}