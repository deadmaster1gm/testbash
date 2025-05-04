using System.IO.Pipelines;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace Data;
public class Remove
{
    public static string Remove_char(string s)
    {
        return s[1..^1] ;
    }
}   