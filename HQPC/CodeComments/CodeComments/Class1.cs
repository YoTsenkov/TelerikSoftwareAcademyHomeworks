namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Provides extension methods for the <see cref="System.String"/> class.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Encrypts this instance using MD5 encrypting algorithm.
        /// </summary>  
        /// <param name="input">The string whose hash will be calculated.</param>
        /// <returns>The 128-bit hash of the string.</returns>        
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// Checks if the string can be interpeted as <see cref="System.Boolean"/> "true".
        /// </summary>     
        /// <param name="input">The string that will be checked.</param>
        /// <returns>True if the string can be interpreted as <see cref="System.Boolean"/> "true".</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Converts the value of this instance to its <see cref="System.Int16"/> equivalent.
        /// </summary>       
        /// <param name="input">The string to be converted.</param>
        /// <returns>A <see cref="T:System.Int16"/> representation of the given string.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Converts the value of this instance to its <see cref="T:System.Int32"/> equivalent.
        /// </summary>   
        /// <param name="input">The string to be converted.</param>
        /// <returns>A <see cref="T:System.Int32"/> representation of the given string.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Converts the value of this instance to its <see cref="T:System.Int64"/> equivalent.
        /// </summary>     
        /// <param name="input">The string to be converted.</param>
        /// <returns>A <see cref="T:System.Int64"/> representation of the given string.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Converts the value of this instance to its <see cref="T:System.DateTime"/> equivalent.
        /// </summary>      
        /// <param name="input">The string to be converted.</param>
        /// <returns>A <see cref="T:System.DateTime"/> representation of the given string.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Makes the first letter of this string capital.
        /// </summary>        
        /// <returns>Returns <see cref="System.String"/> whose first letter is capital.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Returns a substring from this instance.The substring starts at a specified character position
        /// and represents the string between specified starting string and specified ending string.        
        /// </summary>    
        /// <param name="input">The string in which the search will be performed.</param>
        /// <param name="startString">The string you want to start from.</param>
        /// <param name="endString">The string you want to end at.</param>
        /// <param name="startFrom">The zero-based starting character position of a substring in this instance.</param>
        /// <returns></returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Converts the Cyrillic characters of this instance to Latin ones.
        /// </summary>
        /// <param name="input">The string whose characters will be converted</param>
        /// <returns>Returns the converted <see cref="System.String"/>.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Converts the Latin characters of this instance to Cyrillic ones.
        /// </summary>
        /// <param name="input">The string whose characters will be converted</param>
        /// <returns>Returns the converted <see cref="System.String"/>.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Returns a string in which the Cyrillic letters are replaced with their Latin equivalents
        /// and all non-alphanumeric characters (excluding the period ".") are removed.
        /// </summary>
        /// <param name="input">The string which will be validated.</param>
        /// <returns>Returns a validated username string.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Returns a string in which the Cyrillic letters are replaced with their Latin equivalents,
        /// spaces are replaced with hyphens and all non-alphanumeric characters 
        /// (excluding the period "." and hyphen "-") are removed.</summary>
        /// <param name="input">The file name which will be validated</param>
        /// <returns>Returns a validated file name string</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Returns the first <see cref="charsCount"/> number of letter of this instance.
        /// </summary>
        /// <param name="input">The string whose first <see cref="charsCount"/> characters will be returned.</param>
        /// <param name="charsCount">The number of the characters to be returned starting from the zero-based character.</param>
        /// <returns>Returns a string representing the first <see cref="charsCount"/> characters of <see cref="input"/>.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Gets the extension of a file-name-like <see cref="System.String"/>.
        /// </summary>
        /// <param name="fileName">The file-name-like string to get the extension of.</param>
        /// <returns>Returns an empty string if there is no file extension or a string representing the file extension.</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Returns the corresponding content type for the specified file extension.
        /// </summary>
        /// <param name="fileExtension">The file extension (excluding the period ".").</param>
        /// <returns>The content type as a string.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts a set of characters from the specified character array into a sequence of bytes.
        /// </summary>
        /// <param name="input">The string, whose characters are going to be converted into a 
        /// sequence of bytes.</param>
        /// <returns>A byte array containing the specified set of characters.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
