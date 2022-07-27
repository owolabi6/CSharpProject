
using System;

namespace ChapterSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 1");

            Console.Write("EnteR your number: ");
            int number = int.Parse(Console.ReadLine());

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
            Console.WriteLine("{0} ", i);
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
             Console.WriteLine("{0} {1} ", x1, x2);
 
            for (int i = 2; i < num; i++)
            {
               int x3 = x1 + x2;
               Console.WriteLine("{0} ", x3);
               x1 = x2;
               x2 = x3;
            }

            Console.WriteLine("QUESTION 6");

            Console.Write("Enter N: ");
            int nValue2 = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            for (int i = nValue2 - 1; i > 0; i--)
            {
                nValue2 *= i;
            }
            for (int i = k -1; i > 0; i--)
            {
                k *= i;
            }

            nValue2 /= k;
            Console.WriteLine("The result is {0}", nValue2);

            Console.WriteLine("QUESTION 7");

            Console.WriteLine("Enter n value: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter k value: ");
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

            Console.WriteLine("Enter the N: ");
            int n3 = int.Parse(Console.ReadLine());
            int nth = 2 * n3;
            int nthPlus = n3 + 1;
            for (int i = nth -1; i > 0; i--)
            {
                nth *= i;
            }
            for (int i = nthPlus -1; i > 0; i--)
            {
                nthPlus *= i;
            }
            for (int i = n3 -1; i > 0; i--)
            {
                n3 *= i;
            }
            Console.WriteLine("The result is {0}", nth /(nthPlus * n3));

            Console.WriteLine("QUESTION 9");

            int sum = 1;
            int temp = 1;
            Console.WriteLine("Enter n value: ");
            int nValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x value: ");
            int xValue = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nValue; i++)
            {
                temp *= i / xValue;
                sum += temp;
            }
            Console.WriteLine("The results is {0}", sum);

            Console.WriteLine("QUESTION 10");

            Console.WriteLine("Enter n value: ");
            int valueN = int.Parse(Console.ReadLine());

            for (int i = 1; i < valueN; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    Console.WriteLine("{0}", j);
                }
            }

            Console.WriteLine("QUESTION 11");

            Console.WriteLine("Enter N value: ");
            decimal n4 = int.Parse(Console.ReadLine());
            int zero = 0;

            for (int i = (int) (n4 - 1); i > 0; i--)
            {
                n4 *= i;
            }
            Console.WriteLine("N! is {0} and it ends ", n4);

            do
            {
                n4 /= 10;
                zero++;
            } while (n3 % 10 == 0);

            Console.WriteLine("with {0} zero.", zero);

            Console.WriteLine("QUESTION 12");

             Console.WriteLine("Enter Decimal number: ");
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

            Random rand = new Random ();
            
           Console.WriteLine("Enter number: ");
           int randomN = int.Parse(Console.ReadLine());
           int [] array = new int[randomN];
           for (int i = 0; i < array.Length; i++)
           {
              array[i] = i;
           }
           foreach (var i in array)
           {
             int randomNum = rand.Next(0,randomN);
             int randomOrder = array[i];
             array[i] = array[randomNum];
             array[randomNum] = randomOrder;
           }
           foreach (var i in array)
           {
             Console.WriteLine(array[i]);
           }


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

            Console.WriteLine("QUESTION 18");

            Console.Write("Enter digit: ");
            int ndigit = Int32.Parse(Console.ReadLine());            
            int[,] matrix = new int[ndigit, ndigit];
            int row = 0, col = 0, direction = 0;

            for (int i = 1; i <= ndigit * ndigit; i++)
            {
                switch(direction)
                {
                    case 0:
                            if (col > ndigit - 1 || matrix[row, col] != 0)
                            {
                                direction = 1;
                                col--;
                                row++;
                            }
                            break;
                    case 1:
                            if (row > ndigit - 1 || matrix[row, col] != 0)
                            {
                                direction = 2;
                                row--;
                                col--;
                            }
                            break;
                    case 2:
                            if (col < 0 || matrix[row, col] != 0)
                            {
                                direction = 3;
                                col++;
                                row--;
                            }
                            break;
                    case 3:
                            if (row < 0 || matrix[row, col] != 0)
                            {
                                direction = 0;
                                row++;
                                col++;
                            }
                            break;
                }

                matrix[row, col] = i;                

                switch(direction)
                {
                    case 0: col++; break;
                    case 1: row++; break;
                    case 2: col--; break;
                    case 3: row--; break;
                }
            }
            for (int i = 0; i < ndigit; i++)
            {
                for (int j = 0; j < ndigit; j++)
                {
                    if (matrix[i, j] < 10) Console.Write("{0}  ", matrix[i, j]);
                    else Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
