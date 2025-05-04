namespace Data;
public class Abbrev
{
  public static string AbbrevName(string name)
  {
    string[] FirstAndLastName = name.Split(" ");
    string FirstName = FirstAndLastName[0].Remove(1).ToUpper();
    string LastName = FirstAndLastName[1].Remove(1).ToUpper();
    string result = FirstName + "." + LastName;
    return result;
  }
}