using System;

namespace ChapterSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 1");

            int[] arr = new int [20];

            for (int ar = 0; ar < arr.Length; ar++)
            {
                arr[ar] =ar * 5;
                Console.WriteLine(arr[ar]);
            }

            Console.WriteLine("\nQUESTION 2");

            bool arraysEqual = true;

            Console.Write("Enter lenght of first array: ");
            int length = int.Parse(Console.ReadLine());

            int[] arrA = new int[length];

            for (int q = 0; q < arrA.Length; q++)
            {
                Console.Write("Enter element {0}: ", q);
                arrA[q] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter lenght of second array: ");

            if (length != int.Parse(Console.ReadLine()))
            {
               Console.WriteLine("Arrays have different lengths.");
            }
            else
            {
                int[] arrB = new int[length];

                for (int q = 0; q < arrB.Length; q++)
                {
                    Console.Write("Enter element {0}: ", q);
                    arrB[q] = int.Parse(Console.ReadLine());
                }

                for (int q = 0; q < arrA.Length; q++)
                {
                    if (arrA[q] != arrB[q])
                    {
                        Console.WriteLine("Arrays are different.");
                        arraysEqual = false;
                        break;
                    }
                }

                if (arraysEqual) Console.WriteLine("Arrays are the same.");
            }

            Console.WriteLine("\nQUESTION 3");

            bool arrayEqual = true;
            char[] arrAB = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            char[] arrBA = new char[5] { 'a', 'b', 'c', 'd', 'e' };

            if (arrAB.Length > arrBA.Length)
            {
                Console.WriteLine("Second array is lexicographicaly first.");
            }
            else if (arrAB.Length < arrBA.Length)
            {
                 Console.WriteLine("First array is lexicographicaly first.");
            }
            else
            {
                for (int w = 0; w < arrAB.Length; w++)
                {
                    if (arrAB[w] < arrBA[w])
                    {
                        Console.WriteLine("First array is lexicographicaly first.");
                        arrayEqual = false;
                        break;
                    }
                    if (arrAB[w] > arrBA[w])
                    {
                        Console.WriteLine("Second array is lexicographicaly first.");
                        arrayEqual = false;
                        break;
                    }
                }

                if (arrayEqual) Console.WriteLine("arrays are lexicographicaly equal.");
            }

            Console.WriteLine("\nQUESTION 4");

            int count = 1, tempCount = 1, number = 0;

			Console.WriteLine ("Enter array length: ");
			int length4 = int.Parse (Console.ReadLine ());
			int[] arr2 = new int[length4];

			for (int e = 0; e < arr2.Length; e++) 
			{
				Console.WriteLine ("Enter {0} element: ", e);
				arr2 [e] = int.Parse (Console.ReadLine ());
			}

			for (int e = 0; e < arr2.Length - 1; e++) 
			{
                if (arr2[e] == arr2[e + 1]) tempCount++;
                else tempCount = 1;

				if (tempCount > count) 
				{
					count = tempCount;
					number = arr2 [e];
				}
			}

			for (int e = 0; e < count; e++)
            {
                Console.Write ("{0}, ", number);
            }

            Console.WriteLine("\nQUESTION 5");

            Console.WriteLine("Enter the array's length: ");
            int length5 = int.Parse(Console.ReadLine());

            int[] array1 = new int[length5];
            int sames = 1, bestSames = 1, bestStart = 0, lastElement = 0;

            for (int i5 = 0; i5 < array1.Length; i5 ++)
            {
                Console.Write("Enter {0} element: ", i5);
                array1[i5] = int.Parse(Console.ReadLine());
            }

            for (int i5 = 0; i5 < array1.Length - 1; i5++)
            {
                if (array1[i5] + 1 == array1[i5 + 1])
                {
                    sames++;
                    if (sames > bestSames)
                    {
                        bestSames = sames;
                        lastElement = i5 + 1;
                        bestStart = lastElement - bestSames + 1;
                    }
                }
                else sames = 1;
            }

            for (int i5 = bestStart; i5 < bestSames + bestStart; i5++)
            {
              Console.Write("{0} ", array1[i5]);
            }  

            Console.WriteLine("\nQUESTION 6");

            int counter = 0, tempIndex, tempCounter;

            Console.Write("Enter the length of the array: ");
            int length6 = int.Parse(Console.ReadLine());

            int[] increArr = new int[length6];
            int[] result = new int[length6];

            for (int i = 0; i < length6; i++)
            {
                Console.Write("Enter {0} element: ", i);
                increArr[i] = int.Parse(Console.ReadLine());
            }            
 
            for (int i = 0; i < length6; i++)
            {
                int[] tempResult = new int[length6];
                tempIndex = tempCounter = 1;                
                tempResult[0] = increArr[i];

                for (int j = i + 1; j < length6; j++)
			    {                
				    if (increArr[j] > tempResult[tempIndex - 1])
                    {
                        tempResult[tempIndex] = increArr[j];
                        tempIndex++;
                        tempCounter++;
                    }
                    else if (tempIndex > 1 && increArr[j] > tempResult[tempIndex - 2] && increArr[j] < tempResult[tempIndex - 1]) tempResult[tempIndex - 1] = increArr[j];
                }

                if (counter < tempCounter)
                {
                    counter = tempCounter;
                    result = tempResult;
                }
            }

            for (int i = 0; i < counter; i++)
            {
                Console.Write("{0},", result[i]);
            } 

            Console.WriteLine("\nQUESTION 7");

            int sum = 0;

            Console.Write("Enter value for N : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter value for K lesser then N value: ");
            int k = int.Parse(Console.ReadLine());

            int[] biggestArr = new int[n];

            for(int d = 0; d < n;d++)
            {
                Console.Write("Enter {0} element: ", d);
                biggestArr[d] = int.Parse(Console.ReadLine());
            }

            Array.Sort(biggestArr, (a, b) => b.CompareTo(a));

            for (int d = 0; d < k; d ++) sum += biggestArr[d];
            

            Console.WriteLine("\nBiggest sum is {0}", sum);

            Console.WriteLine("\nQUESTION 8");

            int h, g, iMin, select;

            Console.WriteLine("Enter array length: ");
            int length8 = int.Parse(Console.ReadLine());

            int[] arr8 = new int[length8];

            for (h = 0; h < length8; h++)
            {
                Console.Write("Enter {0} element: ", h);
                arr8[h] = int.Parse(Console.ReadLine());
            }

            for (g = 0; g < length8 - 1; g++)
            {
                iMin = g;
                
                for (h = g + 1; h < length8; h++) if (arr8[h] < arr8[iMin]) iMin = h;

                if (iMin != g)
                {
                   select = arr8[g];
                    arr8[g] = arr8[iMin];
                    arr8[iMin] = select;
                }
            }

            for (h = 0; h < length8; h++)
            {
                Console.Write("{0} ", arr8[h]);
            }    

            Console.WriteLine("\nQUESTION 9");

            int add = 0, tempadd;
            
            Console.WriteLine("Enter array length9: ");
            int length9 = int.Parse(Console.ReadLine());

            int[] sumArray = new int[length9];

            for (int x = 0; x < length9; x++)
            {
                Console.Write("Enter {0} element: ", x);
                sumArray[x] = int.Parse(Console.ReadLine());
            }

            for (int x = 0; x < length9 - 1; x++)
            {
                tempadd = sumArray[x];

                for (int j9 = x + 1; j9 < length9; j9++)
                {
                    tempadd += sumArray[j9];
                    if (tempadd > add) add = tempadd;
                }
            }

            Console.WriteLine("Result is {0}. ", add);

            Console.WriteLine("\nQUESTION 10");

            int countr = 0, tempCountr = 1, foundNumber = 0;

            Console.Write("Enter array Length: ");
            int freqLength = int.Parse(Console.ReadLine());

            int[] freqArray = new int[freqLength];

            for (int c = 0; c < freqLength; c++)
            {
                Console.Write("Enter {0} element: ", c);
                freqArray[c] = int.Parse(Console.ReadLine());
            }

            Array.Sort(freqArray);

            for (int c = 0; c < freqLength - 1; c++)
            {
                if (freqArray[c] == freqArray[c + 1]) tempCountr++;
                else tempCountr = 1;
                if (tempCountr > countr)
                {
                    countr = tempCountr;
                    foundNumber = freqArray[c];
                }
            }

             
            Console.WriteLine("{0} was found {1} times.", foundNumber, countr);

            
            Console.WriteLine("\nQUESTION 11");

            int numsum = 0, start = 0, end = 0;
            bool sumFound = false;

            Console.Write("Enter S: ");
            int s = int.Parse(Console.ReadLine());

            Console.Write("Enter array length: ");
            int length11 = int.Parse(Console.ReadLine());

            int[] arr11 = new int[length11];
                        
            for (int l = 0; l < length11; l++)
            {
                Console.Write("Enter {0} element: ", l);
                arr11[l] = int.Parse(Console.ReadLine());
            }
            
            for (int l = 0; l < length11 - 1; l++)
            {
                numsum = arr11[l];

                for (int z = l + 1; z < length11; z++)
                {
                    numsum += arr11[l];
                    if (numsum == s)
                    {
                        start = l;
                        end = z;
                        sumFound = true;
                        break;
                    }
                }

                if (sumFound) break;
            }

            if (sumFound) for (int l = start; l <= end; l++)
            { 
              Console.Write("{0},", arr11[l]);
            }
            else
            {
               Console.WriteLine("No sum found.");
            }
		
	    Console.WriteLine("\nQUESTION 12");
            Console.WriteLine("\nQUESTION 13");

            int row13 = 0, col13 = 0, sum13 = -1000;

            Console.Write("Enter N: ");
            int n13 = int.Parse(Console.ReadLine());
            Console.Write("Enter M: ");
            int m13 = int.Parse(Console.ReadLine());

            int[,] arr13 = new int[n13, m13];

            for(int i13 = 0; i13 < n13; i13++)
                for (int j13 = 0; j13 < m13; j13++)
                {
                    Console.Write("arr [{0}][{1}] = ", i13, j13);
                    arr13[i13, j13] = int.Parse(Console.ReadLine());
                }            

            for (int temprow13 = 0; temprow13 < arr13.Length - 2; temprow13++)
                for (int tempcol13 = 0; tempcol13 < arr13.GetLength(0) - 2; tempcol13++)
                {
                    int tempsum13 = arr13[row13, col13] + arr13[row13, col13 + 1] + arr13[row13, col13 + 2] +
                        arr13[row13 + 1, col13] + arr13[row13 + 1, col13 + 1] + arr13[row13 + 1, col13 + 2] +
                        arr13[row13 + 2, col13] + arr13[row13 + 2, col13 + 1] + arr13[row13 + 2, col13 + 2];

                    if (tempsum13 > sum13)
                    {
                        row13 = temprow13;
                        col13 = tempcol13;
                        sum13 = tempsum13;
                    }
                }

            Console.WriteLine("Result");
            Console.WriteLine("{0} {1} {2}", arr13[row13, col13], arr13[row13, col13 + 1], arr13[row13, col13 + 2]);
            Console.WriteLine("{0} {1} {2}", arr13[row13 + 1, col13], arr13[row13 + 1, col13 + 1], arr13[row13 + 1, col13 + 2]);
            Console.WriteLine("{0} {1} {2}", arr13[row13 + 2, col13], arr13[row13 + 2, col13 + 2], arr13[row13 + 2, col13 + 2]);
            Console.WriteLine("The maximum sum is {0}.", sum13);

            Console.WriteLine("\nQUESTION 14");

            int tempSeq = 1, seq = 1;
            string element = "e";

            Console.Write("Enter N: ");
            int n14 = int.Parse(Console.ReadLine());
            Console.Write("Enter M: ");
            int m14 = int.Parse(Console.ReadLine());

            string[,] arr14 = new string[n14, m14];

            for (int i14 = 0; i14 < n14; i14++)
                for (int j14 = 0; j14 < m14; j14++)
                {
                    Console.Write("arr14 [{0}][{1}] = ", i14, j14);
                    arr14[i14, j14] = Console.ReadLine();
                }


            for (int rows = 0; rows < arr14.GetLength(0); rows++)
            {
                for (int cols = 0; cols < arr14.GetLength(1) - 1; cols++)
                {
                    if (arr14[rows, cols] == arr14[rows, cols + 1]) tempSeq++;
                    else tempSeq = 1;

                    if (seq < tempSeq)
                    {
                        seq = tempSeq;
                        element = arr14[rows, cols];
                    }
                }
                tempSeq = 1;
            }

            for (int cols = 0; cols < arr14.GetLength(1); cols++)
            {
                for (int rows = 0; rows < arr14.GetLength(0) - 1; rows++)
                {
                    if (arr14[rows, cols] == arr14[rows + 1, cols]) tempSeq++;
                    else tempSeq = 1;

                    if (seq < tempSeq)
                    {
                        seq = tempSeq;
                        element = arr14[rows, cols];
                    }
                }
                tempSeq = 1;
            }

            for (int i14 = 0; i14 < arr14.GetLength(0) - 1; i14++)
                for (int j14 = 0; j14 < arr14.GetLength(1) - 1; j14++)
                {
                    for (int rows = i14, cols = j14; rows < arr14.GetLength(0) - 1 && cols < arr14.GetLength(1) - 1; rows++, cols++)
                    {
                        if (arr14[rows, cols] == arr14[rows + 1, cols + 1]) tempSeq++;
                        else tempSeq = 1;

                        if (seq < tempSeq)
                        {
                            seq = tempSeq;
                            element = arr14[rows, cols];
                        }
                    }
                    tempSeq = 1;
                }

            for (int i14 = 0; i14 < arr14.GetLength(0) - 1; i14++)
                for (int j14 = 1; j14 < arr14.GetLength(1); j14++)
                {
                    for (int rows = i14, cols = j14; rows < arr14.GetLength(0) - 1 && cols > 0; rows++, cols--)
                    {
                        if (arr14[rows, cols] == arr14[rows + 1, cols - 1]) tempSeq++;
                        else tempSeq = 1;

                        if (seq < tempSeq)
                        {
                            seq = tempSeq;
                            element = arr14[rows, cols];
                        }
                    }
                    tempSeq = 1;
                }

            for (int i14 = 0; i14 < seq; i14++)
            {
               Console.Write("{0}, ", element);
            }

            Console.WriteLine("\nQUESTION 15");

            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Enter a word: ");
            char[] word = (Console.ReadLine()).ToCharArray();

            for (int i15 = 0; i15 < word.Length; i15++)
            {
                for (int j15 = 0; j15 < alphabet.Length; j15++)
                {
                    if (word[i15] == alphabet[j15])
                    {
                       Console.Write("{0} ", j15);
                    }
                }
            }

            Console.WriteLine("\nQUESTION 16");

            Console.WriteLine("Enter array length: ");
            int length16 = int.Parse(Console.ReadLine());

            int[] array16 = new int[length16];

            for (int i16 = 0; i16 < length16; i16++)
            {
                Console.Write("Enter {0} element: ", i16);
                array16[i16] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter searched number: ");
            int number16 = int.Parse(Console.ReadLine());

            int index = Array.BinarySearch(array16, number16);

            if (index >= 0)
            {
               Console.WriteLine("number is on {0} index.", index);
            }
            else
            {
               Console.WriteLine("number wasn't found.");
            }

            Console.WriteLine("\nQUESTION 17");	
        }
    }
}
