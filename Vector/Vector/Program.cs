using System;

namespace Vector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector arr = new Vector(20);
            arr.RandomFill(1, 5);

            try
            {
                arr[0] = 999;
                Console.WriteLine(arr[21]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Pair[] pairs = arr.CalculateFreq();

            for (int i = 0; i < pairs.Length; i++)
            {
                Console.Write(pairs[i] + "\n");
            }
            Console.WriteLine(); 

            Console.WriteLine(pairs);
            arr.RandomFill();
            Console.WriteLine(arr);
        }
    }
}
