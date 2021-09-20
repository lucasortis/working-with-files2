using System;
using System.IO;

namespace WorkingWithFiles2
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\Lucas Ortis\Downloads\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                
            }
            catch (IOException e)
            {
                Console.Write("An error ocurred " + e.Message);
            }
            finally
            {
                if (fs != null ) fs.Close();
                if (sr != null) sr.Close();
            }


            //Utilizando o File para não precisar instanciar duas classes
            string path2 = @"C:\Users\Lucas Ortis\Downloads\file2.txt";
            StreamReader sr2 = null;

            try
            {
                sr2 = File.OpenText(path2);
                while (sr2.EndOfStream == false)
                {
                    Console.WriteLine(sr2.ReadLine()); 
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred " + e.Message);
            }
            finally
            {
                if (sr2 != null) sr2.Close();
            }


        }
    }
}
