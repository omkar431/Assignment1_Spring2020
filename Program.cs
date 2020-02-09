using System;

namespace Assignment1_Spring2020_omkar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintPattern(n);

            int n2 = 6;
            PrintSeries(n2);


        }
        // Qustion 1
        private static void PrintPattern(int n)
        {

            try
            {
                int val;
                int i; // Declaring integers
                val = n; // Assigning the value of n to val and we will use val in for loop
                for (i = 0; i < n; i++)
                {
                    Console.Write(val);  
                    val = val - 1;

                } // printing n to 1 by decreasing the value of n by 1 each time before printing on same line
                n = n - 1; // reducing value of n by 1 so in next for loop pattern will start from n-1 and so on.
                if (n == 0)
                {
                    Console.WriteLine(""); // if n reches to 0 then it will print blank
                }
                else
                {
                    Console.WriteLine("\n");
                    PrintPattern(n); // recursion is used calling same function so function will start again.

                }
                //Write your code here .!
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }

        // Question 2

        private static void PrintSeries(int n2)
        {
            int x;
            int sum;
            int i; // Declaring variables
            sum = 0;
            x = 1; // Assigning 0 to sum and 1 to x so 

            for (i = 0; i <= n2; i++) // using this we will update sum value as per n2. 
            {
                sum = sum + x;
                x = x + 1;
                Console.Write(sum);
            }
        }

    }
}
