using System;
using System.IO;

namespace ConvertNumericToWords
{	
	public class Program
	{
		public static void Main()
		{
			IConvertToNumericService _convertToNumericService = new ConvertToNumericService();
			string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Numerics.txt");
			var words_= _convertToNumericService.ReadFileAndOuput(fileName);
			Console.WriteLine(words_);
			
		}
	}
}