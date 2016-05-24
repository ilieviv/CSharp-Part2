namespace _08_Extract_Sentencs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CustomSplitReadALL
    {
        static void Main()
        {

            var BREAK = new[] { 13, 10, 3, 4, 12, 23, 25 };


            var toFindInput = Console.ReadLine();
            var Input = Console.ReadLine();


            var curSentence = new StringBuilder();


            var isDot = false;

            var toFindWord = FormatInputWord(toFindInput);

            foreach (var letter in Input)
            {

                if (isDot && letter != '.')
                {

                    isDot = false;


                    if (ContainsWord(curSentence.ToString(), toFindWord))
                    {
                        Console.Write(curSentence);
                    }

                    curSentence.Clear();
                }


                if (BREAK.Contains(letter))
                {
                    break;
                }


                curSentence.Append((char)letter);

                if (letter == '.' && !isDot)
                {
                    isDot = true;
                }
            }

            if (ContainsWord(curSentence.ToString(), toFindWord))
            {
                Console.Write(curSentence);
            }

            Console.WriteLine();
        }


        static string FormatInputWord(string inputWord)
        {
            var toReturn = new StringBuilder();

            foreach (var letter in inputWord)
            {
                if (char.IsLetter(letter))
                {
                    toReturn.Append(char.ToLower(letter));
                }
            }

            return toReturn.ToString();
        }


        static bool ContainsWord(string sentence, string word)
        {

            var checkSentence =
                string.Format(
                    "^{0}$",
                    sentence.ToLower()
                    );


            var wordLength = word.Length;


            var wordCurIndex = checkSentence.IndexOf(word);

            while (wordCurIndex >= 0)
            {
                if (!char.IsLetter(checkSentence[wordCurIndex - 1]) &&
                    !char.IsLetter(checkSentence[wordCurIndex + wordLength]))
                {
                    return true;
                }


                wordCurIndex = checkSentence.IndexOf(word, ++wordCurIndex);
            }



            return false;
        }
    }
}