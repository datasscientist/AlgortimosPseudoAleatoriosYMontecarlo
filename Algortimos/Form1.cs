using Algortimos.Generador_Pseudoaleatorios;

namespace Algortimos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlgoritmosPseudoAleatorios algs = new AlgoritmosPseudoAleatorios();

            DateTime tiempoActual = DateTime.Now;
            int semilla = tiempoActual.Millisecond;
            int cantidad = 1;


            // Método de Cuadrado Medio
            List<int> numerosGenerados = algs.CuadradoMedio(semilla, cantidad);

            textBox1.Text = numerosGenerados[0].ToString();


        }
    }
}