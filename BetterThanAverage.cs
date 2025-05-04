using System.IO.Pipelines;

namespace Data;
public class Average
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        int average = 0;
for (byte i=0;i<ClassPoints.Length;i++){
    average += ClassPoints[i];
}
    return (average + YourPoints) / (ClassPoints.Length+1)<YourPoints;
    }

}