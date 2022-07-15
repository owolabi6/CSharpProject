using System;

namespace ChapterEight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("QUESTIOIN 4");

            Console.WriteLine("Hello World!");

            Console.Write("QUESTION 5");

            Console.WriteLine("Good day!");

            Console.Write("QUESTION 6");

            Console.WriteLine("Haruna Abdulmalik");

            Console.Write("QUESTION 7");

            Console.WriteLine("1");
            Console.WriteLine("101");
            Console.WriteLine("1001");

            Console.Write("QUESTION 8");

            Console.WriteLine("The Current Date and Time: ");
            DateTime dateTime = DateTime.Now;
            Console.Write(dateTime);

            Console.Write("QUESTION 9");

            Console.WriteLine("The square root of 12345 is :");
            int number = 12345;
            Console.WriteLine(Math.Sqrt(number));

            Console.Write("QUESTION 10");

            for (int i = 2; i <= 100; i++) 
         {
           if (i % 2 == 0 )
           {
               Console.WriteLine("{0}", i);
           }  
           else
           {
               Console.WriteLine("{0}", -i);
           }
         }

         Console.Write("QUESTION 11");

         Console.WriteLine("Enter you age: ");
         int age = Convert.ToInt32(Console.ReadLine());
         int ageTenYears = (age + 10);
         Console.WriteLine($"Your age in ten years: {ageTenYears}");


        }
    }
}
