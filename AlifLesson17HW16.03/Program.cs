using System;
using System.Linq;

namespace AlifLesson17HW16._03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Sumbol = new string[] { "+", "-", "*", "/" };
            var TextQuery = new string((from ch in Console.ReadLine()
                                        where Char.IsDigit(ch) || ch == '+' || ch == '-' || ch == '*' || ch == '/'
                                        select ch).ToArray());
            string sumbol = Sumbol.FirstOrDefault(S => TextQuery.Contains(S));
            int part1 = int.Parse(new string(TextQuery.TakeWhile(ch => ch.ToString() != sumbol).ToArray()));
            int part2 = int.Parse(new string(TextQuery.Reverse().TakeWhile(s => s.ToString() != sumbol).Reverse().ToArray()));
            int result = 0;
            switch (sumbol)
            {
                case "+":
                    {
                        result = part1 + part2;
                    }
                    break;
                case "-":
                    {
                        result = part1 - part2;
                    }
                    break;
                case "*":
                    {
                        result = part1 * part2;
                    }
                    break;
                case "/":
                    {
                        result = part1 / part2;
                    }
                    break;
            }
            Console.WriteLine(result.ToString());

            string Text = Console.ReadLine();
            Console.WriteLine(Text.Replace('a', '1').Replace('e', '2').Replace('i', '3').Replace('o', '4').Replace('u', '5'));
            string text = Console.ReadLine();
            Console.WriteLine(text.Replace('1', 'a').Replace('2', 'e').Replace('3', 'i').Replace('4', 'o').Replace('5', 'u'));

            string inputString = "camelCasing";
            Console.WriteLine(inputString.Aggregate(string.Empty, (result, str) =>
            {
                if (char.IsUpper(str) && result.Length > 0)
                {
                    result += ' ';
                }
                return result + str;
            }));
        }
    }
}
