using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _theWord;
        private string[] _arrayOfWords;
        private Dictionary<string, int> _WordsFromArrayDictionary = new Dictionary<string, int>() { };

        public void SetTheWord(string input)
        {
            _theWord = input.ToLower();
        }

        public string GetTheWord()
        {
            return _theWord;
        }

        public void SetTheArrayOfWords(string input)
        {
            _arrayOfWords = input.ToLower().Split(" ");
        }

        public string[] GetTheArrayOfWords()
        {
            return _arrayOfWords;
        }

        public void SetWordsFromArrayDictionary(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (GetWordsFromArrayDictionary().ContainsKey(input[i]))
                {
                    GetWordsFromArrayDictionary()[input[i]]++;
                }
                else
                {
                    GetWordsFromArrayDictionary().Add(input[i], 1);
                }
            }
        }

        public Dictionary<string, int> GetWordsFromArrayDictionary()
        {
            return _WordsFromArrayDictionary;
        }

        public int FindTheNumberOfOccurences()
        {
            if (GetWordsFromArrayDictionary()[GetTheWord()] >= 1)
            {
                return GetWordsFromArrayDictionary()[GetTheWord()];
            }
            else
            {
                return 0;
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            RepeatCounter game = new RepeatCounter();
            Console.WriteLine("Write a word");
            game.SetTheArrayOfWords(Console.ReadLine());
            game.SetWordsFromArrayDictionary(game.GetTheArrayOfWords());
            Console.WriteLine(game.GetWordsFromArrayDictionary()["one"]);
            Console.WriteLine(game.GetWordsFromArrayDictionary()["two"]);
            Console.WriteLine(game.GetWordsFromArrayDictionary()["three"]);
            Console.WriteLine(game.GetWordsFromArrayDictionary()["four"]);
            Console.ReadLine();
        }
    }
}
