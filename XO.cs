namespace Data;
using System.Text.RegularExpressions;
public static class Symbols
{
  public static bool XO (string input)
  {
    string stringToLower = input.ToLower();
    Regex searchO = new Regex ("o");
    Regex searchX = new Regex ("x");
    MatchCollection firstSymb = searchO.Matches(stringToLower);
    MatchCollection secondSymb = searchX.Matches(stringToLower);
    if (firstSymb.Count == secondSymb.Count)
    {
      return true;
    }
    return false;
  }
}