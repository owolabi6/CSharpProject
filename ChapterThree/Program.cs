using System;

namespace ChapterThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             Console.WriteLine("QUESTION 1");

            Console.Write("Enter input:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Number: {number} is even? {number % 2 ==0}");
            Console.WriteLine($"The Number : {number} is odd?{number % 2 !== 0}");

            Console.WriteLine("QUESTION 2");

            Console.Write("Enter a number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Is the number {number2} is divisible by both 5 and 7 { (number2 % 5 ==0) && (number2 % 7 ==0)}");
            
            Console.WriteLine("QUESTION 3");
            Console.WriteLine("Enter input: ");
            int numberInput = Convert.ToInt32(Console.ReadLine());
            bool remainder =(numberInput / 100) % 10 == 7? true : false;
            Console.WriteLine("The third digit of {0} is 7", numberInput, );

            Console.WriteLine("QUESTION 4");

            int num = 345;
            Console.WriteLine("The third bit of the {0} is 1? {1}", num, ((num >>3) && 1)==1);

            Console.WriteLine("QUESTION 5");

            Console.Write("Enter input a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter input b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter input height: ");
            Int h = Convert.ToInt32(Console.ReadLine());
            double s = (a + b) * h/2;
            Console.WriteLine($"The area of a trapezoid, a = {a} b = {b} and h = {h} is: {s}");

            Console.WriteLine("QUESTION 6");

            Console.Write("Enter a: ");
            int inputA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");  
            int inputB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S ={0}, P = {1}", inputA * inputB, (inputA + inputB) * 2);

            Console.Write("QUESTION 7");

            Console.Write("Enter the person weigth: ");
            double weigth = Convert.ToDouble(Console.ReadLine());
            double percentage = 17d/100;
            Console.WriteLine($"The weigth of yhe man on the moon with {weigth} on earth is: {weigth * (percentage)}");

            Console.Write("QUESTION 8");

            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console,Write("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool insideCir = (x* *+ y * y<= 5) ? true : false;
            Console.WriteLine("The point o ({0}, {1}) is inside K ((0,0),5)?: {2}", x, y, insideCir);

            Console.WriteLine("QUESTION 9");

            Console.Write("Enter input X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter input Y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        double d= (x*x) + (y*y);
        if(d<=25)
        {
            Console.WriteLine("It is within the circle");
        }
        else
        {
            Console.WriteLine("It is not within the circle!");
        }

            Console.WriteLine("QUESTION 10");

            Console.WriteLine("Enter num:");
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


            Console.Write("QUESTION 12");

            Console.Write("Enter N: ");
            int inputV = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter V: ");  
            int inputP = Convert.ToInt32(Console.ReadLine());
            int inputOne = 1 << P;
            bool valueOne = (inputV & inputOne) != 0? true : false;
            Console.WriteLine("The bit at position {0} of number {1} is 1? {2}", inputP, inputV, valueOne);

            Console.WriteLine("QUESTION 13");

            int n =350;
            int p = 3;
            int v = 0;
            n = (v == 0) ? n = n & (~(1 << p)) : n =n |(1 << p);
            Console.WriteLine(n); 
            
            Console.Write("QUESTION 14");
            Console.Write("Enter an input: ");
            int input= Convert.ToInt32(Console.ReadLine());
            bool primeNum = true;
            if (input > 2)
            for (int i = 2; i < Mayh.Ceiling(Math.Sqrt(input)); i++)
            {
                if (input % i == 0) primeNum  = false;
            }
            Console.WriteLine("{0} is prime? : {1}", input, primeNum);

            Console.Write("QUESTION 15");

            uint n;
            Console.Write("Enter the unsigned integer number n:");
            bool isnInt = uint.TryParse(Console.ReadLine(), out n);
            if (isnInt)
            {
                Console.WriteLine("binary initial n:");
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
 
                n = ((~(7u << 24 | 7u << 3)) & n) | (((n & (7u << 3)) << 21) | ((n & (7u << 24)) >> 21));//Swap bits 3,4,5 with 24,26,26
 
                Console.WriteLine("binary new n:");
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }

            Console.Write("QUESTION 16");

             uint n;
            byte p, q, k;
            Console.Write("Enter the unsigned integer number n:");
            bool isnInt = uint.TryParse(Console.ReadLine(), out n);
            Console.Write("Enter the start position of the first bit sequence p:");
            bool ispByte = byte.TryParse(Console.ReadLine(), out p);
            Console.Write("Enter the start position of the second bit sequence q:");
            bool isqByte = byte.TryParse(Console.ReadLine(), out q);
            Console.Write("Enter the lenght of the sequence k:");
            bool iskByte = byte.TryParse(Console.ReadLine(), out k);
 
            if (isnInt&ispByte&isqByte&iskByte)
            {
                if ((p + k) < 31 && (q + k) < 31 && (Math.Abs(p - q) >= k))
                {
                    if (p > q)
                    {
                        byte temp = q;
                        q = p;
                        p = temp;
                    }
                    Console.WriteLine("binary initial n:");
                    Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
 
                    n = ((~(((uint)Math.Pow(2, k) - 1) << q | ((uint)Math.Pow(2, k) - 1) << p)) & n) | (((n & (((uint)Math.Pow(2, k) - 1) << p)) << (Math.Abs(p-q))) | ((n & (((uint)Math.Pow(2, k) - 1) << q)) >> (Math.Abs(p-q))));//Swap bits p with bits q
                    Console.WriteLine("binary new n:");
                    Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
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
