using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TestingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LevelCreator l = new LevelCreator();

            Console.WriteLine(l.map[1, 1].position); 
            Console.ReadKey();
        }
    }
}
