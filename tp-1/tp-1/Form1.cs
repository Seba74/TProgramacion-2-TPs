namespace Prueba
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el apellido y el nombre de los TextBox
            string apellido = textBox1.Text;
            string nombre = textBox2.Text;

            // Combinar apellido y nombre
            string nombreCompleto = $"{apellido}, {nombre}";

            // Mostrar el resultado en el TextBox3
            textBox3.Text = nombreCompleto;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Borrar el contenido del TextBox3
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}