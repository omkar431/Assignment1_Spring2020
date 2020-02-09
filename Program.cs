using System;

namespace Assignment1_Spring2020_omkar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintPattern(n);
            Console.WriteLine("\n");

            int n2 = 6;
            PrintSeries(n2);
            Console.WriteLine("\n");

            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);
            Console.WriteLine("\n");


            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);
            Console.WriteLine("\n");


            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);


        }
        // Qustion 1
        private static void PrintPattern(int n)
        {

            try
            {
                int val = n; // Assigning the value of n to val and we will use val in for loop

                for (int i = 0; i < n; i++)
                {
                    Console.Write(val);
                    val--;
                } // printing n to 1 by decreasing the value of n by 1 each time before printing on same line
                Console.WriteLine("");
                n--; // reducing value of n by 1 so in next for loop pattern will start from n-1 and so on.
                if (n != 0)
                {
                    PrintPattern(n);
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }

        // Question 2

        private static void PrintSeries(int n2)
        {
            int x,
                sum = 0;

            x = 1; // Assigning 0 to sum and 1 to x so 
            for (int i = 0; i < n2; i++) // using this we will update sum value as per n2. 
            {
                sum = sum + x;
                x++;
                Console.Write(sum + (i < n2-1 ? "," : ""));
            }
            
        }

        public static string UsfTime(string s)
        {
            try
            {
                //Write your code here .!!
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }



        public static void PalindromePairs(string[] words)
        {
            try
            {
                // Write your code here
            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }

        public static void Stones(int n4)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }


    }
}
