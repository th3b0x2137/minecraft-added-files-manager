using System;

namespace minecraft_added_files_manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileK;
            string fileN;
            string fileDes;
            string fileSource = @"c:\Users\maksy\Downloads";
            /*
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\mods";
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\resourcepacks";
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\shaderpacks";
            */
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
                    fileDes = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\mods";
                    File.Copy(Path.Combine(fileSource, fileN+ ".jar"), Path.Combine(fileDes, fileN + ".jar"));


                }
                if (fileK == "texturepack")
                {
                    Console.WriteLine("Enter the name of a file: ");
                    fileN = Convert.ToString(Console.ReadLine());
                    fileDes = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\resourcepacks";
                    File.Copy(Path.Combine(fileSource, fileN + ".zip"), Path.Combine(fileDes, fileN + ".zip"));
                }
                if (fileK == "shadespack")
                {
                    Console.WriteLine("Enter the name of a file: ");
                    fileN = Convert.ToString(Console.ReadLine());
                    fileDes = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\shaderpacks";
                    File.Copy(Path.Combine(fileSource, fileN + ".zip"), Path.Combine(fileDes, fileN + ".zip"));

                }
                else if(fileK != "mod" && fileK != "texturepack" && fileK != "shadespack")
                {
                    Console.WriteLine("Please enter correct file kind");
                }
            } while(fileK != "mod" && fileK != "texturepack" && fileK != "shadespack");
            Console.ReadLine();
        }
    }
}
