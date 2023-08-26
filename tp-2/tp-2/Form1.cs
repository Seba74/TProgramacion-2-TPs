using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tp_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BCancelar.Enabled = false;
            BGuardar.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(textBox1.Text);
            string apellido = textBox2.Text;
            string nombre = textBox3.Text;

            // Combinar apellido y nombre
            string nombreCompleto = $"{nombre} {apellido}";

            // Mostrar el resultado en el TextBox3
            label1.Text = nombreCompleto;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            DialogResult result = MessageBox.Show("El Cliente: " + nombreCompleto + " se inserto Correctamente");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            UpdateBCancelarState();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateBCancelarState();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateBCancelarState();
        }

        private void UpdateBCancelarState()
        {
            BGuardar.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text) &&
                               !string.IsNullOrWhiteSpace(textBox2.Text) &&
                               !string.IsNullOrWhiteSpace(textBox3.Text);

            if (label1.Text != "modificar")
            {
                BCancelar.Enabled = true;
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {

            // Combinar apellido y nombre
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas elminar el Cliente: " + label1.Text + " ?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                label1.Text = "modificar";
                BCancelar.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}