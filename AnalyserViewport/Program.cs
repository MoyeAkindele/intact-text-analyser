using StringAnalyser;
using StringAnalyser.Helpers;
using StringAnalyser.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        int row = 0;

        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;

            Console.WriteLine($"{Environment.NewLine}Add secondary Input. " +
                $"{Environment.NewLine}Add a word to calculate it's frequency, " +
                $"{Environment.NewLine}a number for most frequent words or " +
                $"{Environment.NewLine}leave blank to skip{Environment.NewLine}");
            string? secondaryInput = Console.ReadLine();

            var highestFrequency = StringProcessor.CalculateHighestFrequency(input);
            Console.WriteLine($"{Environment.NewLine}Highest Frequency: {highestFrequency}");

            bool isNumeric = int.TryParse(secondaryInput, out int mostFrequentCount);
            
            if (isNumeric)
            {
                IList<IWordFrequency> secondaryOutputList = StringProcessor.CalculateMostFrequentWords(input, mostFrequentCount);
                secondaryOutputList
                    .OrderByDescending(d => d.Word);

                if (secondaryOutputList.Count() > 0)
                {
                    Console.WriteLine($"(");
                }

                foreach ( var outputItem in secondaryOutputList )
                {
                    Console.WriteLine($" (\"{outputItem.Word}\" , {outputItem.Frequency})");
                }

                if (secondaryOutputList.Count() > 0)
                {
                    Console.WriteLine($")");
                }
            } 
            else
            {
                int wordFrequency = StringProcessor.CalculateFrequencyForWord(input, secondaryInput);
                Console.WriteLine($"The word '{secondaryInput}' appears {wordFrequency} times");
            }

            Console.WriteLine();
            row += 4;
        } while (true);
        return;

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Press <Enter> only to exit; otherwise, pick one of the following options and press <Enter>:{Environment.NewLine}");
            row = 3;
        }
    }
}