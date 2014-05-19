using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanLibrary
{
    public abstract class Human
    {
        public string firstName;
        public string lastName;
        public string FirstName 
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("The First Name is invalid");
                }
            }
        }
        public string LastName 
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("The Last Name is invalid");
                }
            }
        }

    }
}
