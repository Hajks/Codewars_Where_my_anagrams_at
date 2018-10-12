using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Where_my_anagrams_at
{
    class Program
    {
        static void Main(string[] args)
        {
            //MySolution
            List<string> Anagrams(string word, List<string> words)
            {
                List<string> listToReturn = new List<string>();
                string sortedWord = String.Concat(word.OrderBy(c => c));
                foreach (string item in words)
                {
                    if (sortedWord == String.Concat(item.OrderBy(c => c)))
                    {
                        listToReturn.Add(item);
                    }
                }
                return listToReturn;
            }

            //Codewars solution + code review for myself

            List<string> Anagrams2(string word, List<string> words)
            {
                var pattern = word.OrderBy(p => p).ToArray(); //We create pattern for our word 
                return words.Where(item => item.OrderBy(p => p).SequenceEqual(pattern)).ToList(); //Now we sort words from list in the same way like we did with our pattern
                                                                                                  //Later we compare it to our pattern and add word which got same amount of letters. 
            }
        }

    }
}
