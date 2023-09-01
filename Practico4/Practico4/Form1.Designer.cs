namespace Practico4
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
            TDesde = new TextBox();
            THasta = new TextBox();
            LDesde = new Label();
            LHasta = new Label();
            LLista = new Label();
            LListaNum = new ListBox();
            BGenerador = new Button();
            BPares = new Button();
            BImpares = new Button();
            BPrimos = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // TDesde
            // 
            TDesde.Location = new Point(100, 96);
            TDesde.Name = "TDesde";
            TDesde.Size = new Size(125, 23);
            TDesde.TabIndex = 0;
            TDesde.KeyPress += TDesde_KeyPress;
            // 
            // THasta
            // 
            THasta.Location = new Point(100, 169);
            THasta.Name = "THasta";
            THasta.Size = new Size(125, 23);
            THasta.TabIndex = 1;
            THasta.TextChanged += THasta_TextChanged;
            THasta.KeyPress += THasta_KeyPress;
            // 
            // LDesde
            // 
            LDesde.AutoSize = true;
            LDesde.Location = new Point(55, 99);
            LDesde.Name = "LDesde";
            LDesde.Size = new Size(39, 15);
            LDesde.TabIndex = 2;
            LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            LHasta.AutoSize = true;
            LHasta.Location = new Point(55, 172);
            LHasta.Name = "LHasta";
            LHasta.Size = new Size(37, 15);
            LHasta.TabIndex = 3;
            LHasta.Text = "Hasta";
            // 
            // LLista
            // 
            LLista.AutoSize = true;
            LLista.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LLista.Location = new Point(187, 18);
            LLista.Name = "LLista";
            LLista.Size = new Size(226, 37);
            LLista.TabIndex = 4;
            LLista.Text = "Lista De Numeros";
            // 
            // LListaNum
            // 
            LListaNum.FormattingEnabled = true;
            LListaNum.ItemHeight = 15;
            LListaNum.Location = new Point(282, 96);
            LListaNum.Name = "LListaNum";
            LListaNum.Size = new Size(255, 199);
            LListaNum.TabIndex = 5;
            LListaNum.SelectedIndexChanged += LListaNum_SelectedIndexChanged;
            // 
            // BGenerador
            // 
            BGenerador.Location = new Point(100, 229);
            BGenerador.Name = "BGenerador";
            BGenerador.Size = new Size(116, 23);
            BGenerador.TabIndex = 6;
            BGenerador.Text = "Generar Función";
            BGenerador.UseVisualStyleBackColor = true;
            BGenerador.Click += BGenerador_Click;
            // 
            // BPares
            // 
            BPares.Location = new Point(100, 272);
            BPares.Name = "BPares";
            BPares.Size = new Size(116, 23);
            BPares.TabIndex = 7;
            BPares.Text = "Numeros Pares";
            BPares.UseVisualStyleBackColor = true;
            BPares.Click += BPares_Click;
            // 
            // BImpares
            // 
            BImpares.Location = new Point(100, 314);
            BImpares.Name = "BImpares";
            BImpares.Size = new Size(116, 23);
            BImpares.TabIndex = 8;
            BImpares.Text = "Numeros Impares";
            BImpares.UseVisualStyleBackColor = true;
            BImpares.Click += BImpares_Click;
            // 
            // BPrimos
            // 
            BPrimos.Location = new Point(100, 360);
            BPrimos.Name = "BPrimos";
            BPrimos.Size = new Size(116, 23);
            BPrimos.TabIndex = 9;
            BPrimos.Text = "Numeros Primos";
            BPrimos.UseVisualStyleBackColor = true;
            BPrimos.Click += BPrimos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 409);
            Controls.Add(BPrimos);
            Controls.Add(BImpares);
            Controls.Add(BPares);
            Controls.Add(BGenerador);
            Controls.Add(LListaNum);
            Controls.Add(LLista);
            Controls.Add(LHasta);
            Controls.Add(LDesde);
            Controls.Add(THasta);
            Controls.Add(TDesde);
            Name = "Form1";
            Text = "Formulario4";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TDesde;
        private TextBox THasta;
        private Label LDesde;
        private Label LHasta;
        private Label LLista;
        private ListBox LListaNum;
        private Button BGenerador;
        private Button BPares;
        private Button BImpares;
        private Button BPrimos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}