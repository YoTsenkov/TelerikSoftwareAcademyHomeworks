namespace _2.FindRangeEfficiently
{
    using System;

    public class Product : IComparable<Product>
    {
        private string name;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string  Name {
            get
            {
                return this.name;
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name cant be null or empty");
                }

                this.name = value;
            }
        }

        public decimal Price  { get; set; }

        public int CompareTo(Product other)
        {
            if (this.Price < other.Price)
            {
                return -1;
            }
            else if (this.Price > other.Price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
