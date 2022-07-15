using System;

namespace ChapterFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("QUESTION 1");

            Console.WriteLine("Enter number: ");
            int numA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number: ");
            int numB = Int32.Parse(Console.ReadLine());

            if (numA > numB)
            {
                numA = numA + numB;
                numB = numA - numB;
                numA = numA - numB;
            }
            Console.WriteLine("The first number is {0}, the second is {1},", numA, numB);

            Console.Write("QUESTION 2");

            Console.WriteLine("Enter 3 numbers: ");
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            int num3 = Int32.Parse(Console.ReadLine());

            if ((num1 < 0 && num2 > 0 && num3 > 0) || (num2 < 0 && num1 > 0 && num3 > 0) || (num3 < 0 && num1 > 0 && num2 > 0) || (num1 < 0 && num2 < 0 && num3 < 0))
            {
                Console.WriteLine("-");
            }
            else if ((num1 < 0 && num2 < 0 && num3 > 0) || (num1 < 0 && num3 < 0 && num2 > 0) || (num2 < 0 && num3 < 0 && num1 > 0) || (num1 > 0 && num2 > 0 && num3 > 0))
            {
                Console.WriteLine("+");
            }
            else if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("0");
            }

            Console.WriteLine("QUESTION 3");

            int num1, num2, num3;
            Console.Write("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());
 
            if (num1 > num2)
           {
              if (num1 > num3)
             {
                 Console.Write("The 1st Number is the greatest among three.");
             }
             else
             {
                 Console.Write("The 3rd Number is the greatest among three.");
             }
           }
            else if (num2 > num3)
               Console.Write("The 2nd Number is the greatest among three");
            else
               Console.Write("The 3rd Number is the greatest among three");

            Console.Write("QUESTION 4");
            
            Console.WriteLine("Enter  number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter  number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter  number: ");
            int c = Int32.Parse(Console.ReadLine());

            if((a > b) && (a > c))
         {
            if(b > c)
            {
                Console.WriteLine("{0},{1},{2}", a,b,c);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", a,c,b);
            }
         }
         else if ((b > a) && (b > c))
         {
            if(a > c)
            {
                Console.WriteLine("{0} {1} {2}",b,a,c);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", b,c,a);
            }
         }
        else if((c > a) && (c > b))
            {
                if(a > b)
                {
                    Console.WriteLine("{0} {1} {2}",c,b,a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c,a,b);
                }
            }



            Console.Write("QUESTION 5");

            Console.WriteLine("Enter a number between 0 and 9:");
            string statement = Console.ReadLine();

            switch (statement)
            {
                case "0": Console.WriteLine("zero");
                break;
                case "1": Console.WriteLine("one");
                break;
                case "2": Console.WriteLine("two");
                break;
                case "3": Console.WriteLine("three");
                break;
                case "4": Console.WriteLine("four");
                break;
                case "5": Console.WriteLine("five"); 
                break;
                case "6": Console.WriteLine("six"); 
                break;
                case "7": Console.WriteLine("seven");
                break;
                case "8": Console.WriteLine("eight"); 
                break;
                case "9": Console.WriteLine("nine"); 
                break;
                default: Console.WriteLine("not a recognised digit"); 
                break;
            }
               Console.Write("QUESTION 6");

                Console.Write("Input A (not 0): ");
                sbyte a = Convert.ToSByte(Console.ReadLine());
                Console.Write("Input B: ");
                sbyte b = Convert.ToSByte(Console.ReadLine());
                Console.Write("Input C: ");
                sbyte c = Convert.ToSByte(Console.ReadLine());

                 d = (sbyte)(b * b - 4 * a * c);
                if (d < 0)
                Console.WriteLine("\nD={0}\nThere are no real roots.", d);
                else if (d == 0)
            {
                sbyte x1 = (sbyte)(-b / 2 * a);
                Console.WriteLine("\nX={0}", x1);
            }
            else
            {
                sbyte x1 = (sbyte)((-b + Math.Sqrt(d)) / (2 * a));
                sbyte x2 = (sbyte)((-b - Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("\nX1={0}\nX2={1}", x1, x2);
            }

                Console.Write("QUESTION 7");

                Console.WriteLine("Enter first number: ");
                int firstNumber = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                int secondNumber = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter third number: ");
                int thirdNumber = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter forth number: ");
                int forthNumber = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter fifth number: ");
                int fifthNumber = Int32.Parse(Console.ReadLine());

                if (firstNumber < secondNumber) firstNumber = secondNumber;
                if (firstNumber < thirdNumber) firstNumber = thirdNumber;
                if (firstNumber < forthNumber) firstNumber = forthNumber;
                if (firstNumber < fifthNumber) firstNumber = fifthNumber;

                Console.WriteLine("{0} is the biggest number, ", firstNumber);

                Console.Write("QUESTION 8");

                Console.Write("Please choose your input data type:\n 1 --> int\n 2 --> double\n 3 --> string\n ...and hit Enter");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter your INTEGER input: ");
                        int integer = int.Parse(Console.ReadLine());
                        Console.WriteLine("The result is: {0}", (integer+1));
                        break;
                    case 2:
                        Console.WriteLine("Please enter your DOUBLE input: ");
                        double doub = double.Parse(Console.ReadLine());
                        Console.WriteLine("The result is: {0}", (doub+1));
                        break;
                    case 3:   
                        Console.WriteLine("Please enter your STRING input: ");
                        string str = Console.ReadLine();
                        Console.WriteLine("The result is: {0}", (str+1));
                        break;
                    default : Console.WriteLine("INVALID!");
                        break;    
                }

            Console.Write("QUESTION 9");

            Console.Write("input 1: ");
            int a1=Convert.ToInt32(Console.ReadLine());
            Console.Write("input 2: ");
            string a2 =Convert.ToInt32 (Console.ReadLine());
            Console.Write("inpu 3: ");
            string a3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 4: ");
            string a4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 5: ");
            string a5 = Convert.ToInt32(Console.ReadLine());
            float sumAll = a1+a2+ a3+ a4 + a5;
            if (sumAll ==0)
            {
               Console.Write("they are subset" + sumAll);
            }
            else
            { 
               Console.Write("they are no subset");           
            }    

                Console.Write("QUESTION 10");

                Console.WriteLine("Please write a number between 1 and 9: ");
            int input = int.Parse(Console.ReadLine());
 
            switch (input)
           {
              case 1:
              case 2:
              case 3:
                Console.WriteLine("The bonus point is: " + (input * 10));
                break;
              case 4:
              case 5:
              case 6:
                Console.WriteLine("The bonus point is: " + (input * 100));
                break;
              case 7:
              case 8:
              case 9:
                Console.WriteLine("The bonus point is: " + (input*1000));
                break;
              default:
                Console.WriteLine("Invalid Score!");
                break;
 
            }

            Console.WriteLine("QUESTION 11");

            Console.Write("Insetr integer 0 <= n <= 999:  ");
            int? number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (number < 0)
            {
                Console.WriteLine("Error: Not valid number!");
                return;
            }

            if (number > 999)
            {
                Console.WriteLine("Error: Not valid number!");
                return;
            }

            if (number == 0)
            {
                Console.WriteLine("{0} --> zero", number);
                return;
            }


            Console.Write("{0} --> ", number);

            if ((number < 20) && (number > 9))
            {
                switch (number)
                {
                    case 10: Console.WriteLine("ten"); number = null; break;
                    case 11: Console.WriteLine("eleven"); number = null; break;
                    case 12: Console.WriteLine("twelve"); number = null; break;
                    case 13: Console.WriteLine("thirteen"); number = null; break;
                    case 14: Console.WriteLine("fourteen"); number = null; break;
                    case 15: Console.WriteLine("fifteen"); number = null; break;
                    case 16: Console.WriteLine("sixteen"); number = null; break;
                    case 17: Console.WriteLine("seventeen"); number = null; break;
                    case 18: Console.WriteLine("eighteen"); number = null; break;
                    case 19: Console.WriteLine("nineteen"); number = null; break;

                    default:
                        break;
                }
                
            }

            switch (number / 100)
            {
                case 0: break;

                case 1: if ((number / 100.0) == 1.0)
                    {
                        Console.WriteLine("one hundred"); 
                    }
                    else
                    {
                        Console.Write("one hundred and ");
                        
                    }
                    break;
                case 2: if ((number / 200.0) == 1.0)
                    {
                        Console.WriteLine("two hundred");
                    }
                    else
                    {
                        Console.Write("two hundred and ");
                    }
                    break;
                case 3: if ((number / 300.0) == 1.0)
                    {
                        Console.WriteLine("three hundred");
                    }
                    else
                    {
                        Console.Write("three hundred and ");
                    }
                    break;
                case 4: if ((number / 400.0) == 1.0)
                    {
                        Console.WriteLine("four hundred");
                    }
                    else
                    {
                        Console.Write("four hundred and ");
                    }
                    break;
                case 5: if ((number / 500.0) == 1.0)
                    {
                        Console.WriteLine("five hundred");
                    }
                    else
                    {
                        Console.Write("five hundred and ");
                    }
                    break;
                case 6: if ((number / 600.0) == 1.0)
                    {
                        Console.WriteLine("six hundred");
                    }
                    else
                    {
                        Console.Write("six hundred and ");
                    }
                    break;
                case 7: if ((number / 700.0) == 1.0)
                    {
                        Console.WriteLine("seven hundred");
                    }
                    else
                    {
                        Console.Write("seven hundred and ");
                    }
                    break;
                case 8: if ((number / 800.0) == 1.0)
                    {
                        Console.WriteLine("eight hundred");
                    }
                    else
                    {
                        Console.Write("eight hundred and ");
                    }
                    break;
                case 9: if ((number / 900.0) == 1.0)
                    {
                        Console.WriteLine("nine hundred");
                    }
                    else
                    {
                        Console.Write("nine hundred and ");
                    }
                    break;

                default: 
                    break;
            }



            switch ((number / 10) % 10)
            {
                case 0: break;
                case 1: number -= 100; break;
                case 2: Console.Write("twenty "); break;
                case 3: Console.Write("thirty "); break;
                case 4: Console.Write("forty "); break;
                case 5: Console.Write("fifty "); break;
                case 6: Console.Write("sixty "); break;
                case 7: Console.Write("seventy "); break;
                case 8: Console.Write("eighty "); break;
                case 9: Console.Write("ninety "); break;
                default:
                    break;
            }

            switch (number)
            {
                case 10: Console.WriteLine("ten"); number = null;  break;
                case 11: Console.WriteLine("eleven"); number = null; break;
                case 12: Console.WriteLine("twelve"); number = null; break;
                case 13: Console.WriteLine("thirteen"); number = null; break;
                case 14: Console.WriteLine("fourteen"); number = null; break;
                case 15: Console.WriteLine("fifteen"); number = null; break;
                case 16: Console.WriteLine("sixteen"); number = null; break;
                case 17: Console.WriteLine("seventeen"); number = null; break;
                case 18: Console.WriteLine("eighteen"); number = null; break;
                case 19: Console.WriteLine("nineteen"); number = null; break;
            
                default:
                    break;
            }

            switch (number % 10)
            {
                case 0: Console.WriteLine(); break;          
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;

                default:
                    break;
            }    
            
            
        }
    }
}
