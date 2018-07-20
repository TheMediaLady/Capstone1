using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone1
{
    class Program
    {
        static void Main(string[] args)

            
        {
            Console.WriteLine("Enter your word to be translated. ");
            string userWord = Console.ReadLine();
           

            if (userWord.StartsWith("a") || userWord.StartsWith("e") || userWord.StartsWith("i") || userWord.StartsWith("o") || userWord.StartsWith("u")) 
            {
                Console.WriteLine(userWord + "way");
                Console.ReadLine();
            }

        }
    }
}