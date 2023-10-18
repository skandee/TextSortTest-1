

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cashplus.Util
{
    [TestClass]
    public class TextSortHelperTest
    {
        [TestMethod]
        [DataRow("", "")]
        [DataRow(null, null)]
        [DataRow("Zebra Abba", "Abba Zebra")]
        [DataRow("aBba Abba", "Abba aBba")]
        [DataRow("aBba, Abba", "Abba aBba")]
        [DataRow("b, b", "b b")]
        [DataRow("Go baby, go", "Go baby go")]
        [DataRow("CBA, ABC", "ABC CBA")]
        public void SortText(string input, string expectedResult)
        {        
            Assert.AreEqual(expectedResult, TextSortHelper.SortText(input));
        }       
    }
}