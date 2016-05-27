using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _08_Extract_Sentences
{

    class ExtractSentences
    {
        static void Main()
        {
            var wordFind = Console.ReadLine();
            var input = Console.ReadLine();

            var sentences = input.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            var separators = input.Where(x => !char.IsLetter(x)).Distinct().ToArray();

            var wordCapitalized = wordFind.Replace(wordFind[0], char.ToUpper(wordFind[0]));
            var wordNormalized = wordFind.Replace(wordFind[0], char.ToLower(wordFind[0]));

            foreach (var sentence in sentences)
            {
                var words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Trim() == wordFind)
                    {
                        Console.Write(sentence.Trim() + ". ");
                        break;
                    }
                }
            }

        }
    }
}