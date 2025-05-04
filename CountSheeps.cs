namespace Data;
public static class Sheeps
{
  public static int CountSheeps(bool[] sheeps)
  {
short result = 0;
foreach (bool c in sheeps){
    if(c){
        result++;
    }
}
return result;
  }
}