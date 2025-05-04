using System.Diagnostics;
using System.Formats.Asn1;

namespace Data;
public class CheckObject
{
  public static bool Check(object[] a, object x)
  {
    bool result = false;
    for (byte i=0;i<a.Length;i++){
        if (a[i].Equals(x)){
            result=true;
        }
    }
    System.Console.WriteLine(result);
    return result;
  }
}