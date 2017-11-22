using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.IO;
using System.IO.Compression;




namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Directorios
            DirectoryInfo DicStart = new DirectoryInfo(@"C:\Users\Sistemas\Desktop\mail\");
            DirectoryInfo DicStart2 = new DirectoryInfo(@"C:\Users\Sistemas\Desktop\mail\des");

            DirectoryInfo directory = new DirectoryInfo(@"C: \Users\Sistemas\Desktop\mail\des");
            DirectoryInfo[] directories = directory.GetDirectories();


            for (int i = 0; i < directories.Length; i++)

            {
                var result = directories[i].Name;
            
                foreach (var fi2 in DicStart2.GetFiles("*", SearchOption.AllDirectories))
                {
                    DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Sistemas\Desktop\mail\des\" + result);
                    int count = dir.GetFiles().Length;

                    for (int f = 0; f <= count;  f++)
                    {
                        // Console.WriteLine("Esta es la carpeta: " + result);
                        // Console.WriteLine("Lo que hay en la carpeta " + DicStart2 + " Es: " + fi2);
                        if (fi2.Extension == ".pdf")
                        {
                            string sourceFile = @"C:\Users\Sistemas\Desktop\mail\des\" + result + "\\" + fi2;
                            string destinationFile = @"C:\Users\Sistemas\Desktop\mail\2000\" + fi2;

                            // To move a file or folder to a new location:
                            System.IO.File.Move(sourceFile, destinationFile);
                            Console.WriteLine("Se movio el "++""+);
                            Console.WriteLine("Se movio a Slam");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("NO se movio");
                        }
                    }

                    i++;

                }

            }



            Console.ReadKey();
        }
    }
}
