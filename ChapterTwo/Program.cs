using System;

namespace ChapterTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             Console.Write("QUESTION 1");

            sbyte sbyt1 = -44;
            sbyte sby2 = -115;
            byte byt1 = 97;
            byte byt2 = 224;
            byte byt3 = 112;
            short short1 = -10000;
            ushort ushort1 = 52130;
            ushort ushort2 = 20000;
            ushort ushort3 = 1992;
            int integer = -1000000;
            uint uint1 =  4825932;
            uint uint2 = 970700000;
            ulong ulong1 = 123456789123456789 ; 

            Console.Write("QUESTION 2");
            float flow1 = 5; 
            float flow2 = -5.01;
            float flow3 = 12.345;
            double double1 = 34.56789023;
            double double2 = 8923.1234857;
            decimal decimal1 =3456.0911124875956542151256683467;

            Console.Write("QUESTION 3"); 

            bool result = false;
            Console.Write("Enter number: ");
            double doub1 = double.Parse(Console.ReadLine());
            Console.Write("Enter number: ");
            double doub2 = double.Parse(Console.ReadLine());
            double comparing = doub1 - doub2;
            comparing = Math.Abs(comparing);
            if (comparing<0.000001)
            {
                result = true;
            }
            Console.WriteLine("({0} {1}){2}", doub1,doub2, comparing);

            Console.Write("QUESTION 4");

            int variableNum = 0 * 100;
            Console.WriteLine(variableNum);

            Console.WriteLine("QUESTION 5");

            char charVariable ='\u0048' ;
            Console.WriteLine(charVariable);

            Console.WriteLine("QUESTION 6");
            bool isMale = Male;
            Console.WriteLine(isMale);

            Console.Write("QUESTION 7");
            string str1 = "Hello";
            string str2 = "World";
            object obj = str1 + " " + str2;

            Console.Write("QUESTION 8");

            string name = "Hello";
            string lastName = "World";
            object obj1 = name+ " " +lastName;
            string names = obj1.ToString();
            Console.Write("My name is " + names);

            Console.Write("QUESTION 9");

             string quote1 = "The \"use\" of quotations cause difficulties.";
            string quote2 = "\"The \"use\" of quotations cause difficulties.\"";
            
           Console.Write("QUESTION 10");

           Console.WriteLine("    o       o");
           Console.WriteLine("  oooo     oooo");
           Console.WriteLine(" oooooo   oooooo");
           Console.WriteLine("  ooooooooooooo");
           Console.WriteLine("    ooooooooo");
           Console.WriteLine("      ooooo");
           Console.WriteLine("       ooo");
           Console.WriteLine("        o");
           

           Console.WriteLine("QUESTION 11");

           Console.WriteLine("     @@");
           Console.WriteLine("    @ @");
           Console.WriteLine("   @  @");
           Console.WriteLine("  @   @");
           Console.WriteLine(" @    @");
           Console.WriteLine("@@@@@@@");

           Console.WriteLine("QUESTION 12");

           string firstName;
           string lastName;
           char gender;
           int age;
           int idNum;

           Console.WriteLine("QUESTION 13");

           int num1 = 5;
           int num2 = 10;
           int swap =num1;
           num1 = num2;
           num2 = swap;
           Console.Write("First number: " + num1);
           Console.Write("Second number: " + num2);
        }
    }
}
