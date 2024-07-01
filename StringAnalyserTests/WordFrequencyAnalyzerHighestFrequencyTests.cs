using StringAnalyser.Helpers;
using StringAnalyser.Interfaces;

namespace StringAnalyserTests
{
    public class WordFrequencyAnalyzerHighestFrequencyTests
    {
        [Test]
        public void CalculateHighestFrequency_Success()
        {
            //ARRANGE
            string text = "Hello World This is a great world, This World is simply great";
            IWordFrequencyAnalyzer analyser = new WordFrequencyAnalyzer();

            //ACT
            int highestFrequency = analyser.CalculateHighestFrequency(text);

            //ASSERT
            Assert.That(3, Is.EqualTo(highestFrequency));
        }

        [Test]
        public void CalculateHighestFrequency_WithEmptyString()
        {
            //ARRANGE
            string text = "";
            IWordFrequencyAnalyzer analyser = new WordFrequencyAnalyzer();

            //ACT
            int highestFrequency = analyser.CalculateHighestFrequency(text);

            //ASSERT
            Assert.That(0, Is.EqualTo(highestFrequency));
        }
    }    
}
