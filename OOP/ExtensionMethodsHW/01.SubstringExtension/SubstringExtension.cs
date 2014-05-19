namespace SubstringExtension
{
    using System;
    using System.Text;
    class SubstringExtension
    {
        static void Main()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < 20; i++)
            {
                sb.Append(i);
            }

            string result = sb.Substring(3, 5);
            Console.WriteLine(result); // 34567
        }
    }
}
