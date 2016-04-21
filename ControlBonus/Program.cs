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
            node y1 = new node("y1");
            node y2 = new node("y2");
            node y3 = new node("y3");
            branch b1 = new branch(y1, y2, "1");
            branch b2 = new branch(y1, y3, "1");
            branch b3 = new branch(y1, y2, "1");
            gretel g = new gretel();
            g.travaerse(y1, y3);
            
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
