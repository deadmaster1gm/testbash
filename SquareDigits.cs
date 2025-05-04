using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Data;
public class Square1
{
  public static int SquareDigits(int n)
{
  string stringSquareDigits = "";
  string digits = Convert.ToString(n);
  for (short i=0;i<digits.Length;i++) {
    string x = Convert.ToString(digits[i]);
    double y = double.Parse(x);
    double z = Math.Pow(y,2.0);
    string h = Convert.ToString(z);
    stringSquareDigits += h;
    }
    int result = Convert.ToInt32(stringSquareDigits);
    return result;
  }
}