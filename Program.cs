using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);
            //Console.ReadKey();

            int n1 =3 ;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("\nThe sum of the series is: " + r1);
            Console.ReadKey();


            long n2 = 15;
            StringBuilder r2 = decimalToBinary(n2);

            Console.WriteLine("\nBinary conversion of the decimal number " + n2 + " is: " + r2);
            Console.ReadKey();


            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("\nDecimal conversion of the binary number " + n3 + " is: " + r3 +"\n");


            int n4 = 5;
            printTriangle(n4);
            Console.ReadKey();

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);
            Console.ReadKey();


            // write your self-reflection here as a comment
            // I really enjoyed working on this assingement, 
            //personally It improved my logical thinking as its been a while I did some handson on c#.
            //Few questions were really challenging, like the print Traingle. It really tested my knowledge of loops.
        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                // Write your code here
                if (y > x)
                {
                    Console.Write("2 3 ");  // initializing as 2 and 3 are prime numbers
                    for (int i = x; i < y + 1; i++)
                    {
                        if (i % 2 != 0 && i % 3 != 0)  // checking the numbers through logic: if number is not divided by 2 and 3 then its a prime number
                        {
                            Console.Write(i + " ");
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        public static double getSeriesResult(int n)
        {
            try
            {
                // Write your code here

                double myResult = 0;

                
                for (double i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)                             // checking condition if i is odd or even number. then routing the flow of code towards respective side
                    {
                        myResult += -((getFactorial123(i)) / (i + 1));  // if i is even the this part will be executed. It will call GetFactorial method for calculating factorial

                    }
                    else
                    {
                        myResult += ((getFactorial123(i)) / (i + 1));  //if i is odd then this part will be executed
                    }
                }
                return myResult;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }

        public static double getFactorial123(double x)  // method for executing factorials
        {
            double y = 1;

            while (x > 0)
            {
                y = y * x;

                x = x - 1;

            }

            return y;
        }

        public static StringBuilder decimalToBinary(long n)
        {
            try
            {
                // Write your code here
                long[] results = new long[n];
                long i = 0;
                
                long[] resultFinal = new long[n];

                List<string> output = new List<string>();

                StringBuilder numberList = new StringBuilder();

                while (n > 0)
                {
                    long test = n % 2;      //logic for taking the right most digit
                    long div = n / 2;       // getting the quetient 
                    results[i] = test;
                    i++;
                    n = div;
                }
                for (long j = i - 1; j >= 0; j--)
                {
                    //Console.Write(results[j]);
                    numberList.Append(results[j]);      //appending result into stringbuilder type 

                }

                return numberList; // return value needs to be sorted


            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }
            StringBuilder a1 = new StringBuilder();
            return a1;
        }

        public static long binaryToDecimal(long n)
        {
            try
            {
                // Write your code here

                long baseV = 1;
                long finalAns = 0;

                while (n != 0)
                {
                    long currentValue = 0;
                    long leftNumber = 0;
                    currentValue = n % 10;      //taking right most value
                    finalAns += currentValue * baseV;   //formula for calculating binary to decimal number + 2^ (index of number)
                    leftNumber = n / 10;        //number left after formula
                    n = leftNumber;
                    baseV = baseV * 2;      //incrementing value for base

                }

                
                return finalAns;

            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return 0;
        }

        public static void printTriangle(int n)
        {
            try
            {
                // Write your code here
                //Console.Write("Pyramid for number of rows= " + n);
                for (int f = 1; f <= n; f++) //for n loops
                {
                    for (int sp = n - f; sp >= 0; sp--)//for spaces after pattern
                    {
                        Console.Write(" ");
                    }
                    for (int s = f; s >= 1; s--) //for printing values for pattern
                    {
                        Console.Write("*" + "");
                    }
                    for (int x = 2; x <= f; x++) //for printing values
                    {
                        Console.Write("*" + "");
                    }
                    Console.WriteLine();

                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            try
            {
                // Write your code here

                IDictionary<int, int> dict = new Dictionary<int, int>();    //using key value pairs
                //dict.Add(1, "One");
                for (int i = 0; i < a.Length; i++)      //looping over array to check number of unique key value pair
                {
                    if (!dict.ContainsKey(a[i]))        //if new number then add to dictionary
                    {
                        dict.Add(a[i], 1);
                    }
                    else
                    {
                        int value = dict[a[i]];     //if old then increase the count
                        dict[a[i]] = ++value;
                    }
                }
                Console.WriteLine("Number  Frequency");

                for (int i = 0; i < dict.Count; i++)
                {
                    Console.WriteLine("{0}       {1}",
                                                            dict.Keys.ElementAt(i),
                                                            dict[dict.Keys.ElementAt(i)]);      //for result output
                }



            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}




