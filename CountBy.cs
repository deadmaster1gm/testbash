using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;

namespace Data;
public static class Count
{
  public static int[] CountBy(int x, int n)
  {
    List<int> list = [];
    for (int i=1; i<=n; i++){
        list.Add(i*x);
    }
    int[] result = list.ToArray();
    return result;
  }
}