using System;
using System.Collections.Generic;

// dotnet publish -c Release -r win-x64 --self-contained true
// Tetris/bin/Release/netX.X/win-x64/publish/

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> row1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < row1.Count; i++)
            {
                Console.WriteLine("[]");
            }
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            // Console.Clear();
        }
    }
}
