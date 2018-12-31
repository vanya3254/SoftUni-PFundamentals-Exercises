using System;

namespace Word_In_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string singleWord = Console.ReadLine();

            string pluralWord = null;
            bool singleWordEndY = singleWord.EndsWith("y");
            bool singleWordOther = singleWord.EndsWith("o") || singleWord.EndsWith("ch") || singleWord.EndsWith("s")
                || singleWord.EndsWith("sh") || singleWord.EndsWith("x") || singleWord.EndsWith("z");

            if (singleWordEndY)
            {
                pluralWord = singleWord.Replace("y", "ies");

            }
            else if (singleWordOther)
            {
                pluralWord = singleWord + "es";
            }
            else
            {
                pluralWord = singleWord + "s";
            }
            

            Console.WriteLine(pluralWord);

        }
    }
}
