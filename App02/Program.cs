using System;
using System.IO;


namespace App02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string v1;// Variable declaration
            v1 = "Asp.NET Core App Developmnet Course"; // Variable initialization


            //[DataType] [VariableName] = [Value];
            string v2 = "C# Programming Course"; // Variable declaration and initialization


            int x1 = 100;

            DateTime d = DateTime.Now;

            //Console.WriteLine("Alhamdulillah");
            //Console.WriteLine(v1);
            //Console.WriteLine(v2);
            //Console.WriteLine(d);
            //Console.WriteLine(x1);

            //show(v1);
            //show(v2);
            Console.Write("Please Write Your Folder Name:");
            string folderName = Console.ReadLine();

            getFiles(folderName);

            Console.ReadLine();
            //App02.Education.Formal.Professional
        }

        static void show(string s)
        {
            if (s == null)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(@"////////"+s+@"\\\\\\\\\\");
            }
        }

        static void getFiles(string f)
        {
            if (string.IsNullOrEmpty(f))
            {
                Console.WriteLine("Invalid folder name.");
                return;
            }
            if(!Directory.Exists(f))
            {
                Console.WriteLine("Sorry folder does not exist.");
                return;
            }
            string[] files = Directory.GetFiles(f);
            foreach (string file in files)
            { 
                show(file);
            }

        }
    }

    namespace Education 
    { 
        namespace Formal 
        { 
            namespace Acdemic 
            {
            
            }

            namespace Professional 
            {

            }

            namespace NonAcdemic 
            {

            }
        }
        namespace InFormal 
        {

           
        }
        namespace Other
        {

        }

    }

}
