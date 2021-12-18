using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace PerformanceInsertCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            if (TryGetText(out text))
            {
                string[] stringArray = text.GetStringArray();

                TestList testList = new TestList();
                TestLinkedList testLinkedList = new TestLinkedList();

                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();

                testList.GetListString(stringArray);
                Console.WriteLine($"Вставка в список: {stopwatch.Elapsed.TotalMilliseconds}  мс");

                stopwatch.Restart();

                testList.GetListString(stringArray);
                Console.WriteLine($"Вставка в связный список: {stopwatch.Elapsed.TotalMilliseconds}  мс");

                stopwatch.Stop();
                Console.ReadKey();
            }
        }

        private static bool TryGetText(out string text)
        {
            text = string.Empty;
            try
            {
                string fileName = "Text1.txt";
                if (File.Exists(fileName))
                {
                    text = File.ReadAllText("Text1.txt");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Файл {fileName} не найден");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return false;
        }
    }
}
