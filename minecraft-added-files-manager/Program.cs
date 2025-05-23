using System;

namespace minecraft_added_files_manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileK;
            string fileN;
            string fileDesM = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\mods";
            string fileDesT = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\resourcepacks";
            string fileDesS = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\shaderpacks";

            do
            {
                Console.WriteLine("Select the kind of file you want to import:");
                Console.WriteLine("Mod    |    Texturepack    |    Shaderpack");

                fileK = Convert.ToString(Console.ReadLine());
                fileK.ToLower();

                if (fileK == "mod")
                {
                    Console.WriteLine("Enter the name of a file: ");
                    fileN = Convert.ToString(Console.ReadLine());
                }
                if (fileK == "texturepack")
                {

                }
                if (fileK == "shadespack")
                {

                }
            }while(fileK != "mod" || fileK != "texturepack" || fileK != "shadespack");

        }
    }
}
