using System;
class Company_Info
{
    static void Main()
    {
        Console.WriteLine("enter company name");
        string name = Console.ReadLine();
        Console.WriteLine("enter company address");
        string address = Console.ReadLine();
        Console.WriteLine("enter company phone");
        long companyPhone = long.Parse(Console.ReadLine());
        Console.WriteLine("enter fax number");
        long fax = long.Parse(Console.ReadLine());
        Console.WriteLine("enter company site");
        string site = Console.ReadLine();
        Console.WriteLine("enter manager's first name");
        string firstName = Console.ReadLine();
        Console.WriteLine("enter manager's middle name");
        string middleName = Console.ReadLine();
        Console.WriteLine("enter manager's last name");
        string lastName = Console.ReadLine();
        Console.WriteLine("enetr manager's age");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("enter manager's phone number");
        long managerPhone = long.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Company name - {0}", name);
        Console.WriteLine("Company address - {0}", address);
        Console.WriteLine("Company phone - {0}", companyPhone);
        Console.WriteLine("Company fax number - {0}", fax);
        Console.WriteLine("Company site - {0}", site);
        Console.WriteLine("Company's manager name - {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Company's manager age - {0}", age);
        Console.WriteLine("Company's manager phone - {0}", managerPhone);


    }
}

