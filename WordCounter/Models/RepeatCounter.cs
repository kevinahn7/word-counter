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

        public void CheckIfValidWord()
        {
            string input = Console.ReadLine();
            if (input.Split(" ").Length > 1)
            {
                Console.WriteLine("That was not a single word!");
                PlayGame();
            }
            else
            {
                SetTheWord(input);
            }
        }

        public Dictionary<string, int> GetWordsFromArrayDictionary()
        {
            return _WordsFromArrayDictionary;
        }

        public int FindTheNumberOfOccurences()
        {
            if (GetWordsFromArrayDictionary().ContainsKey(GetTheWord()))
            {
                return GetWordsFromArrayDictionary()[GetTheWord()];
            }
            else
            {
                return 0;
            }
        }

        public void GetResponse()
        {
            string response = Console.ReadLine();
            string responseLower = response.ToLower();
            if (responseLower == "y" || responseLower == "yes")
            {
                GetWordsFromArrayDictionary().Clear();
                PlayGame();
            }
            if (responseLower == "n" || responseLower == "no")
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("That was not a valid response");
                AskIfDone();
            }
        }

        public void AskIfDone()
        {
            Console.WriteLine("Would you like to play again? [Y/N]");
            GetResponse();
        }

        public void PlayGame()
        {
            Console.WriteLine("Write a word that you would like to count!");
            CheckIfValidWord();
            Console.WriteLine("Write a phrase that you would like to see how many times the first word appears in it!");
            SetTheArrayOfWords(Console.ReadLine());
            SetWordsFromArrayDictionary(GetTheArrayOfWords());
            Console.WriteLine(GetTheWord() + " appears exactly " + FindTheNumberOfOccurences() + " time(s)");
            AskIfDone();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            RepeatCounter game = new RepeatCounter();
            Console.WriteLine("Word Counter Game");
            game.PlayGame();
        }
    }
}
