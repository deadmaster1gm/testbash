using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;
using  System.Collections.Generic;
namespace Data
{
  public static class ArraysInversion
  {
    public static int[] InvertValues(int[] input)
    {
      List<int> result = [];
      if (input.Length == 0) {
    Console.WriteLine(input);
        return input;
      }
    for(byte i=0;i<input.Length;i++)
    {
      result.Add(input[i] *(-1));
    }
     int[] result2 = result.ToArray();
     Console.WriteLine(result2[0]);
     return result2;
    }
   }
  }