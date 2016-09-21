using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());
            for (int row = m; row >= n; row--)
            {
                if(row%2==0 && row%3==0)
                {
                    
                    if (row == s)
                        break;
                    Console.Write("{0} ", row);
                }
            }
        }
    }
}
