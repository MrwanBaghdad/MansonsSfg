using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlBonus
{
    class Program
    {
        void Main(string[] args)
        {
        string inp;
        do
        {
            Console.WriteLine("enter number of nodes:");
            do
                inp = Console.ReadLine();
            while (!is_a_num(inp));

        }
        while (inp!="fin");
        
        }
        bool is_a_num(string s)
        {
            char[] arr = s.ToArray();
            foreach (char c in arr)
            {
                if (!(Convert.ToDecimal(c) >= 0 && Convert.ToDecimal(c) <= 9))
                    return false;
            }
            return false;
        }
    }
}
