using System;

namespace CSharpObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);
            int area = map.Width * map.Height;
        }
    }
}