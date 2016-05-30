using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../test.txt";

            //StreamWriter writer = new StreamWriter(path, true);

            //using (writer)
            //{
            //    writer.WriteLine("New line from program");
            //    writer.Close();
            //}

            StreamReader reader = new StreamReader(path);

            int count = 0;
            string text = reader.ReadToEnd();

            int index = text.IndexOf("Alien", 0);

            while (index != -1)
            {
                count++;
                index = text.IndexOf("Alien", index + 1);
            }



            Console.WriteLine(count);
            //using (reader)
            //{
            //    string line = reader.ReadLine();

            //    while (line != null)
            //    {
            //        Console.WriteLine(line);
            //        line = reader.ReadLine();
            //    }


            //    reader.Close();
            //}


        }
    }
}
