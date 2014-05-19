using System;
class Program
{
    static void Main()
    {
        int sum = 0;

        int seven = int.Parse(Convert.ToString(int.Parse(Console.ReadLine()), 2));
        int six = int.Parse(Convert.ToString(int.Parse(Console.ReadLine()), 2));
        int five = int.Parse(Convert.ToString(int.Parse(Console.ReadLine()), 2));
        int four = int.Parse(Convert.ToString(int.Parse(Console.ReadLine()), 2));
        int three = int.Parse(Convert.ToString(int.Parse(Console.ReadLine()), 2));
        int two = int.Parse(Convert.ToString(int.Parse(Console.ReadLine()), 2));
        int one = int.Parse(Convert.ToString(int.Parse(Console.ReadLine()), 2));
        int zero = int.Parse(Convert.ToString(int.Parse(Console.ReadLine()), 2));

        //kolko sa pochnali
        int knights = 0;
        for (int i = 0; i < 8; i++)
        {

            if (((zero >> i) & 1) == 1)
            {
                knights++;
            }
           
            if (((one >> i) & 1) == 1)
            {
                knights++;
            }
            if (((two >> i) & 1) == 1)
            {
                knights++;
            }
            if (((three >> i) & 1) == 1)
            {
                knights++;
            }
            if (((four >> i) & 1) == 1)
            {
                knights++;
            }
            if (((five >> i) & 1) == 1)
            {
                knights++;
            }
            if (((six >> i) & 1) == 1)
            {
                knights++;
            }
            if (((seven >> i) & 1) == 1)
            {
                knights++;
            }
            
        }
       
        //..
        int endKnights = knights;
        int checkOne;
        string command = Console.ReadLine();
        while (command != "end")
        {
            
            int floorIndex = int.Parse(Console.ReadLine());
            int realFloor = floorIndex;
            switch (floorIndex)
            {
                case 0: floorIndex = zero;
                    break;
                case 1: floorIndex = one;
                    break;
                case 2: floorIndex = two;
                    break;
                case 3: floorIndex = three;
                    break;
                case 4: floorIndex = four;
                    break;
                case 5: floorIndex = five;
                    break;
                case 6: floorIndex = six;
                    break;
                case 7: floorIndex = seven;
                    break;
                default:
                    break;
            }
            int pos = int.Parse(Console.ReadLine());


            if (command == "select")
            {
                int mask = ~(1 << pos);
                floorIndex = floorIndex & mask;
            }
            else if (command == "kill")
            {
                if (pos < 0 || pos > 7 && realFloor != zero || realFloor != one)
                {
                    endKnights--;
                    int mask = ~(1 << pos);
                    floorIndex = floorIndex & mask;
                }
                else
                {
                    int check = (floorIndex >> pos) & 1;
                    if (check == 1)
                    {
                        endKnights--;
                        continue;
                    }
                    else
                    {
                        check = (floorIndex >> pos + 1) & 1;
                        checkOne = (floorIndex >> pos - 1) & 1;
                        if (check != checkOne)
                        {
                            endKnights--;
                            endKnights--;
                            int mask = ~(1 << pos);
                            floorIndex = floorIndex & mask;
                            if (check == 1)
                            {

                                mask = ~(1 << pos + 1);
                                floorIndex = floorIndex & mask;
                            }
                            else if (checkOne == 1)
                            {
                                mask = ~(1 << pos - 1);
                                floorIndex = floorIndex & mask;
                            }

                        }
                        else if (check == checkOne == true)
                        {
                            endKnights--;
                            continue;
                        }
                    }
                }
            }
            else if (command == "move")
            {
                if (pos < 0 || pos > 7 && realFloor != zero || realFloor != one)
                {
                    endKnights--;
                    int mask = ~(1 << pos);
                    floorIndex = floorIndex & mask;
                }
                else
                {
                    //int check = (floorIndex >> pos) & 1;
                    //checkOne = (floorIndex >> pos + 1) & 1;
                    //int checkTwo = (floorIndex >> pos - 1) & 1;
                    continue;
                }
            }
            string lol = Convert.ToString(floorIndex);
            sum += Convert.ToInt32(lol,2);
            command = Console.ReadLine();
        }
        Console.WriteLine(knights);
        Console.WriteLine(endKnights);
        Console.WriteLine(sum);

        
    }
}

