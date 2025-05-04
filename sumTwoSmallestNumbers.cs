namespace Data;
public static class SmallNumbers
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{   
        for (int i=0;i<numbers.Length;i++)
        {
            for (int j=i+1;j<numbers.Length;j++)
            {
                if(numbers[i]>numbers[j])
                {
                    int temp = numbers[i];
                    numbers[i]=numbers[j];
                    numbers[j]=temp;
                }
            }
        }
        return numbers[0] + numbers[1];
	}
}