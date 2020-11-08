using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Document
{
    class Program
    {
        static void CreateFile()
        {
            // requirement 1
            Console.WriteLine("Document");
            Console.WriteLine();

            // requirement 2
            String name = "";
            Console.WriteLine("Enter document name: ");
            name = Console.ReadLine();

            // requirement 3
            String contents = "";
            int count = 0;
            Console.WriteLine("Enter contents: ");
            contents = Console.ReadLine();
            count += contents.Length;

            // requirement 4 and optional requirement 1
            string extension = name.Substring(Math.Max(0, name.Length - 4));
            string fileName;
            if (extension == ".txt")
                fileName = name;
            else
                fileName = name + ".txt";

            StreamWriter File = new StreamWriter(fileName);

            try
            {
                // requirement 5
                File.Write(contents);
            }
            catch (Exception e)
            {
                // requirement 6
                Console.WriteLine(e.Message);
            }
            finally
            {
                // optional requirement 2
                if (File != null)
                    File.Close();
                Console.WriteLine(name + " was successfully saved. The document contains " + count + " characters.");
            }

        }

        static void Main(string[] args)
        {
            do
            {
                CreateFile();
                // optional requirement 3
                Console.WriteLine("Would you like to create more files? (y/n)"); 
                char answer = Console.ReadLine()[0]; 
                if (answer == 'n') 
                    break; 
            } while (true); 
        }
    }
}
    


