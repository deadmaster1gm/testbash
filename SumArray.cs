using System.IO.Pipelines;

namespace Data;
public class Sum
{
  public static double SumArray(double[] array)
  {
    if(array.Length==0){
        return 0;
    }
    else if(array.Length==1){
        return array[0];
    }
    double result = 0;
    foreach (double c in array){
        result += c;
    }
    return result;
  }
}