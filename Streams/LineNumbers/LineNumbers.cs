using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        public static void Main()
        {
            var filePath = "../../test.txt";

            using (var reader = new StreamReader(filePath))
            using (var writer = new StreamWriter("../../result.txt"))
            {
                var readLine = reader.ReadLine();
                var counter = 1;

                while (true)
                {

                    writer.WriteLine($"{counter}. {readLine}");
                    counter++;
                    readLine = reader.ReadLine();
                    if (readLine == null)
                    {
                        break;
                    }
                }
            }
        }
    }
}
