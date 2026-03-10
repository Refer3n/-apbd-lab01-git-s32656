namespace Tutorial2;

public class StatisticHelper
{
    public static double CalculateAverage(double[] numbers)
    {
        return numbers.Average();
    }

    public static double CalculateMax(double[] numbers)
    {
        return numbers.Max();
    }
    
    public static double CalculateMin(double[] numbers)
    {
        return numbers.Min();
    }
}