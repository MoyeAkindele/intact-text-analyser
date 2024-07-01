using StringAnalyser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StringAnalyser.Helpers
{
    public class WordFrequencyAnalyzer : IWordFrequencyAnalyzer
    {
        public int CalculateFrequencyForWord(string text, string word)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(word)) { return 0; }

            var frequencies = Regex.Split(text.ToLower(), @"\W+")
            .GroupBy(s => s)
            .OrderByDescending(g => g.Count());

            var wordFrequencies = frequencies
                .Select(s => s)
                .Where(t => t.Key.ToLower() == word.ToLower());

            var wordCount = 0;
            if (wordFrequencies.Count() > 0)
            {
                wordCount = wordFrequencies.First().ToArray().Count();
            }

            return wordCount;
        }

        public int CalculateHighestFrequency(string text)
        {
            if (string.IsNullOrEmpty(text)) { return 0; }

            var frequencies = Regex.Split(text.ToLower(), @"\W+")
            .GroupBy(s => s)
            .OrderByDescending(g => g.Count());

            return frequencies.First().Count();
        }

        public IList<IWordFrequency> CalculateMostFrequentWords(string text, int number)
        {
            var frequencies = Regex.Split(text.ToLower(), @"\W+")
            .GroupBy(s => s)
            .OrderByDescending(g => g.Count());

            var results = frequencies.Take(number);
            IList<IWordFrequency> FrequentWordsList = new List<IWordFrequency>();

            foreach (var resultItem in results)
            {
                FrequentWordsList.Add(new WordFrequency() { Word = resultItem.Key, Frequency = resultItem.Count() });
            }

            IEnumerable<IWordFrequency> query = FrequentWordsList.OrderBy(p => p.Word);

            return FrequentWordsList;
        }
    }
}
