using StringAnalyser.Helpers;
using StringAnalyser.Interfaces;
using System.Collections;
using System.Text.RegularExpressions;

namespace StringAnalyser
{
    public static class StringProcessor
    {
        static IWordFrequencyAnalyzer Analyzer = new WordFrequencyAnalyzer();

        public static int CalculateHighestFrequency(string text)
        {
            return Analyzer.CalculateHighestFrequency(text);
        }

        public static int CalculateFrequencyForWord(string text, string word)
        {
            return Analyzer.CalculateFrequencyForWord(text, word);
        }

        public static IList<IWordFrequency> CalculateMostFrequentWords(string text, int number)
        {
            return Analyzer.CalculateMostFrequentWords(text, number);
        }
    }

    
    
}