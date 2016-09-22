using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReaderHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("Shakespeare.txt");
            using (reader)
            {
                Console.WriteLine(reader.ReadLine()+"\n\n");
                
                Console.ReadKey();
            }
            StreamReader reader1 = new StreamReader("Shakespeare.txt");
            using (reader1)
            {
                Console.WriteLine(reader1.ReadToEnd() + "\n\n");

                Console.ReadKey();
            }

            StreamReader reader3 = new StreamReader("Shakespeare.txt");
            while (reader3.EndOfStream != true)
            {

                int currentCharInt = reader3.Read();
                char currentChar = (char)currentCharInt;
                string currentString = currentChar.ToString();
                if ((currentString.ToUpper() == "A") || (currentString.ToUpper() == "E") || (currentString.ToUpper() == "I") || (currentString.ToUpper() == "O") || (currentString.ToUpper() == "U"))
                {
                    Console.Write(currentString.ToUpper());
                }
                else
                {
                    Console.Write(currentString);
                }
                   System.Threading.Thread.Sleep(50);

                reader.Close();
                
            }
            Console.ReadKey();


        }
    }
}
