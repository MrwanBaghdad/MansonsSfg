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

        string[] loops ;
        public branch(node start, node end, string relation)
        {
            this.start = start;
            this.end = end;
            start.next.Add(end);
            start.relation = relation;
        }

        //Traverse algo
        //UPDATE added to gretel class
        
        
    }
}
