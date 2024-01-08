using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
namespace StringManipulation
{
    public class positionOfCharacter
    {
        public string nameOfWord { get; set; }
        public string c { get; set; }
        public int pos { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string contents = "";
            List<positionOfCharacter> list = new List<positionOfCharacter>();
            try
            {
                // Get file name.
                string path = @"Files/Words.txt";
                // Get path name.
                string filename = Path.GetFileName(path);
                // Open the text file using a stream reader. Read into a string
                using (var sr = new StreamReader(path))
                {
                    // Read the stream as a string, and write the string to the contents.
                    contents = sr.ReadToEnd();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Could not read file");
                Console.WriteLine(e.Message);
            }
            //Store each word into an array using split on '\n'
            Random rnd = new Random();
            var array = contents.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            int num = rnd.Next(array.Length);
            var word = array[num];
            bool guessed = false;
            int guessesleft = 10;
            while (!guessed)
            {
                bool alllettersgot=true;
                for (int i = 1; i < word.Length; i++)
                {
                    bool gotvalue = false;
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j].pos == i)
                        {
                            gotvalue = true;
                            Console.Write(list[j].c);
                        }
                    }
                    if (!gotvalue)
                    {
                        alllettersgot = false;
                        Console.Write("_");
                    } else
                    {
                        gotvalue = false;
                    }
                }
                Console.WriteLine("");
                if (alllettersgot)
                {
                    guessed = true;
                    Console.WriteLine("You win!");
                    break;
                }
                Console.WriteLine("Incorrect guesses left: " + guessesleft);
                Console.WriteLine("Pick a letter to guess: ");
                string letterToSearch = Console.ReadLine();
                string letter = letterToSearch.ToLower();
                string wordToSearch = word.ToLower();
                int index = 0;
                if (wordToSearch.Contains(letter))
                {
                    // Find index where letter is
                    if (wordToSearch.IndexOf(letter) != -1)
                    {
                        while ((index = wordToSearch.IndexOf(letter, index)) != -1)
                        {
                            Console.WriteLine(letter + " found at position " + " " + index);
                            index++;
                            list.Add(new positionOfCharacter() { nameOfWord = wordToSearch, c = letter, pos = index });
                        }
                    }
                } else
                {
                    guessesleft--;
                    if (guessesleft == 0)
                    {
                        guessed = true;
                        Console.WriteLine("You lose, the word was " + wordToSearch);
                    }
                }
            }
        }
    }
}
