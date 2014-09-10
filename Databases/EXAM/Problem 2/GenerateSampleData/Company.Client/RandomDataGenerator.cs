using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Client
{
    internal class RandomDataGenerator : IRandomDataGenerator
    {
        private const string Letters = "ABCDEFGHIJKLMNOPQRSTUWXYZabcdefghijklmnopqrstuwxyz";
        private static IRandomDataGenerator randomDatagenerator;
        private Random random;

        private RandomDataGenerator()
        {
            this.random = new Random();
        }

        public static IRandomDataGenerator Instance
        {
            get
            {
                if (randomDatagenerator == null)
                {
                    randomDatagenerator = new RandomDataGenerator();
                }

                return randomDatagenerator;
            }
        }

        public int GetRandomNumber(int min, int max)
        {
            return this.random.Next(min, max + 1);
        }

        public string GetRandomString(int length)
        {
            var result = new char[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = Letters[this.GetRandomNumber(0, Letters.Length - 1)];
            }

            return new string(result);
        }

        public string GetRandomStringWithRandomLength(int min, int max)
        {
            return this.GetRandomString(this.GetRandomNumber(min, max));
        }
    }
}
