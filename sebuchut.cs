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
        //public static int SumOfAllTriplets(int[] arr)
        //{
        //    for (int i = 0;i < arr.Length -2;i++)
        //    {
        //        for(int j = 1; j < arr.Length-1;j++)
        //        {
        //            for(int k = 2; k < arr.Length;k++)
        //            {
        //                int currentSum = arr[i] + arr[j] + arr[k];

        //            }
        //        }
        //    }
        //}
        //public static int[] FindLastClosePairWithProduct(int[] array, int product)
        //{
            
        //    for (int i = array.Length;i > 0 -1;i--)
        //    {

        //    }
        //}

        //bubbel sort
        public static int[] BubbleSort(int[] arr)
        {
            int temp = 0;
            for (int i = 0;i < arr.Length -1;i++)
            {
                for(int j = 0; j < arr.Length -i -1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j +1 ] = temp;
                    }
                  
                }
                
            }
            ArrayOptions.printArray(arr);
            return arr;
        }

        //merge sort
        public static void MergeSort() { }


        //Insert sort
        public static void InsertSort(int[] array)
        {
            int temp;
            for (int i = 1;i<array.Length;i++)
            {
                for(int j = i; j > 0 && array[j] < array[j-1]; j--)
                {
                    temp = array[j-1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                }
            }
            ArrayOptions.printArray(array);
        }


        //selection sort
        public static void SelectionSort(int[] array)
        {
            int temp;
            int min = array[0];
            for (int i = 0; i<array.Length;i++)
            {
                for (int j = 0; j < array.Length -i -1; j++)
                {
                    if(min > array[j +1] )
                    {
                        temp = array[j];
                        array[i] = array[j+1];
                        array[j+1] = temp;
                   
                    }
                }
            }
            ArrayOptions.printArray(array);
        }



    }

}
