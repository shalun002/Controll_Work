using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
1.	В папке С:\temp создайте папки К1 и К2.
2.	В папке К1:
1.	создайте файл t1.txt, в который запишите следующий текст :
            Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов
2.	создайте файл t2.txt, в который запишите следующий текст:
            Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс
3.	В папке К2 создайте файл t3.txt, в который перепишите вначале текст из файла t1.txt, а затем из t2.txt
4.	Выведите развернутую информацию о созданных файлах.
5.	Файл t2.txt перенесите в папку K2.
6.	Файл t1.txt скопируйте в папку K2.
7.	Папку K2 переименуйте в ALL, а папку K1 удалите.
8.	Вывести полную информацию о файлах папки All.
*/

namespace Controll_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp";
            string pathK2 = @"C:\Temp\K2\t2.txt";
            string pathK2_ = @"C:\Temp\K2\t3.txt";
            string pathK1 = @"C:\Temp\K1\t1.txt";


            DirectoryInfo di = Directory.CreateDirectory(path);
            Console.WriteLine("Директория создана успешно {0}.", Directory.GetCreationTime(path));

            di.CreateSubdirectory(@"K1");
            di.CreateSubdirectory(@"K2");

            CreateFileK1(pathK2);
            CreateFileK2(pathK1);
            CreateFileK2_(pathK2_);

            DirectoryInfo dirTes = new DirectoryInfo(path);
            Console.WriteLine();
            Console.WriteLine("Все директории {0}.", dirTes.GetDirectories().Count());

            foreach (DirectoryInfo dir in dirTes.GetDirectories())
            {
                Console.WriteLine(dir.FullName);
                Console.WriteLine();
            }
        }

        static void CreateFileK1(string pathK1)
        {
            
            using (StreamWriter sw = new StreamWriter(pathK1))
            {
                sw.WriteLine("Иванов Иван Иванович, 1965 года рождения, место жительства г.Саратов");
            }
        }

        static void CreateFileK2(string pathK2)
        {
            using (StreamWriter sw = new StreamWriter(pathK2))
            {
                sw.WriteLine("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
            }
        }

        static void CreateFileK2_(string pathK2_)
        {
            using (StreamWriter sw = new StreamWriter(pathK2_))
            {
              
            }
        }
    }
}