namespace data_structures
{
    internal class ArrayOptions
    {
        //print array
        public static void printArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");

            }
            Console.WriteLine();
        }

        //ex 1
        public static int[] SlipeArr(int[] arr)
        {
            int[] revers = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                revers[i] = arr[arr.Length - 1 - i];
            }
            return revers;
        }

        //ex2
        public static int sumNumFromArray(int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
            return sum;
        }

        //ex3 
        public static int MinNumFromArray(int[] array)
        {
            int min = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if(min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine(min);
            return min;
        }

        //ex4
        public static int[] SortArray(int[] array1, int[] array2)
        {
            int[] sortArr = new int[array1.Length + array2.Length];
            int indexarr1 = 0;
            int indexarr2 = 0;
            int indexSortArray = 0;
            while(indexarr1 < array1.Length && indexarr2 < array2.Length)
            {
                if(indexarr1 < array1.Length)
                {
                    if(array1[indexarr1] <= array2[indexarr2])
                    {
                        sortArr[indexSortArray] = array1[indexarr1];
                        indexarr1++;
                    }
                    else
                    {
                        sortArr[indexSortArray] = array2[indexarr2];
                        indexarr2++;
                    }
                }
                indexSortArray++;
            }
            while(indexSortArray < sortArr.Length)
            {
                if(indexarr1 < array1.Length)
                {
                    sortArr[indexSortArray] = array1[indexarr1];
                    indexarr1++;
                }
                if(indexarr2 < array2.Length)
                {
                    sortArr[indexSortArray] = array2[indexarr2];
                    indexarr2++;
                }
                indexSortArray++;
            }
            printArray(sortArr);
            return sortArr;
        }

        //ex5
        public static int[] SumNum(int[] array)
        {
            int[] sumnum = new int[array.Length];
            int temp = 0;
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = 0; j < array.Length; j++)
                {
                    if(array[temp] == array[j])
                    {
                        sumnum[i]++;
                    }
                }
                temp++;
            }
            printArray(sumnum);
            return sumnum;
        }

        //ex6
        public static int average(int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum / array.Length);
            return sum / array.Length;
        }

        //ex7
        //public static int[] zigzag(int[] array)
        //{
        //    int temp = 0;
        //    for(int i = 0;i < array.Length;i++)
        //    {
        //        if
        //    }
        //}

    }
}
