using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlBonus
{
    class branch
    {
        node start;
        node end;
        string relation;
        node curNode;
        List<node> stk = new List<node>();
        string[] loops ;
        branch(node start, node end, string relation)
        {
            this.start = start;
            this.end = end;
            start.next.Add(end);
            this.relation = relation;
        }

        //Traverse algo
        
        
        
    }
}
