using System;
class Program
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        uint check;
        int add = 15;
        for (int i = 0; i < 15; i++)
        {
            check = (number >> add) & 1;

            if (check == 0)
            {
                Console.Write("###.");             
            }
            else
            {
                Console.Write(".#..");             
            }
            add--;
        }
            check = number & 1;
            if (check == 0)
            {
                Console.Write("###");
                          
            }
            else
            {
                Console.Write(".#.");
               
            }
        Console.WriteLine();

        add = 15;
        for (int i = 0; i < 15; i++)
        {
            check = (number >> add) & 1;

            if (check == 0)
            {
                Console.Write("#.#.");
            }
            else
            {
                Console.Write("##..");
            }
            add--;
        }
            check = number & 1;
            if (check == 0)
            {
                
                Console.Write("#.#");
                
            
            }
            else
            {
               
                Console.Write("##.");
                
            }
        Console.WriteLine();
        add = 15;
        for (int i = 0; i < 15; i++)
        {
            check = (number >> add) & 1;

            if (check == 0)
            {
                Console.Write("#.#.");
            }
            else
            {
                Console.Write(".#..");
            }
            add--;
        }
        check = number & 1;
        if (check == 0)
        {
            
            Console.Write("#.#");
            

        }
        else
        {
            
            Console.Write(".#.");
            
        }
        Console.WriteLine();
        add = 15;
        for (int i = 0; i < 15; i++)
        {
            check = (number >> add) & 1;

            if (check == 0)
            {
                Console.Write("###.");
            }
            else
            {
                Console.Write("###.");
            }
            add--;
        }

        check = number & 1;
        if (check == 0)
        {
            
            Console.Write("###");

        }
        else
        {
            
            Console.Write("###");
        }
    }
}

