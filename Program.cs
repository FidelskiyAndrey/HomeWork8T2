using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork8T2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = @"C:\Users\andrey\Documents\10numbers.txt";
            FileStream fs=File.Create(path);
            fs.Close();
            
            Random random = new Random();

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                for (int i = 0; i < 10; i++)
                {   
                    sw.Write("{0} ", random.Next(0, 50));
                }    
            }

            Console.WriteLine("Числа записанные в файл TXT");
            using (StreamReader sr = new StreamReader(path)) 
            {
                Console.WriteLine(sr.ReadToEnd());
            }

            StreamReader f = new StreamReader(@"C:\Users\andrey\Documents\10numbers.txt");
            string[] a = f.ReadToEnd().Split(' ');
            int S = 0;
            
            for (int i = 0; i < 10; i++)
            {           
                S += Convert.ToInt32(a[i]);
            }
            
            Console.WriteLine("СУмма случайных чисел равна:{0}",S);
            Console.ReadKey();
        }
    }
}
