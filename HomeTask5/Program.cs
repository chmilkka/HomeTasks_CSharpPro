using System.Drawing;

namespace HomeTask5
{
    internal class Program
    {
        static object lockObj = new object();
        static async Task Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            var file1 = WriteLine("C:\\Users\\Chmil\\Desktop\\demo1.txt", 10, ConsoleColor.Red, cts.Token);
            var file2 = WriteLine("C:\\Users\\Chmil\\Desktop\\demo2.txt", 100, ConsoleColor.Green, cts.Token);
            var file3 = WriteLine("C:\\Users\\Chmil\\Desktop\\demo3.txt", 100, ConsoleColor.Blue, cts.Token);
            var file4 = WriteLine("C:\\Users\\Chmil\\Desktop\\demo4.txt", 100, ConsoleColor.Cyan, cts.Token);
            var file5 = WriteLine("C:\\Users\\Chmil\\Desktop\\demo5.txt", 100, ConsoleColor.Magenta, cts.Token);
            
            await Task.WhenAny(file1, file2, file3, file4, file5);
            cts.Cancel();
            await Task.WhenAll(file1, file2, file3, file4, file5);
            Console.WriteLine("Finish");
        }
        public static async Task WriteLine(string path, int delay, ConsoleColor color, CancellationToken token )
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
                    await Task.Delay(delay);
                    if (token.IsCancellationRequested) return;
                }                                
            }
        }
    }
}