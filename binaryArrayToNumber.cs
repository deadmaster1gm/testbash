namespace Data;
  class Binary
    {
      public static int binaryArrayToNumber(int[] BinaryArray)
        {
          double result = 0;
        for (short i=0;i<BinaryArray.Length;i++){
          result += BinaryArray[i]*Math.Pow(2,BinaryArray.Length -(i+1));
        }
        System.Console.WriteLine(Convert.ToInt32(result));
        return Convert.ToInt32(result);
        }

        }