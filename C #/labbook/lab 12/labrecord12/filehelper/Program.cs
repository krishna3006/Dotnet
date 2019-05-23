using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LabRecordDay12
{
    class FileHelper
    {
        string fileContent = null;
        StreamWriter sw = null;
        StreamReader sr = null;
        public FileHelper()
        {
        }
        public bool WriteFile(string filePath, string fileContent)
        {
            sw.WriteLine(fileContent);
            sw.Close();
            return true;
        }
        public void ReadFile(string filePath)
        {
            fileContent = sr.ReadToEnd();
            sr.Close();
            Console.WriteLine("File content:\n{0}\n\n", fileContent);
        }
        public int NoOfWordsInFile()
        {
            string[] words = fileContent.Split(' ');
            return words.Length;
        }
    }
    class Program3
    {
        static FileHelper fileHelperObj = null;
        static Program3()
        {
            fileHelperObj = new FileHelper();
        }
        static void Main(string[] args)
        {
            try
            {
                int choice = 0;
                do
                {
                    PrintMenu();
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter File Content.");
                            string data = Console.ReadLine();
                            WriteFile(data);
                            break;
                        case 2:
                            Console.WriteLine("Enter File Path");
                            ReadFile(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine
                            ("Word Count: {0}\n",
                            fileHelperObj.NoOfWordsInFile());
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                } while (choice != 4);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        static void ReadFile(string filePath)
        {
            fileHelperObj.ReadFile(filePath);
        }
        static void PrintMenu()
        {
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n\n{5}",
            "Welcome to File Debugging ",
            "1. Create a new File", "2. Read a existing File",
            "3. Return the no of words in the file which was read.\n" +
            "Note: For this to work, you have to Read File using Option 2",
            "4. Exit the Application.",
            "Enter your choice");
        }
        static void WriteFile(string content)
        {

            if (fileHelperObj.WriteFile(@"D:\MyFile.txt", content))
            {
                Console.WriteLine("File Created.....\n");
            }
        }
    }
}

