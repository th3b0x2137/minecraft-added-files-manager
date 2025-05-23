using System;

namespace minecraft_added_files_manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileK;
            Console.WriteLine("Select the kind of file you want to import:");
            Console.WriteLine("Mod     |     Texturepack     |     Shaders");
            fileK = Convert.ToString(Console.ReadLine());
            fileK.ToLower();
            Console.WriteLine(fileK);


        }
    }
}
