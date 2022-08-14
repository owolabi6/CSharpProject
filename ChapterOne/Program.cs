using System;

namespace ChapterEight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nQUESTIOIN 1");

            Console.WriteLine("151 in Binary is {0}.", Convert.ToString(151,2));
            Console.WriteLine("35 in Binary is {0}.", Convert.ToString(35, 2));
            Console.WriteLine("43 in binary is {0}.", Convert.ToString(43, 2));
            Console.WriteLine("1023 in binary is {0}.",Convert.ToString(1023, 2));
            Console.WriteLine("1024 in binary is {0}.", Convert.ToString(1024, 2));

            Console.WriteLine("\nQUESTION 2");

            Console.WriteLine("1111010110011110 in decimal is {0}.",Convert.ToInt64("1111010110011110", 2));

            string number = "1111010111001110";
            Console.WriteLine(string.Format("1111010111001110 in hexadecimal is {0:X2}", Convert.ToInt64(number,2)));
            

            Console.WriteLine("\nQUESTION 3");

           Console.WriteLine("Hexadecimal numbers in binary are: ");
            string fA = "FA";
            string hex2 = "2A3E";
            string fFFF = "FFFF";
            string hex5A0 = "5A0E9";
            Console.WriteLine("FA in binary format is: {0} ",Convert.ToString(Convert.ToInt64(fA,16), 2));
            Console.WriteLine("2A3E in binary format is: {0} ",Convert.ToString(Convert.ToInt64(hex2,16), 2));
            Console.WriteLine("FFFF in binary format is: {0} ",Convert.ToString(Convert.ToInt64(fFFF,16), 2));
            Console.WriteLine("5A0E9 in binary format is: {0} ",Convert.ToString(Convert.ToInt64(hex5A0,16), 2));

            Console.WriteLine("Hexadecimals to Decimal: ");
            string hexToDeci = "FA";
            string hex2A3E = "2A3E";
            string hexFFFF = "FFFF";
            string hex5A0E9 = "5A0E9";
            Console.WriteLine("FA in decimal format is: {0} ",Convert.ToInt64(hexToDeci,16));
            Console.WriteLine("2F3E in decimal format is: {0} ",Convert.ToInt64(hex2A3E,16));
            Console.WriteLine("FFFF in decimal format is: {0} ",Convert.ToInt64(hexFFFF,16));
            Console.WriteLine("5A0E9 in decimal format is: {0}",Convert.ToInt64(hex5A0E9,16));

            Console.WriteLine("\nQUESTION 4");

            Console.Write("Enter Decimal number: ");
            int decInput = int.Parse (Console.ReadLine());
            Console.WriteLine("Binary number: {0}", Convert.ToString(decInput,2));
            
            

            Console.WriteLine("\nQUESTION 5");

            Console.WriteLine("Enter Binary Number: ");
            string biInput = Console.ReadLine();
            Console.WriteLine("Decimal output: {0}", Convert.ToInt32(biInput,2));

            Console.WriteLine("\nQUESTION 6");

            Console.WriteLine("Dec to Hex: ");
            int decValue = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("{0:x}", decValue));

            Console.WriteLine("\nQUESTION 7");

            Console.WriteLine("Hex to Decimal: ");
            string hexValue = Console.ReadLine();
            Console.WriteLine(Convert.ToInt64(hexValue,16));

            Console.WriteLine("\nQUESTION 8");

            Console.WriteLine("Hex to Binary: ");
            string hexInput = (Console.ReadLine());
            Console.WriteLine(Convert.ToString(Convert.ToInt64(hexInput,16), 2));
         
            Console.WriteLine("\nQUESTION 9");
         
            Console.WriteLine("Binary to hex: ");
            string biValue = (Console.ReadLine());
            Console.WriteLine(string.Format("{0:X2}", Convert.ToInt64(biValue,2)));

         Console.WriteLine("\nQUESTION 10");
         int deci = 0;
         Console.WriteLine("Enter binary number: ");
         string binary = Console.ReadLine();
         int power = binary.Length - 1;
         
         for (int b = 0; b < binary.Length; b++)
         {
            deci += (int)(int.Parse(binary[b].ToString())*Math.Pow(2, power));
            power--;
         }
         Console.WriteLine("Result is {0}.", deci);

          

         Console.WriteLine("\nQUESTION 12");
         String result = "";
            Console.Write("Enter Arabic number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            int thousands = i / 1000, hundreds = (i / 100) % 10, tens = (i / 10) % 10, ones = i % 10;

            switch (thousands)
            {
                case 1: result += "M";
                 break;
                case 2: result += "MM";
                 break;
                case 3: result += "MMM";
                 break;                
            }

            switch (hundreds)
            {
                case 1: result += "C";
                 break;
                case 2: result += "CC";
                 break;
                case 3: result += "CCC";
                 break;
                case 4: result += "CD";
                 break;
                case 5: result += "D";
                 break;
                case 6: result += "DC";
                 break;
                case 7: result += "DCC";
                 break;
                case 8: result += "DCCC";
                 break;
                case 9: result += "CM";
                 break;
            }

            switch (tens)
            {
                case 1: result += "X";
                 break;
                case 2: result += "XX";
                 break;
                case 3: result += "XXX";
                 break;
                case 4: result += "XL";
                 break;
                case 5: result += "L";
                 break;
                case 6: result += "LX";
                 break;
                case 7: result += "LXX";
                 break;
                case 8: result += "LXXX";
                 break;
                case 9: result += "XC";
                 break;
            }

            switch (ones)
            {
                case 1: result += "I";
                 break;
                case 2: result += "II"; 
                break;
                case 3: result += "III";
                 break;
                case 4: result += "IV";
                 break;
                case 5: result += "V";
                 break;
                case 6: result += "VI";
                 break;
                case 7: result += "VII";
                 break;
                case 8: result += "VIII";
                 break;
                case 9: result += "IX";
                 break;
            }

            Console.WriteLine("Roman number is " + result);
         Console.WriteLine("\nQUESTION 13");

         int s,d;

         Console.WriteLine("Enter N: ");
         string n = Console.ReadLine();
         
         do
         {
            Console.WriteLine("Enter s:  ");
            s = int.Parse(Console.ReadLine());
         } while (s != 2 && s != 8 && s != 10 && s != 16);

         do
         {
             Console.WriteLine("Enter d:  ");
            d = int.Parse(Console.ReadLine());
         } while (d != 2 && d != 8 && d != 10 && d != 16);

         n = Convert.ToString(Convert.ToInt32(n,s), d);
         Console.WriteLine("THe result  is {0}.", n);


        }
    }
}
