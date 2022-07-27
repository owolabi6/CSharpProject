using System;

namespace ChapterTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 1");

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
            Console.WriteLine($"sbyte: {sbyt1}\nsbyte: {sby2}\nbyte: {byt1}\nbyte: {byt2}\nbyte: {byt3}\nshort: {short1}\nushort: {ushort1}\nushort: {ushort2}\nushort: {ushort3}\nint: {integer}\nuint: {uint1}\nuint: {uint2}\nulong: {ulong1}");

            Console.WriteLine("QUESTION 2");
            
            float flow1 = 5; 
            float flow2 = -5.01f;
            string strFlow2 = flow2.ToString();
            float flow3 = 12.345f;
            string strFlow3 = flow3.ToString();
            double double1 = 34.56789023;
            double double2 = 8923.1234857;
            decimal decimal1 =3456.0911124875956542151256683467m;
            Console.WriteLine($"float: {flow1}\nfloat: {flow2}\nfloat: {flow3}\ndouble: {double1}\ndouble: {double2}\ndecimal: {decimal1}");


            Console.WriteLine("QUESTION 3"); 

            bool result = false;
            Console.WriteLine("Enter number: ");
            double doub1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number: ");
            double doub2 = double.Parse(Console.ReadLine());
            double comparing = doub1 - doub2;
            comparing = Math.Abs(comparing);
            if (comparing < 0.000001)
            {
                result = true;
            }
            Console.WriteLine("({0} {1})\u2192{2}", doub1,doub2, result);

            Console.WriteLine("QUESTION 4");

            int variableNum = 0X100;
            Console.WriteLine(variableNum);

            Console.WriteLine("QUESTION 5");

            char charVariable ='\u0048' ;
            Console.WriteLine(charVariable);

            Console.WriteLine("QUESTION 6");
            bool isMale = false;
            Console.WriteLine(isMale);

            Console.WriteLine("QUESTION 7");
            string str1 = "Hello";
            string str2 = "World";
            object obj = str1 + " " + str2;

            Console.WriteLine("QUESTION 8");

            string greet = "Armin";
            string theWorld = "Arlet";
            object obj1 = greet+ " " +theWorld;
            string names = obj1.ToString();
            Console.WriteLine("My name is " + names);

            Console.WriteLine("QUESTION 9");

             string quote1 = "The \"use\" of quotations cause difficulties.";
            string quote2 = "\"The \"use\" of quotations cause difficulties.\"";
            Console.WriteLine(quote1);
            Console.WriteLine(quote2);
            
           Console.WriteLine("QUESTION 10");

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
           string companyName;

           firstName = "Eren";
           lastName = "Yerger";
           gender = 'm';
           age = 17;
           idNum = 27560000;
           companyName ="MGQS Marketing Company";
           Console.WriteLine($"One of our company {companyName} employee's details are...\nfirstname: {firstName}\nLastname: {lastName}\nAge: {age}\nGender: {gender}\nEmployee number: {idNum}");

           Console.WriteLine("QUESTION 13");

           int num1 = 5;
           int num2 = 10;
           int swap =num1;
           num1 = num2;
           num2 = swap;
           Console.WriteLine("First number: " + num1);
           Console.WriteLine("Second number: " + num2);
        }
    }
}
