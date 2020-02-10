using System;
using System.Text.RegularExpressions;

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
                } // printing n to 1 by decreasing the value of val by 1 each time before printing on same line
                Console.WriteLine("");
                n--; // reducing value of n by 1 so in next for loop pattern will start from n-1 and so on.
                if (n != 0)
                {
                    PrintPattern(n); // recursion used
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
                Console.Write(sum + (i < n2-1 ? "," : "")); // formating output separated by ",".
            }
            
        }

        // Question 3

        public static string UsfTime(string s)
        {
            try
            {
                Regex rg = new Regex(@"AM|PM");  // Use Regex to find AM or PM in string
                string ampm = rg.Match(s).ToString(); // Stored the value of AM or PM in ampm
                string[] arr = s.Split(":");              // Split input string by ":" eg: ['09', '15', '35PM']
                int hr, min, sec, nhr, nmin, nsec;

                hr = Int32.Parse(arr[0]);
                if (ampm == "PM") {
                    hr += 12;  // conversion into 24hr format
                }
                min = Int32.Parse(arr[1]);
                sec = Int32.Parse(Regex.Replace(arr[2], @"AM|PM", ""));  // Remove Am/PM from seconds. eg. 35PM -> 35
                nsec = hr * 3600 + min * 60 + sec;
                nmin = nsec / 45;
                nsec = nsec - nmin * 45;
                nhr = nmin / 60;
                nmin = nmin - nhr * 60;

                return "" + nhr + ":" + nmin + ":" + nsec;
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }

        // Question 4

        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                string e;
                for (int i = 1; i <= n3; i++) 
                {
                    if (i % 11 == 0)
                    {
                         e = "\n";
                    }
                    else
                    {
                        e = " ";
                    } // Used if else for printing only 11 numbers per line 
                    
                    string str = "";
                    if (i % 3 == 0) 
                    str = str + "U";
                    if (i % 5 == 0) 
                    str = str + "S";
                    if (i % 7 == 0) 
                    str = str + "F";
                    if (str == "") // Updated string as per requirement
                        str = ""+i;
                    Console.Write(str+e); 



                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }

        // Question 5

        public static void PalindromePairs(string[] words)
        {
            try
            {
                string str;
                for (int i = 0; i < words.Length; i++) 
                {
                    for (int j = 0; j < words.Length; j++) // limiting our operations within words[].
                    {

                        str = words[i] + words[j]; // storing the pairs in str variable
                        string rev = "";
                        for (int k = str.Length - 1; k >= 0; k--) // checking if the pair us palindrome
                        {
                            rev += str[k];
                        }
                        // if the pairs is palindrome print the index of the pair. 
                        if (i != j && rev == str)
                        {
                            Console.Write("[" + i + ", " + j + "] ");
                        }

                    }
                }          

            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }

        // Question 6
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
