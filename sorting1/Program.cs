namespace sorting1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 1, 5, 2, 7, 4, 0 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minNumbersIndex = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minNumbersIndex])
                    {
                        minNumbersIndex = j;
                    }
                }

                if (minNumbersIndex != i)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[minNumbersIndex];
                    numbers[minNumbersIndex] = temp;
                }
            }

            Console.WriteLine(string.Join(",", numbers));
      
        }
        
    }
}

