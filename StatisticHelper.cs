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
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Array cannot be empty");
        
        return numbers.Min();
    }
}