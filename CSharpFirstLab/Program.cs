using System;

namespace CSharpFirstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int startIndex = 0;
            var endIndex = 0;
            var found = false;
            var count = "";
            decimal sum = 0;


            for (startIndex.ToString(); startIndex < input.Length; startIndex++)
            {

                for (startIndex.ToString(); startIndex < input.Length - 1; startIndex++)
                {
                    count += input[startIndex];
                    for (endIndex = startIndex + 1; endIndex < input.Length; endIndex++)
                    {
                        count += input[endIndex];
                        if (!Char.IsDigit(input[startIndex]) || !Char.IsDigit(input[endIndex]))
                        {

                            break;

                        }
                        else if (input[startIndex] == input[endIndex])
                        {
                            sum += decimal.Parse(count);
                            found = true;
                            count = "";
                            break;


                        }
                    }
                    if (found)
                    {
                        break;
                    }
                    count = "";
                }

                if (!found)
                {
                    Console.WriteLine($"Total : {sum}");
                    return;
                }

                for (int i = 0; i < input.Length; i++)
                {
                    if (i < startIndex)
                    {
                        PrintChar(input[i], ConsoleColor.White);
                    }
                    else if (startIndex <= i && i <= endIndex)
                    {
                        PrintChar(input[i], ConsoleColor.Green);

                    }
                    else if (i > endIndex)
                    {
                        PrintChar(input[i], ConsoleColor.White);
                    }
                }

                found = false;

                Console.WriteLine();

            }

        }
        private static void PrintChar(char ch, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(ch);
            Console.ResetColor();
        }
    }
}