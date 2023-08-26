namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void LDni_Click(object sender, EventArgs e)
        {

        }

        private void LApellido_Click(object sender, EventArgs e)
        {

        }

        private void LNombre_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string dni = TDni.Text;

            string apellido = TApellido.Text;

            string nombre = TNombre.Text;

            string phone = TTelefono.Text;


            bool naranjaCheck = CNaranja.Checked;

            bool visaCheck = CVisa.Checked;

            bool mastercardCheck = CMaster.Checked;

            bool varon = RBVaron.Checked;

            bool mujer = RBMujer.Checked;



            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!naranjaCheck && !visaCheck && !mastercardCheck)
            {
                MessageBox.Show("Seleccione al menos un método de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (varon == false && mujer == false)
            {
                MessageBox.Show("Seleccione su genero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Cliente?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    LModificar.Text = $"{nombre} {apellido}";
                    MessageBox.Show("“El Cliente:" + " " + LModificar.Text + " " + "se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ask == DialogResult.No)
                {

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dni = TDni.Text;

            string apellido = TApellido.Text;

            string nombre = TNombre.Text;

            string phone = TTelefono.Text;


            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(phone) || LModificar.Text == "modificar")
            {
                MessageBox.Show("No Hay usuario para Eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Está apunto de eliminar el Cliente:" + " " + LModificar.Text, "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (ask == DialogResult.OK)
                {
                    TDni.Text = "";
                    TApellido.Text = "";
                    TNombre.Text = "";
                    TTelefono.Text = "";
                    CNaranja.Checked = false;
                    CVisa.Checked = false;
                    CMaster.Checked = false;
                    RBMujer.Checked = false;
                    RBVaron.Checked = true;

                    string image = Path.Combine(Application.StartupPath, "images", "man.png");
                    image = image.Replace("bin\\Debug\\net7.0-windows\\", "");
                    pictureBox1.Image = Image.FromFile(image);

                    MessageBox.Show(LModificar.Text + " " + "se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LModificar.Text = "modificar";
                }
                else if (ask == DialogResult.Cancel)
                {

                }
            }
        }

        private void LNya_Click(object sender, EventArgs e)
        {

        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el ingreso del carácter si no es un número o control.
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LModificar_Click(object sender, EventArgs e)
        {

        }

        private void TTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CNaranja_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CVisa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CMaster_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Estas seguro que desea salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (salir == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            if (RBVaron.Checked)
            {
                RBMujer.Checked = false;
                string image = Path.Combine(Application.StartupPath, "images", "man.png");
                image = image.Replace("bin\\Debug\\net7.0-windows\\", "");
                pictureBox1.Image = Image.FromFile(image);
            }
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMujer.Checked)
            {
                RBVaron.Checked = false;
                string image = Path.Combine(Application.StartupPath, "images", "woman.png");
                image = image.Replace("bin\\Debug\\net7.0-windows\\", "");
                pictureBox1.Image = Image.FromFile(image);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}