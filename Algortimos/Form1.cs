using Algortimos.Generador_Pseudoaleatorios;
using System.Windows.Forms;

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
            int cantidad = 10000;
            int cantIntervalos = 10;

            // Método de Cuadrado Medio
            List<double> numerosGenerados = algs.CongruencialMultiplicativo(1681, 9973, semilla, cantidad);

            double chi_score = chi.PruebaDeChi(numerosGenerados, cantIntervalos);

            textBox1.Text = chi_score.ToString();

            List<double> rangos = chi.getRangos();
            List<int> frecuenciasReales = chi.getfrecuenciasReales();
            List<double> chis = chi.getChis();
            double frecuenciaEsperada = chi.getFrecuenciaEsperada();

            llenarGrid(cantIntervalos, rangos, frecuenciasReales, chis, frecuenciaEsperada);
        }
        private void llenarGrid(int cantIntervalos, List<double> rangos, List<int> frecuenciasReales, List<double> chis, double frecuenciaEsperada)
        {

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            //Llenamos columnas
            dataGridView1.Columns.Add("1", "Rangos");
            dataGridView1.Columns.Add("2", "Frecuencias esperadas");
            dataGridView1.Columns.Add("3", "Frecuencias obtenidas");
            dataGridView1.Columns.Add("4", "Valor de Chi");


            double[] rows = new double[4];

            for (int i = 0; i < cantIntervalos; i++)
            {
                rows[0] = rangos[i];
                rows[1] = frecuenciaEsperada;
                rows[2] = frecuenciasReales[i];
                rows[3] = chis[i];

                dataGridView1.Rows.Add();
                for (int k = 0; k < 4; k++)
                {
                    dataGridView1.Rows[i].Cells[k].Value = rows[k];
                }
            }






        }

    }
}