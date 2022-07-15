
using System;

namespace ChapterSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 1");

            Console.Write("Enter your number: ");
            int number = Int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("QUESTION 2");

            Console.WriteLine("Please enter your number: ");
            int n = int.Parse(Console.ReadLine());
 
             for (int i = 1; i <= n; i++)
            {
            if (i % 3 == 0)
            {
                continue;
            }
            else if (i % 7 ==0)
            {
                continue;
            }
            Console.Write("{0} ", i);
            }

            Console.WriteLine("QUESTION 3");
            int m;
            float large;
            float small;
            int[] a1 = new int [50];

            Console.Write("Enter array size: ");
            string s = Console.ReadLine();
            m = Int32.Parse(s);
            Console.Write("Enter the array elements: ");
            for (int i = 0; i < m; i++)
            {
                string s1 = Console.ReadLine();
                a1[i] = Int32.Parse(s1);
            }
            Console.WriteLine("");
            large = a1[0];
            small = a1[0];

            for (int i = 1; i < m; i++)
            {
                if (a1[i] > large)
                {
                    large = a1[i];
                }
                else if (a1[i] < small)
                {
                    small = a1[i];
                }
            }

            Console.WriteLine("The largest element in the array is {0}", large);
            Console.WriteLine("The smallest element in the array is {0}", small);

            Console.WriteLine("QUESTION 4");

             for (int i = 2; i <= 14; i++)
            {
              for (int j = 5; j < 7; j--)
            {
                if (i < 11)
                {
                    Console.Write("{0}{1} ", i, (char)j);
                }
                switch (i)
                {
                    case 11: Console.Write("J{0} ", (char)j);
                        break;
                    case 12: Console.Write("Q{0} ", (char)j);
                        break;
                    case 13: Console.Write("K{0} ", (char)j);
                        break;
                    case 14: Console.Write("A{0} ", (char)j);
                        break;
                }
                if (j == 3)
                {
                    j = 7;
                }
                if (j == 6)
                {
                    break;
                }
            }
            }

            
            Console.WriteLine("QUESTION 5");

             Console.WriteLine("Please enter your number:");
             int num = int.Parse(Console.ReadLine());
 
             if (num == 0)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            else if (num == 1)
            {
                Console.WriteLine(0);
                return;
            }
 
             int x1 = 0;
             int x2 = 1;
             Console.Write("{0} {1} ", x1, x2);
 
            for (int i = 2; i < num; i++)
            {
               int x3 = x1 + x2;
               Console.Write("{0} ", x3);
               x1 = x2;
               x2 = x3;
            }

            Console.WriteLine("QUESTION 6");

            Console.Write("Enter N: (1<K<N)");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: (1<K<N)");
            int k = int.Parse(Console.ReadLine());

            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }
            for (int i = k -1; i > 0; i--)
            {
                k *= i;
            }

            n /= k;
            Console.WriteLine("The result is {0}", n);

            Console.Write("QUESTION 7");

            Console.Write("Enter N: (1<K<N)");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Enter K: (1<K<N)");
            int k2 = int.Parse(Console.ReadLine());
            int nMinusK = n2 - k2;
            for (int i = n2 -1; i > 0; i--)
            {
                n2 *= i;
            }
            for (int i = k2 -1; i > 0; i--)
            {
                k2 *= i;
            }
            for (int i = nMinusK -1; i > 0; i--)
            {
                nMinusK *= i;
            }
            Console.WriteLine("The resukt is {0}", n2 * k2 / nMinusK);

            Console.WriteLine("QUESTION 8");


            Console.Write("QUESTION 9");

            int sum = 1;
            int temp = 1;
            Console.Write("Enter n value: ");
            int nValue = int.Parse(Console.ReadLine());
            Console.Write("Enter x value: ");
            int xValue = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nValue; i++)
            {
                temp *= i / xValue;
                sum += temp;
            }
            Console.WriteLine("The results is {0}", sum);

            Console.Write("QUESTION 10");

            Console.Write("Enter N: ");
            int valueN = int.Parse(Console.ReadLine());

            for (int i = 1; i < valueN; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    Console.WriteLine("{0}", j);
                }
            }

            Console.Write("QUESTION 11");

            Console.Write("Enter N value: ");
            decimal n3 = int.Parse(Console.ReadLine());
            int zero = 0;

            for (int i = (int) (n3 - 1); i > 0; i--)
            {
                n3 *= i;
            }
            Console.WriteLine("N! is {0} and it ends ", n3);

            do
            {
                n3 /= 10;
                zero++;
            } while (n3 % 10 == 0);

            Console.WriteLine("with {0} zero.", zero);

            Console.Write("QUESTION 12")

             Console.Write("Enter Decimal number: ");
             int decInput = int.Parse (Console.ReadLine());
             Console.WriteLine("Binary number: {0}", Convert.ToString(decInput,2));



             Console.WriteLine("QUESTION 13");

             Console.WriteLine("Enter Binary Number: ");
             string biInput = Console.ReadLine();
             Console.WriteLine("Decimal output: {0}", Convert.ToInt32(biInput,2));


           Console.WriteLine("QUESTION 14");

           Console.WriteLine("Dec to Hex: ");
           int decValue = int.Parse(Console.ReadLine());
           Console.WriteLine(string.Format("{0:x}", decValue));


            Console.WriteLine("QUESTION 15"); 

            Console.WriteLine("Hex to Decimal: ");
            string hexValue = Console.ReadLine();
            Console.WriteLine(Convert.ToInt64(hexValue,16));


            Console.WriteLine("QUESTION 16");

            

            Console.WriteLine("QUESTION 17");

            Console.WriteLine("Enter  number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter  number: ");
            int b = Int32.Parse(Console.ReadLine());

            while (a !=0 && b != 0)
            {
                if (a > b)
                {
                     a %= b;
                }
                else 
                {
                    b %= a;
                }    
            }

            if ( a == 0)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
            }

            Console.Write("QUESTION 18");



        }
    }
}
