using System.ComponentModel;
using System.IO.Pipelines;

namespace Data;
public static class Negative
{
  public static int MakeNegative(int number)
  {
    byte mask = 0;
    if (number != 0){
        mask = 1;
        if((mask | (number >> 31))==1){
        int result = number*-1;
        return result;
         }
        }
        return number;
    }
  }