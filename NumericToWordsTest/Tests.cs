using ConvertNumericToWords;
using NUnit.Framework;
using System;
using System.IO;

namespace NumericToWordsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InputIsnotNumericIsEqualNull()
        {
           IConvertToNumericService _convertToNumericService = new ConvertToNumericService();
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Test.txt");
            var words_ = _convertToNumericService.ReadFileAndOuput(fileName);
            Assert.AreEqual(null,words_);
        }
        [Test]
        public void InputIsNumeric()
        {
            IConvertToNumericService _convertToNumericService = new ConvertToNumericService();
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Test1.txt");
            var words_ = _convertToNumericService.ReadFileAndOuput(fileName);
            Assert.IsNotNull(words_);
        }
    }
}