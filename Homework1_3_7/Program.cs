using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase="Каждый охотник желает знать сколько тут слов";
            string[] phraseArray = phrase.Split(' ');

            foreach (string word in phraseArray)
            {
                Console.WriteLine(word);
            }
        }
    }
}