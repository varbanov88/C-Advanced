using System;

namespace FormattingNumbers
{
    public class FormattingNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var a = int.Parse(numbers[0]);
            var b = double.Parse(numbers[1]);
            var c = double.Parse(numbers[2]);

            var aHex = a.ToString("X");
            var aBin = Convert.ToString(a, 2);

            if (aBin.Length > 10)
            {
                aBin = aBin.Substring(0, 10);
            }

            Console.WriteLine(string.Format("|{0}|{1}|{2:f2}|{3:f3}|", aHex.PadRight(10, ' '), aBin.PadLeft(10, '0'), b.ToString("f2").PadLeft(10, ' '), c.ToString("f3").PadRight(10, ' ')));
        }
    }
}
