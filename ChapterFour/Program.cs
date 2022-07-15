using System;

namespace ChapterFour
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("QUESTION 1");

            Console.WriteLine("Hello World!");
            Console.Write("Enter your number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2 + num3;
            Console.WriteLine("The sum of the three numbers are: " sum);

            Console.WriteLine("QUESTION 2");
            
            double r,paramenter;
            double PI = 3.14;
            Console.WriteLine("Enter the radius of the circle: ");
            r = Convert.ToInt32(Console.ReadLine());
            paramenter = 2 * PI * r;
            double area = Math.PI * r * r;
            Console.WriteLine("The Paramenter and area of the circle is: " + area +" and "+ paramenter + " respectively");

            Console.Write("QUESTION 3");

            Console.Write("Please write your company name: ");
            string companyName = Console.ReadLine();
 
            Console.Write("Please write your company address: ");
            string companyAddress = Console.ReadLine();
 
            Console.Write("Please write your phone number: ");
            long phoneNumber = long.Parse(Console.ReadLine());
 
            Console.Write("Please write your fax number: ");
            long faxNumber = long.Parse(Console.ReadLine());
 
            Console.Write("Please write your company web-site: ");
            string webSite = Console.ReadLine();
 
            Console.Write("Please write Manager's first name: ");
            string firstName = Console.ReadLine();
 
            Console.Write("Please write Manager's last name: ");
            string lastName = Console.ReadLine();
 
            Console.Write("Please write Manager's age: ");
            byte ageManager = byte.Parse(Console.ReadLine());
 
            Console.Write("Please write Manager's phone: ");
            long phoneManager = long.Parse(Console.ReadLine());
 
            Console.WriteLine("{0}", companyName);
            Console.WriteLine("Adress: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", phoneNumber);
            Console.WriteLine("Fax. {0}", faxNumber);
            Console.WriteLine("Web-site: {0}", webSite);
            Console.WriteLine("Manager: {0}" + " " + "{1}" + " " + "(age: {2}," + " " + "tel.: {3})", firstName, lastName, ageManager, phoneManager);

            Console.Write("QUESTION 4");

            Console.WriteLine("Enter any hexa number: ");
            string hexNum = Console.ReadLine();
            Console.WriteLine("Enter any positive fractional numb: ");
            double positiveFracNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter nagative fractional number: ");
            double nagativeFracNum = double.Parse(Console.ReadLine());
            Console.WriteLine("|0 {0,-8:X}|", hexNum);
            Console.WriteLine("|{0,-10:f2}|", positiveFracNum);
            Console.WriteLine("|{0,-10:f2}|", nagativeFracNum);

            Console.WriteLine("QUESTION 5");

             int analyser = 0;
    
            Console.Write("Enter the first number: ");
            int numA = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int numB = Int32.Parse(Console.ReadLine());
    
            for (int i = numA; i <= numB; i++)
            {
                 if (i % 5 == 0) analyser++;
            }
    
            Console.WriteLine("{0} numbers found.", analyser);

            Consol.Write("QUESTION 6");

            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(console.ReadLine());
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(console.ReadLine());
            Console.WriteLine("{0} >= {1}", Math.Max(a,b), Math.Max(a,b));

            Console.WriteLine("QUESTION 7");

            int a, b, c, d, e;
            bool parseSucceed = false;

            do
            {
                Console.Write("Enter first number");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out a);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            do
            {
                Console.Write("Enter second number");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out b);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            do
            {
                Console.Write("Enter third number");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out c);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            do
            {
                Console.Write("Enter fourth number");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out d);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            do
            {
                Console.Write("Enter fifth number");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out e);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            Console.WriteLine("QUESTION 8");

             Console.WriteLine("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter forth number: ");
            double forthNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter fifth number: ");
            double fifthNumber = double.Parse(Console.ReadLine());
            
            if ((firstNumber >= secondNumber) && (firstNumber >= thirdNumber) && (firstNumber >= forthNumber) && (firstNumber >= fifthNumber))
            {
               Console.WriteLine("The biggest number is: {0}", firstNumber);
               return;
            }
            if ((secondNumber >= firstNumber) && (secondNumber >= thirdNumber) && (secondNumber >= forthNumber) && (secondNumber >= fifthNumber))
            {
              Console.WriteLine("The biggest number is: {0}", secondNumber);
              return;
            }
            if ((thirdNumber >= firstNumber) && (thirdNumber >= secondNumber) && (thirdNumber >= forthNumber) && (thirdNumber >= fifthNumber))
            {
              Console.WriteLine("The biggest number is: {0}", thirdNumber);
              return;
            }
            if ((forthNumber >= firstNumber) && (forthNumber >= secondNumber) && (forthNumber >= thirdNumber) && (forthNumber >= fifthNumber))
            {
              Console.WriteLine("The biggest number is: {0}", forthNumber);
              return;
            }
            if ((fifthNumber >= firstNumber) && (fifthNumber >= secondNumber) && (fifthNumber >= thirdNumber) && (fifthNumber >= forthNumber))
            {
              Console.WriteLine("The biggest number is: {0}", fifthNumber);
              return;
            }
            
            Conssole.Write("QUESTION 9");

            int a2,b2,c2;

               double d, x1,x2;
               Console.Write("Input the value of a : ");
               a2 = Convert.ToInt32(Console.ReadLine());
               Console.Write("Input the value of b : ");
               b2 = Convert.ToInt32(Console.ReadLine());
               Console.Write("Input the value of c : ");
               c2 = Convert.ToInt32(Console.ReadLine());

               d=b2*b2-4*a2*c2;
               if(d==0)
               {
                  Console.Write("Both roots are equal.");
                  x1=-b2/(2.0*a2);
                  x2=x1;
                  Console.WriteLine("First  Root Root1= {0}",x1);
                  Console.WriteLine("Second Root Root2= {0}",x2);
                }
                else if(d>0)
	            {
	              Console.WriteLine("Both roots are real and diff-2");

	              x1=(-b2+Math.Sqrt(d))/(2*a2);
	              x2=(-b2-Math.Sqrt(d))/(2*a2);

	              Console.WriteLine("First  Root Root1= {0}",x1);
	              Console.WriteLine("Second Root root2= {0}",x2);
	            }
                else
	               Console.WriteLine("Root are imeainary;No Solution. ");

            Console.Write("QUESTION 10");

            int suM = 0;

            Console.WriteLine("Enter number: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} number: ", i + 1);
                suM += Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of all numbers is {0}", suM);

            Console.Write("QUESTION 11");

            
            Console.WriteLine("Enter number: ");
            int length2 = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= length2; i++)
            {
                 Console.WriteLine(i);
            }

            Console.Write("QUESTION 12");

            int next = 0;
            int prev = 0;
            for (int i = 0; i < 101; i++)
            {
                if (next == 0)
                {
                    next = 1;
                }
                else
                {
                int sum = next + prev;
                prev = next;
                next = sum;
                Console.WriteLine(next);
                }
            }

            Console.Write("QUESTION 13");

             Console.WriteLine("Enter number: ");
             int theLength = Int32.Parse(Console.ReadLine());
             double precision = 1.0;

             for (int i = 2; i <= theLength; i++)
             {
                precision += (1.0 / i); 
             }

             Console.WriteLine("{0:F3}", precision);







        }
    }
}
