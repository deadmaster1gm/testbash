using System.IO.Pipelines;

namespace Data;
class Average
{
    public static double FindAverage(double[] array)
    {
        if (array.Length==0){
            return 0;
        }
        double result = 0;
        foreach (double c in array){
        result += c;
        }
        return result/array.Length;
    }
}