using System.IO;

namespace CopyBinaryFile
{
    public class CopyBinaryFile
    {
        public static void Main()
        {
            using (FileStream source = new FileStream("../../img.jpg", FileMode.Open))
            {
                using (FileStream destination = new FileStream("../../result.txt", FileMode.Create))
                {
                    byte[] buffer = new byte[source.Length];

                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
