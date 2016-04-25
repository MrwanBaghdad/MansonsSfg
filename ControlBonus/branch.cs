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
        String relation;
        static List<branch> allBranches = new List<branch>();
        public branch(node start, node end, string relation)
        {
            start.next.Add(end);
            this.relation = relation;
            this.start = start;
            this.end = end;
            branch.allBranches.Add(this);
        }

        public static string getRelation(string start, string end)
        {
            Predicate<branch> findBranch = (branch b) => { return b.start.name.Equals(start) && b.end.name.Equals(end); };
            return branch.allBranches.Find(findBranch).relation;
        }
        //Traverse algo
        //UPDATE added to gretel class
        
        
    }

}
