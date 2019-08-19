using System;

namespace sheetmusic_generator
{
    internal class Program
    {

        private static FileManager _fileManager;
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");
            _fileManager = new FileManager();
            _fileManager.Write("hello_world.txt", "Hello, World! \nMy name is sheetmusic-generator.");
            _fileManager.Write("output1.txt", "Noice");

            string world = _fileManager.Open("hello_world.txt");
            Console.Write(world);
        }
    }
}