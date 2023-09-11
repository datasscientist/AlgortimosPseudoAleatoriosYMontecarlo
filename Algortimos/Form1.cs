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

            PruebaChiCuadrada chi = new PruebaChiCuadrada();

            DateTime tiempoActual = DateTime.Now;
            int semilla = tiempoActual.Millisecond;
            int cantidad = 100;


            // Método de Cuadrado Medio
            List<double> numerosGenerados = algs.CongruencialMultiplicativo(16807, 2147483647, semilla, cantidad);

            double chi_score = chi.PruebaDeChi(numerosGenerados, 10);

            textBox1.Text = chi_score.ToString();



        }
    }
}