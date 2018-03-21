using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon07NumberLED
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("輸入一串數字");
            string n = Console.ReadLine();
            

            CreateLED(n);
        }

        private static void CreateLED(string n)
        {
            int num = 0;
            string[] Top = new string[n.Length];
            string[] Mid = new string[n.Length];
            string[] Bot = new string[n.Length];

            foreach (var item in n)
            {
                switch (item.ToString())
                {
                    case "0":
                        Top[num] += "  __ ";
                        Mid[num] += " |  |";
                        Bot[num] += " |__| ";
                        break;
                    case "1":
                        Top[num] += "    ";
                        Mid[num] += "  | ";
                        Bot[num] += "  | ";
                        break;
                    case "2":
                        Top[num] += "  ____ ";
                        Mid[num] += "  ____|";
                        Bot[num] += " |____ ";
                        break;
                    case "3":
                        Top[num] += "  ___ ";
                        Mid[num] += "　___| ";
                        Bot[num] += "  ___| ";
                        break;
                    case "4":
                        Top[num] += "|   | ";
                        Mid[num] += " ———| ";
                        Bot[num] += "    | ";
                        break;
                    case "5":
                        Top[num] += "|￣￣ ";
                        Mid[num] += " ———  ";
                        Bot[num] += " ___| ";
                        break;
                    case "6":
                        Top[num] += "|     ";
                        Mid[num] += "|___ ";
                        Bot[num] += "|___| ";
                        break;
                    case "7":
                        Top[num] += " ￣￣| ";
                        Mid[num] += "     | ";
                        Bot[num] += "     | ";
                        break;
                    case "8":
                        Top[num] += "|￣￣| ";
                        Mid[num] += "|——— | ";
                        Bot[num] += "|___ | ";
                        break;
                    case "9":
                        Top[num] += " |￣￣| ";
                        Mid[num] += "  ——— | ";
                        Bot[num] += "   ___| ";
                        break;

                    default:
                        break;
                }
            }

            foreach(var item in Top)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            foreach (var item in Mid)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            foreach (var item in Bot)
            {
                Console.Write(item);
            }
            Console.WriteLine("我討厭美術");

            Console.ReadLine();

        }
    }
}
