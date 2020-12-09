using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace percentage_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable = default;
            char names = default;
            bool namesBool = false;

            while (variable <= 1)
            {
                Console.WriteLine("give amount of values");
                try
                {
                    variable = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("must be a number");
                }
            }

            while (names != 'Y' && names != 'N')
            {
                Console.WriteLine("named values? Y/N");
                try
                {
                    names = Convert.ToChar(Console.ReadLine().ToUpper());
                }
                catch
                {
                    continue;
                }
            }

            if (names == 'Y')
            {
                namesBool = true;
            }

            int[] varList = new int[variable];
            string[] varListName = new string[variable];

            for (int i = 0; i < variable; i++)
            {
                while (varList[i] == 0)
                {
                    if (namesBool == true)
                    {
                        Console.WriteLine($"give name of variable {i + 1}");
                        varListName[i] = Console.ReadLine();
                        if (varListName[i] == "break" || varListName[i] == "Break")
                        {
                            variable = i;
                            break;
                        }

                    }
                    else
                    {
                        varListName[i] = (i + 1).ToString();
                    }

                    while (varList[i] == 0)
                    {
                        Console.WriteLine($"give value of variable {varListName[i]}");

                        try
                        {
                            varList[i] = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("must be a number");
                        }
                    }
                }
            }

            int sum = new int();
            for (int i = 0; i < variable; i++)
            {
                sum = varList.Sum();
                double percentage = Convert.ToDouble(varList[i]) / sum;
                Console.WriteLine($"percentage value {varListName[i]} = {percentage:0.00%} ({varList[i]})");
            }

            Console.WriteLine($"total is {sum}");
            Console.Write("\n\nwhen ready press enter");
            Console.ReadLine();

        }
    }
}