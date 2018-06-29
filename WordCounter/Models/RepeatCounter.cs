﻿using System;
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

        public void GetResponse()
        {
            string response = Console.ReadLine();
            string responseLower = response.ToLower();
            if (responseLower == "y" || responseLower == "yes")
            {
                Main();
            }
            if (responseLower == "n" || responseLower == "no")
            {
                Console.WriteLine("Okay goodbye!");
                Console.ReadLine();
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
    }

    public class Program
    {
        static void Main(string[] args)
        {
            RepeatCounter game = new RepeatCounter();
            Console.WriteLine("Word Counter");
            Console.WriteLine("Write a word that you would like to count!");
            game.SetTheWord(Console.ReadLine());
            Console.WriteLine("Write a phrase that you would like to see how many times the first word appears in it!");
            game.SetTheArrayOfWords(Console.ReadLine());
            game.SetWordsFromArrayDictionary(game.GetTheArrayOfWords());
            Console.WriteLine(game.GetTheWord() + " appears exactly " + game.FindTheNumberOfOccurences() + " time(s)");
            game.AskIfDone();
            
        }
    }
}
