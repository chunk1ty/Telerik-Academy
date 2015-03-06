using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindWordInSentences
{
    class Program
    {
        static void Main()
        {
            string input = @"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            string regex = @"\bin\b";
            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char check = input[i];
                string sentence = string.Empty;
                if (input[i] == '.')
                {
                    endIndex = i + 1;
                    int lenght = endIndex - startIndex;
                    sentence = input.Substring(startIndex, lenght);
                    if (Match(sentence, regex))
                    {
                        if (sentence[0] == ' ')
                        {
                            Console.WriteLine("{0}", sentence.Remove(0, 1));
                        }
                        else
                        {
                            Console.WriteLine("{0}", sentence);
                        }
                    }
                    startIndex = endIndex;
                }
            }
        }
            //Regex
        //    string myregex = @"\s*(?<sentence>[^\.]+?\bin\b(.|\s)+?\.)";
        //    //string regex = @"\s*(?<sentence>[^\.]*?\bin\b(.|\s)*?\.)";
        //    //               \s* -> premahva praznite intervali v nachaloto na izrecheniqta
        //    //                              [^\.]*? -> grupata netrqbva da sudurja tochka zashtoto e krai na izrechenieto
        //    //                                     \binb -> tova e dumata koqto tursq ("in") ne kato substring a kato word
        //    //                                          (.|\s)*?\. -> do kraq moje da ima vsichko dokuto se stigne do tochka                        
        //    MatchCollection matches = Regex.Matches(input, myregex, RegexOptions.IgnoreCase);

        //    foreach (Match match in matches)
        //    {
        //        Console.WriteLine(match.Groups["sentence"].Value);
        //    }
        //}

        static bool Match (string sentence,string pattern)
        {
            MatchCollection match = Regex.Matches(sentence, pattern);
            if (match.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }
    }
}
