using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTC_Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input;
            string read;
            read = Console.ReadLine();
            var input = read.Split(' ');

            Clock neu = new Clock(input);
            
            //for(int i = 0 ; i<input.Length;i++)
            //{ Console.WriteLine("{0}", input[i]); }
            //Console.ReadLine();
        }
    }
}
