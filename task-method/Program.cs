using System;

namespace task_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string example = "bU tasKI metHodla yAzmAliSiz";
            Console.WriteLine(example);
            string task= example.Replace("bU tasKI metHodla yAzmAliSiz", "Bu Taskı Methodla Yazmalısız");
            Console.WriteLine(task);
        }
    }
}
