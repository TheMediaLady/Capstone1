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
            userWord = userWord.ToLower();
           
            string front = "";
            string back = "";


            char[] letters = new char[userWord.Length];
            letters = userWord.ToCharArray();

            if (userWord.StartsWith("a") || userWord.StartsWith("e") || userWord.StartsWith("i") || userWord.StartsWith("o") || userWord.StartsWith("u"))
            {
                Console.WriteLine(userWord + "way");
                Console.ReadLine();
            }

            for (int i = 0; i < userWord.Length; i++)
            {
                //Console.WriteLine(userWord[i]);
                if (letters[i] != 'a') //|| letters[i] != 'e' || letters[i] != 'i' || letters[i] != 'o' || letters[i] != 'u' 
                {
                    if (letters[i] != 'e')
                    {
                        if (letters[i] != 'i')
                        {
                            if (letters[i] != 'o')
                            {
                                if (letters[i] != 'u')

                                {
                                    //Console.WriteLine(letters[i]);
                                    front = front + letters[i];
                                }
                                else
                                {
                                    i = i + userWord.Length;
                                }
                            }
                            else
                            {
                                i = i + userWord.Length;
                            }
                        }
                        else
                        {
                            i = i + userWord.Length;
                        }
                    }
                    else
                    {
                        i = i + userWord.Length;
                    }
                }
                else
                {
                    i = i + userWord.Length;
                }
            }
        
            for(int i = front.Length; i<letters.Length; i++)
            {
                back = back + letters[i];
            }  
            
            Console.WriteLine($"{back}{front}" + "ay");
            Console.ReadLine();
        }


        }
    }
