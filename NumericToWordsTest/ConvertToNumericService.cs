using System;
using System.IO;
using System.Text;

namespace ConvertNumericToWords
{
	 public class ConvertToNumericService : IConvertToNumericService
	{
        public string ConvertNumericToWords(Int64 digit)
        {
            var sinngleDigits = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensDigits = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (digit == 0)
                return "zero";

            if (digit < 0)
                return " " + ConvertNumericToWords(Math.Abs(digit));

            string words = "";

            if ((digit / 1000000) > 0)
            {
                words += ConvertNumericToWords(digit / 1000000) + " million ";
                digit %= 1000000;
            }

            if ((digit / 1000) > 0)
            {
                words += ConvertNumericToWords(digit / 1000) + " thousand ";
                digit %= 1000;
            }

            if ((digit / 100) > 0)
            {
                words += ConvertNumericToWords(digit / 100) + " hundred ";
                digit %= 100;
            }

            if (digit > 0)
            {
                if (words != "")
                    words += "and ";

                if (digit < 20)
                    words += sinngleDigits[digit];
                else
                {
                    words += tensDigits[digit / 10];
                    if ((digit % 10) > 0)
                        words += "-" + sinngleDigits[digit % 10];
                }
            }
            return words;
        }
        public string ReadFileAndOuput(string fileName)
        {
            using (StreamReader file = new StreamReader(fileName))
            {
                string line;
                StringBuilder str = new StringBuilder();

                while ((line = file.ReadLine()) != null)
                {
                    var lines = line.Split(' ');

                    foreach (var word in lines)
                    {
                        if (IsNumeric(word))
                        {
                            var convertedToInt = Convert.ToInt32(word);
                            var convertyed = ConvertNumericToWords(convertedToInt);
                            str.Append(convertyed);
                        }
                        else
                        {
                            return null;
                        }
                        str.AppendLine();
                    }
                }
                file.Close();
                return str.ToString();
            }
        }
        public bool IsNumeric(string word)
        {
            return int.TryParse(word, out _);
        }
    }
}
