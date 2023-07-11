using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cCode, lang, choice;
            do
            {
                Console.WriteLine("Entry country code");
                cCode = Console.ReadLine().ToLower();
                switch (cCode)
                {
                    case "uk":
                    case "us":
                        {
                            lang = "english";
                            break;
                        }
                    case "af":
                        {
                            lang = "dari,pashto";
                            break;
                        }
                    case "in":
                        {
                            lang = "hindi,english,tamil";
                            break;
                        }
                    case "uae":
                    case "om":
                    case "ksa":
                    case "egypt":
                        {
                            lang = "arabic";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine(" $sorry! your country {cCode} is not in ourdb ");
                            lang = "not found";
                            break;
                        }
                }
                Console.WriteLine("country code: \t " + cCode + " \n Language(s): \t " + lang);
                Console.WriteLine("do you wanna continue if yes press y \n to exit press any key");
                choice = Console.ReadLine().ToLower();
            }
            while (choice=="y");
            Console.ReadKey();
        }
    }
}
