namespace Data;
public static class Year
{
  public static int СenturyFromYear(int year)
  {
    int integer = (year / 100);
    int fractional = (year % 100);
    if (fractional != 0){
        integer++;
        // Console.WriteLine(integer);
    }
    return integer;
  }
}