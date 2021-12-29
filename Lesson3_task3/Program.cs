using System;
using System.IO;

namespace Lesson3_task3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            InfoPerson info = new InfoPerson();
            string str;
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());

            // чтение из файла
            string pathToFile = $"{Directory.GetCurrentDirectory()}\\Info.txt";
            string readAllFile = File.ReadAllText(pathToFile);

            string[] readEveryLine = new string[5];
            // записываем в массив каждую строку файла
            readEveryLine = File.ReadAllLines(pathToFile);

            string pathToFileEmail = $"{Directory.GetCurrentDirectory()}\\Email.txt";
            // Добавим новую строку в наш файл
            File.AppendAllText(pathToFileEmail, Environment.NewLine);
            foreach (string  strOne in readEveryLine)
            {
                str = Convert.ToString(strOne);
                info.SearchMail(ref str);
                File.AppendAllText(pathToFileEmail, $"{str}\r\n");
            }

        }
    }
}
