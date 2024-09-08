namespace data_structures
{
    public class Recortion
    {
        //ex 1
        public static int multiply(int a, int b)
        {
            if(b == 0)
            { return a; }
            else
            {
                return multiply(a + a, b - 1);
            }
        }


        //ex 2
        public static int sumOfDigits(int num)
        {
            if(num / 10 == 0)
            {
                return num;
            }
            return num % 10 + (sumOfDigits(num / 10));
        }

        //ex 3
        public static int power(int a, int b)
        {
            if(b == 0)
            { return 1; }
            if(b == 1)
            { return a; }
            return a * power(a, b - 1);
        }

        //ex 4
        public static int reversed(int number)
        {
            if(number % 10 == 0)
                return number;
            return (number / 10) * 10 + reversed(number % 10);
        }

        //ex 5
        public static int findSum(int[] arr, int index)
        {
            if(index == 0)
            { return arr[0]; }
            return arr[index] + findSum(arr, index - 1);
        }

        //ex 6
        public static int divide(int number1, int number2)
        {
            if(number2 == 0)
            {
                return number1;
            }
            if(number1 < number2)
            {
                return 0;
            }
            return 1 + divide(number1 - number2, number2);
        }


        //ex 7
        public static bool isPalindrome(string polindrom)
        {
            if(polindrom.Length <= 1)
            { return true; }
            if(polindrom[0] != polindrom[polindrom.Length - 1])
            {
                return false;
            }
            return isPalindrome(polindrom.Substring(1, polindrom.Length - 1));
        }

        //ex 8 
        public static string decimalToBinary(int number)
        {
            if(number <= 1)
                return number.ToString();
            return decimalToBinary(number / 2) + (number % 2).ToString();
        }

        //ex 9 
        public static int gcd(int number1, int number2)
        {
            if(number2 == 0)
            { return number1; }
            return gcd(number2, number1 % number2);
        }


        //ex 10
        public static void evenNumbers(int num, int exp = 2)
        {
            if(exp >= num)
            { return; }
            Console.WriteLine(exp);
            evenNumbers(num, exp + 2);
        }

        //ex 11
        public static int findMax(int[] arr, int index)
        {
            if(index == arr.Length - 1)
            { return arr[index]; }
            int max = findMax(arr, index + 1);
            return Math.Max(arr[index], max);
        }



    }
}

