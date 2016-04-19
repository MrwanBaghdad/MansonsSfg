using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlBonus
{
    class Program
    {
        static void Main(string[] args)
        {
        string inp;
        int count;
        do
        {
            Console.WriteLine("enter number of nodes:");
            do
                inp = Console.ReadLine();
            while (!is_a_num(inp));
            do
            Console.WriteLine("enter number of branches");
            while(!is_a_num(inp));

            count = Convert.ToInt32(inp);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("nodes connecting branches and relations");
                //spereated by commas
                
            }

        }
        while (inp!="fin");
        
        }
        static bool  is_a_num(string s)
        {
            decimal temp;
            try
            {
                temp = Convert.ToDecimal(s);
                if (temp - (int)temp == 0)
                    return true;
                else
                    return false;
                
            }
            catch (Exception e)
            {
                return false;
            }
            
        }

    }
}
