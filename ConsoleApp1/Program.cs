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
            DirectoryInfo DicStart = new DirectoryInfo(@"C:\Users\Sistemas\Desktop\MOV\winrar");
            DirectoryInfo DicStart2 = new DirectoryInfo(@"C:\Users\Sistemas\Desktop\MOV\descomprimir");

            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Sistemas\Desktop\MOV\descomprimir");
            

            foreach (var fi in DicStart.GetFiles("*.zip"))
            {
                Console.WriteLine(fi.Name);
                string zipPath = @"C:\Users\Sistemas\Desktop\MOV\winrar\" + fi;
                string extractPath = @"C:\Users\Sistemas\Desktop\MOV\descomprimir\";


                //Crear Zip
                // ZipFile.CreateFromDirectory(startPath, zipPath);
                //Decomprimir zip

                ZipFile.ExtractToDirectory(zipPath, extractPath);

                Console.WriteLine("Se descomprimio" + fi);
            }


            DirectoryInfo[] directories = directory.GetDirectories();

            for (int i = 0; i<directories.Length; i++)

            {
                var result = directories[i].Name;
            
               
                    DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Sistemas\Desktop\MOV\descomprimir\" + result);
                    int count = dir.GetFiles().Length;

                    for (int f = 0; f <= count;  f++)
                    {
                        foreach (var fi2 in DicStart2.GetFiles("*", SearchOption.AllDirectories))
                        {
                            // Console.WriteLine("Esta es la carpeta: " + result);
                            // Console.WriteLine("Lo que hay en la carpeta " + DicStart2 + " Es: " + fi2);

                            if (fi2.Extension == ".pdf")
                            {
                                string sourceFile = @"C:\Users\Sistemas\Desktop\MOV\descomprimir\" + result + "\\" + fi2;
                                string destinationFile = @"C:\Users\Sistemas\Desktop\MOV\pdf\" + fi2;

                                // To move a file or folder to a new location:
                                System.IO.File.Move(sourceFile, destinationFile);
                                Console.WriteLine("Se movio el " + fi2 + " a la carpeta Descomprimir");
                                Console.WriteLine("Se movio a Slam");
                            }
                            else
                            {
                                Console.WriteLine("No se movio el" + fi2);
                                Console.WriteLine("NO se movio");
                            }


                        }
                        
                    }

            }
            Console.ReadKey();
        }
    }
}
