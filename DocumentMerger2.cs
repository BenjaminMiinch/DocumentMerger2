using System;
using System.IO;

namespace DocumentMerger2
{
    class DocumentMerger2
    {
        static void Main(string[] args)
        {

            string fileContents = "";

            if (args.Length < 3)
            {
                Console.WriteLine("Supply a list of text files to merge followed by the name of the resulting merged text file as command line arguments.");
                Console.WriteLine("The correct format is DocumentMerger2.exe <input_file_1> <input_file_2> ... <input_file_n> <output_file>\n");
            }

            else
            {
                int i = 0;

                for (i = 0 ; i < args.Length - 1; i++)
                {
                    string fileName = args[i];

                    try
                    {
                        StreamReader sr = new StreamReader(fileName + ".txt");  //adds the .txt to the end of the name

                        string line = sr.ReadLine();                            //reads input from user

                        fileContents = fileContents + line;                     //assigns that input to label the contents of the file

                        while (line != null)                                    //This loop will repeat the above process until there are no files left to add
                        {                                                       //
                            line = sr.ReadLine();

                            fileContents += line;               

                            fileContents = fileContents + line;
                        }

                    }

                    catch (Exception e)                                         //Error exception message
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                }

                String mergedFiles = args[args.Length - 1];

                try
                {
                    StreamWriter sw = new StreamWriter(mergedFiles + ".txt.");  //now that the files are merged, a filename is made and  adds .txt to it

                    Console.WriteLine("\n" + mergedFiles + " was successfully saved");

                }

                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);

                }
            }

        }
    }
}