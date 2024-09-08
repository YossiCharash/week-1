namespace data_structures
{
    public class sebuchut
    {

        //ex 1
        public static int CalculateOddSum(int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }



        //ex2
        public static int[] FindMaximumTwo(int[] array)
        {
            int[] maximumTwo = { array[0], array[1] };
            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] > maximumTwo[0] && array[i + 1] > maximumTwo[1])
                {
                    maximumTwo[0] = array[i];
                    maximumTwo[1] = array[i + 1];
                }
            }
            ArrayOptions.printArray(maximumTwo);
            return maximumTwo;
        }

        //ex3
        public static bool ContainsNumber(int[] arr, int number)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == number)
                { return true; }
            }
            return false;
        }

        //ex4 
        public static int SumOfAllTriplets(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length - 2; i++)
            {
                for(int j = 1; j < arr.Length - 1; j++)
                {
                    for(int k = 2; k < arr.Length; k++)
                    {
                        int currentSum = arr[i] + arr[j] + arr[k];
                        if(currentSum > sum)
                        {
                            sum = currentSum;
                        }

                    }
                }
            }
            return sum;
        }

        //ex 6
        // O(n)
        public static int CountEvenNumbers(int[] array)
        {
            int current = 0;
            for(int i = 0; i > array.Length; i--)
            {
                if(array[i] % 2 == 0)
                {
                    current++;
                }
            }
            return current;
        }

   

        //ex 8
        //O(n2) + n
        public static void FindPairsWithSum(int[] array, int sum)
        {
            for (int i = 0; array[i] < array.Length; ++i)
            {
                for(int j = 1; j < array.Length - 1;j++)
                {
                    if (array[i] + array[j] == sum)
                    {
                        Console.WriteLine(array[i]+" "+ array[j]);
                    }
                }
            }
        }

        //ex 9
        //O(n) + 2 log n
        public static int[] CountFrequency(int[] array)
        {
            int[] newarr = new int[array.Length];
            for(int i = 0; array[i] < array.Length ;++i)
            {
                for(int j =1; j < array.Length -1 - i;j++)
                {
                    if(array[i] == array[j])
                    {
                        newarr[i]++;
                    }

                }
            }
            ArrayOptions.printArray(newarr);
            return newarr;
        }

 
    }
}


