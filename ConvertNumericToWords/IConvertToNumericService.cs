using System;

namespace ConvertNumericToWords
{
	public interface IConvertToNumericService
	{
		string ConvertNumericToWords(Int64 digit);
		string ReadFileAndOuput(string fileName);
		bool IsNumeric(string word);
	}
}