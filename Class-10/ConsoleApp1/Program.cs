using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileCreate();
            //ReadTextFile();

            //string fn = @"E:\Saiful\tempData\newDirectory";
            //CreateDirectory(fn);
            string fn = @"E:\Saiful\tempData\streamWriter2025_07_19_054739.txt";
            ReadTextFileByStreamReader(fn);

            //ReadTextFile(fn);
            //ReadTextFileByLines(fn);

            //string[] contents = { "Length", "Minimum", "Data Type", "Number", "Special Characters" };
            //FileCreate(contents);
            //CreateFileByStreamWriter(contents);
            Console.ReadLine(); 

        }

        static void CreateFileByStreamWriter(string[] contents)
        {
            string file_name = @"E:\Saiful\tempData\streamWriter" + DateTime.Now.ToString("yyyy_MM_dd_hhmmss") + ".txt";

            if (File.Exists(file_name))
            {
                Console.WriteLine("File already Exists. Please try again.");
                Console.ReadLine();
                return;
            }

            if (contents.Length <= 0)
            {
                Console.WriteLine("File Contents could not be null.");
            }

            using (StreamWriter sw = new StreamWriter(file_name))
            {
                foreach(var item in contents)
                {
                    sw.WriteLine(item);
                }
            }
            Console.WriteLine("File has been Created Suceessfully");
        }
        static void FileCreate()
        {
            string file_name = @"E:\Saiful\tempData\data.txt";
            string content = @"ABcd
                                kjfeia
                                    jhfkaeuh";

            if (File.Exists(file_name))
            {
                Console.WriteLine("File already Exists. Please try again.");
                Console.ReadLine();
                return;
            }


            File.WriteAllText(file_name, content);
            Console.WriteLine("File has been Created Suceessfully");
            Console.ReadLine();
        }

        static void ReadTextFile()
        {


            string file_name = @"E:\Saiful\tempData\data.txt";
            //string content = "";

            if (File.Exists(file_name))
            {
                string content = File.ReadAllText(file_name);
                Console.WriteLine($"{file_name} {content}");

            }
            else
            {
                Console.WriteLine("Sorry ! File not found.");
            }
        }
        static void ReadTextFile(string file_name)
        {
            if (string.IsNullOrEmpty(file_name))
            {
                Console.WriteLine("File name must be provided.");
                return;
            }
            

            if (File.Exists(file_name))
            {
                string content = File.ReadAllText(file_name);
                Console.WriteLine($"{file_name} {content}");

            }
            else
            {
                Console.WriteLine("Sorry ! File not found.");
            }
        }

        static void ReadTextFileByLines(string file_name)
        {
            if (string.IsNullOrEmpty(file_name))
            {
                Console.WriteLine("File name must be provided.");
                return;
            }


            if (File.Exists(file_name))
            {
                string[] content = File.ReadAllLines(file_name);
                foreach (var line in content)
                {
                    Console.WriteLine(line);
                }

            }
            else
            {
                Console.WriteLine("Sorry ! File not found.");
            }
        }

        static void FileCreate(string[] contents)
        {
            string file_name = @"E:\Saiful\tempData\"+DateTime.Now.ToString("yyyy_MM_dd_hhmmss")+".txt";
            
            if (File.Exists(file_name))
            {
                Console.WriteLine("File already Exists. Please try again.");
                Console.ReadLine();
                return;
            }

            if(contents.Length <= 0)
            {
                Console.WriteLine("File Contents could not be null.");
            }


            File.WriteAllLines(file_name, contents);
            Console.WriteLine("File has been Created Suceessfully");
            
        }

        static void CreateDirectory(string dir_path) 
        {
            if (string.IsNullOrEmpty(dir_path)) 
            {
                Console.WriteLine("Directory Contents could not be null or empty.");
                return;
            }

            if (Directory.Exists(dir_path)) 
            {
                Console.WriteLine("Directory already Exists.");
            }

            Directory.CreateDirectory(dir_path);
            Console.WriteLine("Done! Directory has been Create successfully.");

        }

        static void ReadTextFileByStreamReader(string file_name)
        {
            if (string.IsNullOrEmpty(file_name))
            {
                Console.WriteLine("File name must be provided.");
                return;
            }


            if (File.Exists(file_name))
            {
                using(StreamReader sr = new StreamReader(file_name))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }

                }
                

            }
            else
            {
                Console.WriteLine("Sorry ! File not found.");
            }
        }
    }

}
