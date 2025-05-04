using System.Reflection.Metadata.Ecma335;

namespace Data;
public class MathCheck {
    public static int AreaOrPerimeter(int l, int w) {
if (l == w){
    return l*w;
}
else if (l!=w) {
    return (l+w)*2;
}
return 0;
    }
}