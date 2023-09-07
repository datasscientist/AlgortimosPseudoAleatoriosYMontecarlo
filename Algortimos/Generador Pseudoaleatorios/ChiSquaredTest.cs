using System;
using System.Collections.Generic;
using System.Linq;

public class ChiSquaredTest
{
    private static List<int> ComputeFrequencies(List<double> data, List<double> bins)
    {
        List<int> frequencies = new List<int>(new int[bins.Count - 1]);
        
        foreach (var datum in data)
        {
            for (int i = 0; i < bins.Count - 1; i++)
            {
                if (bins[i] < datum && datum <= bins[i + 1])
                {
                    frequencies[i]++;
                    break;
                }
            }
        }
        
        return frequencies;
    }

    public double CalculateChiSquared(List<double> data, int intervals)
    {
        int n = data.Count;
        double expectedCount = n / (double)intervals;
        
        // Create bins for intervals
        List<double> bins = new List<double>();

        for (int i = 0; i <= intervals; i++)
        {
            bins.Add(i / (double)intervals);
        }

        // Compute observed frequencies
        List<int> observedCounts = ComputeFrequencies(data, bins);

        double chiSquared = 0;
        for (int i = 0; i < intervals; i++)
        {
            chiSquared += Math.Pow(observedCounts[i] - expectedCount, 2) / expectedCount;
        }

        return chiSquared;
    }

    public static void Main()
    {
        List<double> data = new List<double> {
    0.34, 0.9, 0.83, 0.76, 0.96, 0.99, 0.47, 0.3, 0.79, 0.71, 0.99, 0.17, 0.37, 0.51, 0.72, 0.43, 0.06, 0.39,
    0.25, 0.89, 0.87, 0.79, 0.64, 0.7, 0.77, 0.67, 0.56, 0.17, 0.82, 0.56, 0.23, 0.19, 0.82, 0.99, 0.46, 0.05, 0.54, 0.01, 0.81, 0.56, 0.97, 0.3, 0.84, 0.24, 0.4,
    0.44, 0.12, 0.81, 0.94, 0.41, 0.52, 0.05, 0.45, 0.93, 0.65, 0.66, 0.1, 0.28, 0.69, 0.94, 0.96, 0.64, 0.4,
    0.21, 0.46, 0.67, 0.74, 0.22, 0.74, 0.73, 0.99, 0.02, 0.31, 0.78, 0.05, 0.37, 0.39, 0.42, 0.42, 0.18, 0.49, 0.34, 0.75, 0.49, 0.58, 0.73, 0.05, 0.19, 0.79, 0.62,
    0.18, 0.26, 0.97, 0.88, 0.64, 0.47, 0.6, 0.11, 0.29, 0.78
};
        ChiSquaredTest test = new ChiSquaredTest();
        double result = test.CalculateChiSquared(data, 10);
        Console.WriteLine($"Chi-Squared Value: {result}");
    }
}
