using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Practico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarImagenPorDefecto();
        }

        private void InicializarImagenPorDefecto()
        {
            string ejecutablePath = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(ejecutablePath, "imagenes\\usuario.png");
            imagePath = imagePath.Replace("\\bin\\Debug\\net7.0-windows\\", "\\");
            PUsuario.Image = Image.FromFile(imagePath);
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TNombre.SelectionStart == 0)
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TApellido.SelectionStart == 0)
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BSeleccionarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaImagenSeleccionada = openFileDialog.FileName;
                    PUsuario.Image = Image.FromFile(rutaImagenSeleccionada);
                    TFoto.Text = rutaImagenSeleccionada;
                }
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            string nombre = TNombre.Text.Trim();
            string apellido = TApellido.Text.Trim();
            DateTime fecha = DTFecha.Value;
            string genero = "";
            string saldo = TSaldo.Text.Trim();
            Image foto = PUsuario.Image;
            string rutaFoto = TFoto.Text.Trim();

            if (RHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (RMujer.Checked)
            {
                genero = "Mujer";
            }

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(genero) || string.IsNullOrWhiteSpace(saldo) || string.IsNullOrWhiteSpace(rutaFoto))
            {
                MostrarAdvertencia("Por favor complete todos los campos.");
            }
            else
            {
                AgregarFilaDataGridView(nombre, apellido, fecha, genero, saldo, foto, rutaFoto);
                LimpiarCamposFormulario();
            }
        }

        private void AgregarFilaDataGridView(string nombre, string apellido, DateTime fecha, string genero, string saldo, Image foto, string rutaFoto)
        {
            int rowIndex = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowIndex].Cells["Nombre"].Value = nombre;
            dataGridView1.Rows[rowIndex].Cells["Apellido"].Value = apellido;
            dataGridView1.Rows[rowIndex].Cells["FechaNacimiento"].Value = fecha.ToString("dd/MM/yyyy");
            dataGridView1.Rows[rowIndex].Cells["Eliminar"].Value = "Eliminar";
            dataGridView1.Rows[rowIndex].Cells["Sexo"].Value = genero;
            dataGridView1.Rows[rowIndex].Cells["Saldo"].Value = saldo;
            dataGridView1.Rows[rowIndex].Cells["Foto"].Value = ResizeImage(foto, 50, 50);
            dataGridView1.Rows[rowIndex].Cells["Ruta"].Value = rutaFoto;

            if (Convert.ToInt32(saldo) <= 50)
            {
                dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
            }

            AjustarTamañoCeldasDataGridView();
        }

        private void AjustarTamañoCeldasDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Update();
        }

        private void LimpiarCamposFormulario()
        {
            TNombre.Clear();
            TApellido.Clear();
            DTFecha.Value = DateTime.Now;
            TSaldo.Clear();
            RHombre.Checked = false;
            RMujer.Checked = false;
            TFoto.Clear();
            InicializarImagenPorDefecto();
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
