using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGTTG
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(),"..\\..\\input.txt");
            var lines = File.ReadLines(path);
            var parser = new Parser();
            foreach (var line in lines)
            {
                var output = parser.AddInput(line);
                if (string.IsNullOrEmpty(output))
                    continue;
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
