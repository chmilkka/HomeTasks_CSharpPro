using System.Drawing;

namespace HomeTask5
{
    internal class Program
    {
        static object lockObj = new object();
        static async Task Main(string[] args)
        {
            var file1 = WriteLine("C:\\Users\\Chmil\\Desktop\\demo1.txt", ConsoleColor.Red);
            var file2 = WriteLine("C:\\Users\\Chmil\\Desktop\\demo2.txt", ConsoleColor.Green);
            var file3 = WriteLine("C:\\Users\\Chmil\\Desktop\\demo3.txt", ConsoleColor.Blue);
            var file4 = WriteLine("C:\\Users\\Chmil\\Desktop\\demo4.txt", ConsoleColor.Cyan);
            var file5 = WriteLine("C:\\Users\\Chmil\\Desktop\\demo5.txt", ConsoleColor.Magenta);
            Console.ReadLine();
        }
        public static async Task WriteLine(string path, ConsoleColor color)
        {       
           
            string result;
            using (StreamReader reader = File.OpenText(path))
            {
                while ((result = await reader.ReadLineAsync()) != null)
                {
                    lock(lockObj)
                    {
                        Console.ForegroundColor = color;
                        Console.WriteLine(result);
                        Console.ResetColor();                      
                    }     
                    await Task.Delay(100);
                }                                
            }
        }
    }
}