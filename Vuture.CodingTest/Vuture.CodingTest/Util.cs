using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vuture.CodingTest
{
    class Util
    {
        private static string[] censored_words = { "dog", "cat", "large" };
        public static string CheckTaskSelection(string a)
        {
            while (a!="1" && a!="2" && a != "3A" && a != "3a" && a != "3B" && a != "3b" && a != "3C" && a != "3c")
            {
                Console.WriteLine("Please make a correct task selection (e.x. 1, 2, 3A, 3B, 3C): ");
                a = Console.ReadLine();
            }

            return a;
        }

        public static int Task1(string str,char letter)
        {
            int num = str.Count(x => x == letter);
            return num;
        }

        public static bool Task2(string str)
        {
            bool b;
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string str_reversed = new string(arr);
            return b = (str.Equals(str_reversed)) ? true : false;


        }

        public static void Task3A(string str)
        {
            //string[] censored_words = { "dog", "cat", "large" };
            int total = 0;

            foreach (string k in censored_words)
            {
                //Regular Expressions
                int num=(Regex.Matches(Regex.Escape(str), k)).Count;
                Console.WriteLine("Censored word {0}: {1} times", k, num);
                total = total + num;
            }

            Console.WriteLine("Total: {0}", total);
        }

        public static void Task3B(string str)
        {
            StringBuilder str2 = new StringBuilder(str);
            
            foreach (string k in censored_words)
            {
                str2 = str2.Replace(k, "$$$");
            }

            Console.WriteLine(str2);
        }

        public static void Task3C(string str)
        {
            string[] words=str.Split(' ');
            StringBuilder str2 = new StringBuilder(str);

            foreach (string k in words)
            {
                bool IsPalindrome=Task2(k);

                if (IsPalindrome)
                {
                    str2 = str2.Replace(k, "$$$");
                }
            }

            Console.WriteLine(str2);
        }

        public static bool IsContinue(string cont)
        {
            while (!(cont.Equals("Y")) && !(cont.Equals("N")) && !(cont.Equals("y")) && !(cont.Equals("n")))
            {
                Console.WriteLine("Please give a correct answer (Y or N): ");
                cont = Console.ReadLine();
            }

            if (cont.Equals("Y") || cont.Equals("y"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
