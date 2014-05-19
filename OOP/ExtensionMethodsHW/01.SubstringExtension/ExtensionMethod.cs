namespace SubstringExtension
{
    using System.Text;
    public static class ExtensionMethod
    {
        public static string Substring(this StringBuilder stringBuilder, int startIndex, int length)
        {
            var result = new StringBuilder();

            for (int i = startIndex; i < startIndex + length; i++)
			{
                result.Append(stringBuilder[i]);
			}

            return result.ToString();
        }
    }
}
