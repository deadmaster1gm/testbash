using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;

namespace Data;
public class Consecutive
{
  public static object FirstNonConsecutive(int[] arr)
  {
    if (arr.Length<=1){
      return null;
    }
    for (int i=0;i<=arr.Length-2;i++){
      if ((arr[i+1]-arr[i])>1){
        return arr[i+1];
      }
    }
    return null;
  }
}