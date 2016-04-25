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
            node y4 = new node("y4");
            branch b1 = new branch(y1, y2, "1");
            branch b2 = new branch(y2, y3, "1");
            branch b5 = new branch(y2, y1, "1");
            gretel g = new gretel();
            string st = "";
            g.travaerse2(y1, y3, st);
            foreach (string s in g.stPaths)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("loopies");
            foreach (string s in g.loops)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

    }
}
