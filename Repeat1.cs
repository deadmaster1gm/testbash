namespace Data
{
  public static class RepeatStr
   {
    public static string Repeat(int n, string s)
    {
      string result = "";
      for (byte i=0; i<n; i++){
        result+=s;
      }
      return result;
    }
  }
}