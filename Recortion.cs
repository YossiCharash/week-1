using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures
{
    public class Recortion
    {
        //ex 1
        public static int multiply(int a, int b)
        {
            if(b == 0)
               { return 1; }
            else
            {
                return multiply(a+a,b-1);
            }
        }


        //ex 2
        public static int sumOfDigits(int num)
        {
            if(num / 10 == 0)
            {
                return num;
            }
            return num % 10  +(sumOfDigits(num / 10));
        }

        //ex 3
        public static int power(int a,int b)
        {
            if(b == 0 ||b ==1)
            { return 1; }
            return a * power(a, b - 1);
        }

        //ex 4



    }
}
