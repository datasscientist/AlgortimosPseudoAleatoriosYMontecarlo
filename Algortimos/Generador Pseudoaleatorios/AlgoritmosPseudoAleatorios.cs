using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algortimos.Generador_Pseudoaleatorios
{
    public class AlgoritmosPseudoAleatorios
    {
        //Algoritmos no congruenciales
        public List<double> CuadradoMedio(int semilla, int cantidad)
        {
            List<double> numerosGenerados = new List<double>();

            for (int i = 0; i < cantidad; i++)
            {
                // Paso 2: Cuadra la semilla
                long semillaCuadrada = (long)semilla * semilla;

                // Paso 3: Toma los dígitos del medio como el número generado y la nueva semilla
                string semillaStr = semillaCuadrada.ToString().PadLeft(8, '0'); // Asegura que tenga 8 dígitos
                int inicio = (semillaStr.Length - 4) / 2;
                int fin = inicio + 4;
                int numeroGenerado = int.Parse(semillaStr.Substring(inicio, 4));

                // Ajusta el número generado al rango del 1 al 9
                numeroGenerado = 1 + (numeroGenerado % 9);

                semilla = numeroGenerado;

                numerosGenerados.Add(numeroGenerado);
            }

            return numerosGenerados;
        }

        public List<double> ProductoMedio(int semilla1, int semilla2, int cantidad)
        {
            List<double> numerosGenerados = new List<double>();

            for (int i = 0; i < cantidad; i++)
            {
                // Paso 1: Multiplica las semillas
                long producto = (long)semilla1 * semilla2;

                // Paso 2: Toma los dígitos del medio (por ejemplo, los 4 dígitos del medio)
                string productoStr = producto.ToString().PadLeft(8, '0'); // Asegura que tenga 8 dígitos
                int inicio = 2; // Cambia esto para tomar más o menos dígitos del medio según necesites
                int fin = inicio + 4; // Cambia esto para tomar más o menos dígitos del medio según necesites
                string numeroGeneradoStr = productoStr.Substring(inicio, 4);
                double numeroGenerado = double.Parse("0." + numeroGeneradoStr);

                // Paso 3: Actualiza las semillas para el próximo ciclo
                semilla1 = (int)producto;
                semilla2 = int.Parse(numeroGeneradoStr);

                numerosGenerados.Add(numeroGenerado);
            }

            return numerosGenerados;
        }


        // Algoritmos Congruenciales
        public List<double> CongruencialLineal(int a, int c, int m, int semilla, int cantidad)
        {
            List<double> numerosGenerados = new List<double>();

            for (int i = 0; i < cantidad; i++)
            {
                // Siguiente número pseudoaleatorio
                semilla = (a * semilla + c) % m;
                double numeroGenerado = (double)semilla / m;

                numerosGenerados.Add(numeroGenerado);
            }

            return numerosGenerados;
        }

        public List<double> CongruencialMultiplicativo(int a, int m, int semilla, int cantidad)
        {
            List<double> numerosGenerados = new List<double>();

            for (int i = 0; i < cantidad; i++)
            {
                // Siguiente número pseudoaleatorio
                semilla = (a * semilla) % m;
                double numeroGenerado = (double)semilla / m;

                numerosGenerados.Add(numeroGenerado);
            }

            return numerosGenerados;
        }

    }

}

