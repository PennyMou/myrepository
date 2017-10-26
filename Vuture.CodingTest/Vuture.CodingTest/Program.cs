using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuture.CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Continue = true;

            while (Continue)
            {
                Console.WriteLine("Please select Task (ex. 1, 2, 3A, 3B, 3C): ");
                string task_selection = Console.ReadLine();

                task_selection = Util.CheckTaskSelection(task_selection);

                if (task_selection == "1")
                {
                    Console.WriteLine("Please give a string: ");
                    string str = Console.ReadLine();
                    Console.WriteLine("Please give a letter: ");

                    //The method accepts a string BUT only checks the occurencies of the 1st letter of the string!
                    char[] let = (Console.ReadLine()).ToCharArray();

                    int num = Util.Task1(str, let[0]);
                    Console.WriteLine("The number of occurencies of the letter {0} is: {1}", let[0], num);

                }
                else
                {
                    if (task_selection == "2")
                    {
                        Console.WriteLine("Please give a string: ");
                        string str = Console.ReadLine();

                        bool palindrome = Util.Task2(str);
                        Console.WriteLine("Is the given string palindrome? Answer: {0}", palindrome);
                    }
                    else
                    {

                        if (task_selection == "3A" || task_selection == "3a")
                        {
                            Console.WriteLine("Please give a string for searching for censored words: ");
                            string str = Console.ReadLine();

                            Util.Task3A(str);
                        }
                        else
                        {

                            if (task_selection == "3B" || task_selection == "3b")
                            {
                                Console.WriteLine("Please give a string for replacing the censored words: ");
                                string str = Console.ReadLine();

                                Util.Task3B(str);
                            }

                            else
                            {
                                Console.WriteLine("Please give a string for replacing the palindrome words: ");
                                string str = Console.ReadLine();
                            }
                        }
                    }
                }
                Console.WriteLine("Do you want to continue with another Task (Y or N)?");
                string cont=Console.ReadLine();
                Continue = Util.IsContinue(cont);
            }

            Console.WriteLine("BONUS ANSWER! We could have the censored word list stored: \n -in a text file \n -in a database \n -in a List<> \n -in a Dictionary<>");
            Console.ReadLine();
        }
    }
}
