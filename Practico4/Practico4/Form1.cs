using System;
using System.Windows.Forms;

namespace Practico4
{
    public partial class Form1 : Form
    {
        private int inicio;
        private int fin;

        public Form1()
        {
            InitializeComponent();
        }

        private void TDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void THasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BGenerador_Click(object sender, EventArgs e)
        {
            LListaNum.Items.Clear();
            string inicioStr = TDesde.Text.Trim();
            string finStr = THasta.Text.Trim();

            if (string.IsNullOrWhiteSpace(inicioStr) || string.IsNullOrWhiteSpace(finStr))
            {
                MostrarAdvertencia("Por favor complete los campos faltantes.");
                return;
            }

            inicio = int.Parse(inicioStr);
            fin = int.Parse(finStr);

            GenerarNumeros();
        }

        private void GenerarNumeros()
        {
            while (inicio <= fin)
            {
                LListaNum.Items.Add(inicio++);
            }
        }

        private void BPares_Click(object sender, EventArgs e)
        {
            LListaNum.Items.Clear();
            string inicioStr = TDesde.Text.Trim();
            string finStr = THasta.Text.Trim();

            if (string.IsNullOrWhiteSpace(inicioStr) || string.IsNullOrWhiteSpace(finStr))
            {
                MostrarAdvertencia("Por favor complete los campos faltantes.");
                return;
            }

            inicio = int.Parse(inicioStr);
            fin = int.Parse(finStr);

            GenerarNumerosPares();
        }

        private void GenerarNumerosPares()
        {
            while (inicio <= fin)
            {
                if (inicio % 2 == 0)
                {
                    LListaNum.Items.Add(inicio);
                }

                inicio++;
            }
        }

        private void BImpares_Click(object sender, EventArgs e)
        {
            LListaNum.Items.Clear();
            string inicioStr = TDesde.Text.Trim();
            string finStr = THasta.Text.Trim();

            if (string.IsNullOrWhiteSpace(inicioStr) || string.IsNullOrWhiteSpace(finStr))
            {
                MostrarAdvertencia("Por favor complete los campos faltantes.");
                return;
            }

            inicio = int.Parse(inicioStr);
            fin = int.Parse(finStr);

            GenerarNumerosImpares();
        }

        private void GenerarNumerosImpares()
        {
            while (inicio <= fin)
            {
                if (inicio % 2 != 0)
                {
                    LListaNum.Items.Add(inicio);
                }

                inicio++;
            }
        }

        private void BPrimos_Click(object sender, EventArgs e)
        {
            LListaNum.Items.Clear();
            string inicioStr = TDesde.Text.Trim();
            string finStr = THasta.Text.Trim();

            if (string.IsNullOrWhiteSpace(inicioStr) || string.IsNullOrWhiteSpace(finStr))
            {
                MostrarAdvertencia("Por favor complete los campos faltantes.");
                return;
            }

            inicio = int.Parse(inicioStr);
            fin = int.Parse(finStr);

            GenerarNumerosPrimos();
        }

        private void GenerarNumerosPrimos()
        {
            while (inicio <= fin)
            {
                if (EsPrimo(inicio))
                {
                    LListaNum.Items.Add(inicio);
                }

                inicio++;
            }
        }

        private bool EsPrimo(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
