using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNameDataTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada eesnimi;
            //programm küsib kasutajalt sisestada numbrit 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnimi tagurpidi
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib '3', siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Vali number 1-3:");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '1': BackWords(userName);
                    break;
                case '2': FirstLetter(userName);
                    break;
                case '3': NameLenght(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;

            }


        }

        public static void BackWords(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void FirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}.");
        }

        public static void NameLenght(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }
    }
}
