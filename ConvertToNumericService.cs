using System;

public class ConvertToNumericService : IConvertToNumericService
{
	public static string ConvertNumericToWords(Int64 digit)
	{
        var sinngleDigits = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        var tensDigits = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        
        if (digit == 0)
                return "zero";

            if (digit < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((digit / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((digit / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((digit / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (digit > 0)
            {
                if (words != "")
                    words += "and ";

                if (digit < 20)
                    words += unitsMap[digit];
                else
                {
                    words += tensDigits[number / 10];
                    if ((digit % 10) > 0)
                        words += "-" + sinngleDigits[digit % 10];
                }
            }

            return words;        

    }
    public static string ReadFileAndOuput(string fileName)
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
                        str.Append(convertedToInt);
                    }
                    str.AppendLine();
                }
            }
            fileName.close;
            return str.ToString();

        }
    }
}
