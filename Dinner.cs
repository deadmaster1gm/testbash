namespace Data;
public class DinnerD
{
    public static bool Feast(string beast, string dish)
    {   bool result = false;
        if (beast[0]==dish[0]){
            result = beast[^1]==dish[^1];
        }
        System.Console.WriteLine(result);
        return result;
    }
}