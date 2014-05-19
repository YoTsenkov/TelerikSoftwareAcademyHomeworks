namespace ReturnLongestString
{
    using System;
    using System.Linq;
    class ReturnLongestString
    {
        static void Main()
        {
            var stringArr = new[]
            {
               "a2", "aaa4", "aaaa5", "aa3", "1"
            };

            var longestString =
                (from st in stringArr
                 orderby st.Length descending
                 select st).First();

            Console.WriteLine(longestString);
        }
    }
}
