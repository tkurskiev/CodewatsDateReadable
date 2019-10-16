using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWarsDateReadable;

namespace CodewatsDateReadable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(HumanTimeFormat.FormatDuration(21312));

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter duration:");
                    var seconds = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                    Console.WriteLine($"The full date string:{Environment.NewLine}{HumanTimeFormat.FormatDuration(seconds)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            //Console.ReadKey();
        }
    }
}
