using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consoles
{
    public class Program
    {
        string basepath = @"D:\Games\Minecraft\#最新mod";
        public static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string curt = AppContext.BaseDirectory;

            Console.WriteLine("Album Cover Replace 0.1");
            Console.WriteLine("本程序帮您处理目标文件夹音乐专辑图片替换问题，比如Cover.jpg和Album.jpg互换");
            Console.WriteLine("Current Folder is:" + curt + "Type 'n' to change another folder");

            if (Console.ReadLine().Trim().ToLower().Equals("n"))
            {
                while (true)
                {
                    Console.WriteLine("Input a Album Path,'exit' to exit");
                    string tmpPath = Console.ReadLine();
                    if (tmpPath.Trim().ToLower().Equals("exit"))
                    {
                        return;
                    }
                    else if (!Directory.Exists(tmpPath))
                    {
                        Console.WriteLine("Path is not exists!");
                        continue;
                    }
                    else
                    {
                        curt = tmpPath;
                        break;
                    }
                }
            }
        }
    }
}
