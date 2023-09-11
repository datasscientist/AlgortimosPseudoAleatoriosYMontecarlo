using System;
using System.Collections.Generic;
using System.Linq;

public class PruebaChiCuadrada
{
    //Listas necesarias
    public List<double> rangos = new List<double>();
    public List<int> frecuenciasReales = new List<int>();
    public List<double> chis = new List<double>();
    public double frecuenciaEsperada;

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

    public List<int> ingresarValoresEnRango(List<double> numerosGenerados, List<double> rangos)
    {
        List<int> frecuencias = new List<int>(new int[rangos.Count - 1]);
        
        foreach (var k in numerosGenerados)
        {
            for (int i = 0; i < rangos.Count - 1; i++)
            {
                if (rangos[i] < k && k <= rangos[i + 1])
                {
                    frecuencias[i]++;
                    break;
                }
            }
        }
        
        return frecuencias;
    }

    public double PruebaDeChi(List<double> numerosGenerados, int cantIntervalos)
    {
        // Variables necesarias
        int n = numerosGenerados.Count;
        frecuenciaEsperada = n / (double)cantIntervalos;
        double chiSquared = 0;


        // Paso 1: Creamos los intervalos en donde los datos serán ingresados
        for (int i = 0; i <= cantIntervalos; i++)
        {
            rangos.Add(i / (double)cantIntervalos);
        }

        // Paso 2: Metemos los datos que generamos dentro de su respectivo rango
        frecuenciasReales = ingresarValoresEnRango(numerosGenerados, rangos);
      
        // Paso 3: Calculamos el valor de chi para cada uno de los rangos y el total
        for (int i = 0; i < cantIntervalos; i++)
        {
            // Paso 3.1: Calculamos el valor de chi y lo almacenamos en un vector
            double chi = Math.Pow(frecuenciasReales[i] - frecuenciaEsperada, 2) / frecuenciaEsperada;
            chis.Add(chi);

            // Paso 3.2: Calculamos el valor acumulado de chi de forma acumulada
            chiSquared += chi;
        }

        return chiSquared;
    }

    public List<double> getRangos()
    {
        return rangos;
    }
    public List<double> getChis()
    {
        return chis;
    }
    public List<int> getfrecuenciasReales()
    {
        return frecuenciasReales;
    }

    public double getFrecuenciaEsperada()
    {
        return frecuenciaEsperada;
    }
}
