using StringAnalyser.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAnalyser.Interfaces
{
    public interface IWordFrequencyAnalyzer
    {
        /// &lt;summary&gt;
        /// Which word appears the most in the string
        /// &lt;/summary&gt;
        /// &lt;param name=&quot;text&quot;&gt;The string of string you are testing against&lt;/param&gt;
        /// &lt;returns&gt;How often the most frequent word appeared&lt;/returns&gt;
        int CalculateHighestFrequency(string text);
        /// &lt;summary&gt;
        /// How often does a certain word appear in a string
        /// &lt;/summary&gt;
        /// &lt;param name=&quot;text&quot;&gt;The string of string you are testing against&lt;/param&gt;
        /// &lt;param name=&quot;word&quot;&gt;The word you wish toe count the frequency of&lt;/param&gt;
        /// &lt;returns&gt;How often the word provided was found in the text
        /// provided&lt;/returns&gt;
        int CalculateFrequencyForWord(string text, string word);
        /// &lt;summary&gt;
        /// The most frequent words, return amount defined by the number parameter
        /// &lt;/summary&gt;
        /// &lt;param name=&quot;text&quot;&gt;The string of string you are testing against&lt;/param&gt;
        /// &lt;param name=&quot;number&quot;&gt;How many words you wish to return&lt;/param&gt;
        /// &lt;returns&gt;A list of the implementation of the IWordFrequency interface of
        /// the top most common words&lt;/returns&gt;
        IList<IWordFrequency> CalculateMostFrequentWords(string text, int number);
    }
}
