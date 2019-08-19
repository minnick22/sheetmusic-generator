using System;
using System.IO;

namespace sheetmusic_generator
{
    
    /**
     * The FileManager will handle all file I/O for the project.
     *
     * It will be passed file locations and data to write, as well as
     * handle any incoming file reads.
     * 
     */
    public class FileManager
    {

        private static StreamReader reader;
        private static StreamWriter writer;
        private const string PROJ_HOME = "C://Users/Mike/Desktop/sheetmusic-generator";

        public FileManager()
        {
            Console.WriteLine("I am the FileManager, and I have been created!");
        }

        public void DoSomething(string test)
        {
            Console.WriteLine(test);
        }

        public void Write(string filename, string data)
        {
            writer = new StreamWriter(PROJ_HOME + "/output/" + filename);
            writer.WriteLine(data);
            writer.Close();
            Console.WriteLine("Written to " + filename);
        }

        public string Open(string filename)
        {
            string output = "";
            reader = new StreamReader(PROJ_HOME + "/output/" + filename);
            try
            {
                do
                {
                    output += reader.ReadLine();
                } while (reader.Peek() != -1);
            }
            catch
            {
                Console.WriteLine(filename + " is empty or does not exist.");
            }
            finally
            {
                reader.Close();
            }
            return output;
        }
    }
}