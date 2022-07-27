using System;

namespace ChapterThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 1");

            Console.WriteLine("Enter input:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Number: {number} is even? {number %2 == 0}");
            Console.WriteLine($"The Number : {number} is odd?{number %2 != 0}");

            Console.WriteLine("QUESTION 2");

            Console.WriteLine("Enter a number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Is the number {number2} is divisible by both 5 and 7 { (number2 % 5 ==0) && (number2 % 7 ==0)}");
            
            Console.WriteLine("QUESTION 3");
            Console.WriteLine("Enter input: ");
            int numberInput = Convert.ToInt32(Console.ReadLine());
            bool remainder = (numberInput / 100) % 10 == 7? true : false;
            Console.WriteLine($"{remainder} the third digit of {numberInput} is 7");

            Console.WriteLine("QUESTION 4");

             int num = 345;
            Console.WriteLine("The third bit of the {0} is 1? {1}", num, ((num >>3) & 1)==1);

            Console.WriteLine("QUESTION 5");

            Console.WriteLine("Enter input a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter input b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter input height: ");
            int h = Convert.ToInt32(Console.ReadLine());
            double s = (a + b) * h/2;
            Console.WriteLine($"The area of a trapezoid, a = {a} b = {b} and h = {h} is: {s}");

            Console.WriteLine("QUESTION 6");

            Console.WriteLine("Enter a: ");
            int inputA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");  
            int inputB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S ={0}, P = {1}", inputA * inputB, (inputA + inputB) * 2);

            Console.WriteLine("QUESTION 7");

            Console.WriteLine("Enter the person weigth: ");
            double weigth = Convert.ToDouble(Console.ReadLine());
            double percentage = 17d/100;
            Console.WriteLine($"The weigth of the man on the moon with {weigth} on earth is: {weigth * (percentage)}");

            Console.WriteLine("QUESTION 8");

            Console.WriteLine("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool insideCir = (x*x) + (y*y) <= 5*5 ? true : false;
            Console.WriteLine("The point o ({0}, {1}) is inside K ((0,0),5)?: {2}", x, y, insideCir);

            Console.WriteLine("QUESTION 9");

            Console.WriteLine("Enter input X: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter input Y: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double d= (x2*x2) + (y2*y2);
            if(d<=25)
            {
                Console.WriteLine("It is within the circle");
            }
            else
            {
                Console.WriteLine("It is not within the circle!");
            }

            Console.WriteLine("QUESTION 10");

            Console.WriteLine("Enter four digits:");
            string numb = Console.ReadLine();
            int first = Convert.ToInt32(numb[0].ToString());
            int second = Convert.ToInt32(numb[1].ToString());
            int third = Convert.ToInt32(numb[2].ToString());
            int fourth = Convert.ToInt32(numb[3].ToString());

            Console.WriteLine($"Calculates the sum of the digits: {first}{second}{third}{fourth}");
            Console.WriteLine($"Prints on the console the number in reverse other : {fourth}{third}{second }{first}");
            Console.WriteLine($"Puts the last digit in the first position: {fourth}{first}{second}{third}");
            Console.WriteLine($"Exchange the second and the third digits : {first}{third}{second}{fourth}");

            Console.WriteLine("QUESTION 11");

            int g = 35;
            int p = 6;
            int l = 1;
            int mask = l <<p;
            Console.WriteLine((g & mask) != 0? "third bit is 1" : "Third bit is 0");


            Console.WriteLine("QUESTION 12");

            Console.WriteLine("Enter N: ");
            int inputV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter V: ");  
            int inputP = Convert.ToInt32(Console.ReadLine());
            int inputOne = 1 << inputP;
            bool valueOne = (inputV & inputOne) != 0? true : false;
            Console.WriteLine("The bit at position {0} of number {1} is 1? {2}", inputP, inputV, valueOne);

            Console.WriteLine("QUESTION 13");

            int n =350;
            int p2 = 3;
            int v = 0;
            n = (v == 0) ? n = n & (~(1 << p2)) : n =n |(1 << p2);
            Console.WriteLine(n); 
            
            Console.WriteLine("QUESTION 14");

            Console.WriteLine("Enter an input: ");
            int input= Convert.ToInt32(Console.ReadLine());
            bool primeNum = true;
            if (input > 2)
            for (int i = 2; i < Math.Ceiling(Math.Sqrt(input)); i++)
            {
                if (input % i == 0) primeNum  = false;
            }
            Console.WriteLine("{0} is prime? : {1}", input, primeNum);

            Console.WriteLine("QUESTION 15");

            uint n2;
            Console.WriteLine("Enter the unsigned integer number n:");
            bool isnInt = uint.TryParse(Console.ReadLine(), out n2);
            if (isnInt)
            {
                Console.WriteLine("binary initial n:");
                Console.WriteLine(Convert.ToString(n2, 2).PadLeft(32, '0'));
 
                n2 = ((~(7u << 24 | 7u << 3)) & n2) | (((n2 & (7u << 3)) << 21) | ((n2 & (7u << 24)) >> 21));
 
                Console.WriteLine("binary new n:");
                Console.WriteLine(Convert.ToString(n2, 2).PadLeft(32, '0'));
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }

            Console.WriteLine("QUESTION 16");

             uint n3;
            byte p3, q, k;
            Console.WriteLine("Enter the unsigned integer number n:");
            bool isN = uint.TryParse(Console.ReadLine(), out n3);
            Console.WriteLine("Enter the start position of the first bit sequence p:");
            bool ispByte = byte.TryParse(Console.ReadLine(), out p3);
            Console.WriteLine("Enter the start position of the second bit sequence q:");
            bool isqByte = byte.TryParse(Console.ReadLine(), out q);
            Console.WriteLine("Enter the lenght of the sequence k:");
            bool iskByte = byte.TryParse(Console.ReadLine(), out k);
 
            if (isN & ispByte & isqByte & iskByte)
            {
                if ((p3 + k) < 31 && (q + k) < 31 && (Math.Abs(p3 - q) >= k))
                {
                    if (p3 > q)
                    {
                        byte temp = q;
                        q = p3;
                        p3 = temp;
                    }
                    Console.WriteLine("binary initial n:");
                    Console.WriteLine(Convert.ToString(n3, 2).PadLeft(32, '0'));
 
                    n3 = ((~(((uint)Math.Pow(2, k) - 1) << q | ((uint)Math.Pow(2, k) - 1) << p3)) & n3) | (((n3 & (((uint)Math.Pow(2, k) - 1) << p3)) << (Math.Abs(p3-q))) | ((n3 & (((uint)Math.Pow(2, k) - 1) << q)) >> (Math.Abs(p3-q))));
                    Console.WriteLine("binary new n:");
                    Console.WriteLine(Convert.ToString(n3, 2).PadLeft(32, '0'));
                }
                else
                {
                    Console.WriteLine("Not a valid entry!");
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
