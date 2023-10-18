using System.Text.RegularExpressions;

namespace Cashplus.Util
{
    public class TextSortHelper
    {
        public static string SortText(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return data;
            }

            var specialCharacterPattern = @"[.,;'\(\)]";
            data = Regex.Replace(data, specialCharacterPattern, "");
            var words = data.Split(' ');
            var sortedWords = new List<string>(words);
            sortedWords.Sort(new ResultComparator());

            return string.Join(" ", sortedWords);
        }

        private class ResultComparator : IComparer<string>
        {
            public int Compare(string x, string y)   
            {
                if ((char)x[0] < (char)y[0])
                    return 0;

                return 1;
            }
        }        
    }
}
