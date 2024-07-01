using StringAnalyser.Helpers;
using StringAnalyser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAnalyserTests
{
    public class WordFrequencyAnalyzerFrequencyForWordTests
    {
        [Test]
        public void CalculateFrequencyForWord_Success()
        {
            //ARRANGE
            string text = "Hello World This is a great world, This World is simply great";
            int number = 3; 
            IWordFrequencyAnalyzer analyser = new WordFrequencyAnalyzer();

            //ACT
            var MostFrequentWords = analyser.CalculateMostFrequentWords(text, number);

            //ASSERT
            Assert.AreEqual(MostFrequentWords[0].Word, "world");
            Assert.AreEqual(MostFrequentWords[1].Word, "this");
            Assert.AreEqual(MostFrequentWords[2].Word, "is");
        }
    }
}
