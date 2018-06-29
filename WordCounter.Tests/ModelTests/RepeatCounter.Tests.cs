using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void GetSetTheWord_GetsSetsTheWord_True()
        {
            RepeatCounter newGame = new RepeatCounter();
            string word = "hello";
            newGame.SetTheWord(word);
            Assert.AreEqual(word, newGame.GetTheWord());
        }

        [TestMethod]
        public void GetSetTheWord_GetsSetsTheWord_False()
        {
            RepeatCounter newGame = new RepeatCounter();
            string word = "hello";
            newGame.SetTheWord(word);
            Assert.AreEqual(word, newGame.GetTheWord());
        }

        [TestMethod]
        public void GetSetTheArrayOfWords_GetsSetsTheArrayOfWord_True()
        {
            RepeatCounter newGame = new RepeatCounter();
            string word = "hello nice to meet you";
            string[] words = { "hello", "nice", "to", "meet", "you" };
            newGame.SetTheArrayOfWords(word);
            CollectionAssert.AreEqual(words, newGame.GetTheArrayOfWords());
        }

        [TestMethod]
        public void GetSetTheArrayOfWordsRegardlessOfCase_GetsSetsTheArrayOfWordRegardlessOfCase_True()
        {
            RepeatCounter newGame = new RepeatCounter();
            string word = "Hello nice to meet you";
            string[] NewWords = { "hello", "nice", "to", "meet", "you" };
            newGame.SetTheArrayOfWords(word);
            CollectionAssert.AreEqual(NewWords, newGame.GetTheArrayOfWords());
        }

        [TestMethod]
        public void GetSetWordsFromArrayDictionary_GetsSetsWordsFromArrayDictionary_True()
        {
            RepeatCounter newGame = new RepeatCounter();
            string[] words = new string[] { "hello", "nice", "to", "meet", "you" };
            newGame.SetWordsFromArrayDictionary(words);
            Assert.AreEqual(1, newGame.GetWordsFromArrayDictionary()["hello"]);
        }

        [TestMethod]
        public void GetSetWordsFromArrayDictionaryMultiple_GetsSetsWordsFromArrayDictionaryMultiple_True()
        {
            RepeatCounter newGame = new RepeatCounter();
            string[] words = new string[] { "hello", "nice", "to", "meet", "you", "hello" };
            newGame.SetWordsFromArrayDictionary(words);
            Assert.AreEqual(2, newGame.GetWordsFromArrayDictionary()["hello"]);
        }

        [TestMethod]
        public void GetNumberOfOccurences_GetsNumberOfOccurences_True()
        {
            RepeatCounter newGame = new RepeatCounter();
            string word = "hello";
            newGame.SetTheWord(word);
            string[] words = new string[] { "hello", "nice", "to", "meet", "you", "hello" };
            newGame.SetWordsFromArrayDictionary(words);
            Assert.AreEqual(2, newGame.FindTheNumberOfOccurences());
        }
    }
}
