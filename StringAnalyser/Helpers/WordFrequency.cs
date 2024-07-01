using StringAnalyser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAnalyser.Helpers
{
    public class WordFrequency : IWordFrequency
    {
        public string Word { get; set; }
        public int Frequency { get; set; }
    }
}
