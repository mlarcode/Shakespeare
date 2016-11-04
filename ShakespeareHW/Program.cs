using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShakespeareHW
{
    class Program
    {
        static void Main()
        {
            // Print 1st line 
            string line;
            StreamReader reader = new StreamReader("ShakeS.txt");
            using (reader)
            {
                line = reader.ReadLine();
            }
            Console.WriteLine(line);
            Console.ReadToEnd();
            {
                line = reader.ReadLine();
                while (line ! = null);
            }
            {
                string lowercase = line.ToLower();
                for (int i = 0; i < lowercase.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write(char.ToUpper(lowercase[i]));
                    }
                    else
                    {

                    }
                    Console.Write(lowercase);
                    Console.WriteLine();
                    line = reader.ReadLine();
                }
            }
            
           








        }
    }
}
