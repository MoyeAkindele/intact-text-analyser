using StringAnalyser.Helpers;
using StringAnalyser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAnalyserTests
{
    public class WordFrequencyAnalyzerMostFrequentWordsTests
    {
        [Test]
        public void CalculateFrequencyForWords_Success()
        {
            //ARRANGE
            string text = "Hello World This is a great world, This World is simply great";
            string word = "this";
            IWordFrequencyAnalyzer analyser = new WordFrequencyAnalyzer();

            //ACT
            int frequency = analyser.CalculateFrequencyForWord(text, word);

            //ASSERT
            Assert.That(2, Is.EqualTo(frequency));
        }

        [Test]
        public void CalculateFrequencyForWords_ForMissingWord()
        {
            //ARRANGE
            string text = "Hello World This is a great world, This World is simply great";
            string word = "try";
            IWordFrequencyAnalyzer analyser = new WordFrequencyAnalyzer();

            //ACT
            int frequency = analyser.CalculateFrequencyForWord(text, word);

            //ASSERT
            Assert.That(0, Is.EqualTo(frequency));
        }

        [Test]
        public void CalculateFrequencyForWords_DifferentCases_Success()
        {
            //ARRANGE
            string text = "Hello World This is a great world, This World is simply great";
            string word = "hello";
            IWordFrequencyAnalyzer analyser = new WordFrequencyAnalyzer();

            //ACT
            int frequency = analyser.CalculateFrequencyForWord(text, word);

            //ASSERT
            Assert.That(1, Is.EqualTo(frequency));
        }

        [Test]
        public void CalculateFrequencyForWords_ForEmptyTextParameter()
        {
            //ARRANGE
            string text = "";
            string word = "try";
            IWordFrequencyAnalyzer analyser = new WordFrequencyAnalyzer();

            //ACT
            int frequency = analyser.CalculateFrequencyForWord(text, word);

            //ASSERT
            Assert.That(0, Is.EqualTo(frequency));
        }

        [Test]
        public void CalculateFrequencyForWords_ForEmptyWordParameter()
        {
            //ARRANGE
            string text = "Hello World This is a great world, This World is simply great";
            string word = "";
            IWordFrequencyAnalyzer analyser = new WordFrequencyAnalyzer();

            //ACT
            int frequency = analyser.CalculateFrequencyForWord(text, word);

            //ASSERT
            Assert.That(0, Is.EqualTo(frequency));
        }
    }
}
