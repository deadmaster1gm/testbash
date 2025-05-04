namespace Data;
public static class Remove
{
    public static string Disemvowel(string str)
    {
        string result = "";
        foreach(char c in str) {
            if((c=='a')^(c=='A')){
                continue;
            }
            else if((c=='e')^(c=='E')){
                continue;
            }
            else if((c=='i')^(c=='I')){
                continue;
            }
            else if((c=='o')^(c=='O')){
                continue;
            }
            else if((c=='u')^(c=='U')){
                continue;
            }
            result += c;
        }
        return result;
    }
}