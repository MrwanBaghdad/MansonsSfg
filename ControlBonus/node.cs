using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlBonus
{
    public class node
    {
        public List<node> next= new List<node>();
        public bool visited=false;
        public string name;
        public static List<node> allNodes= new List<node>();
        public string relation;
        //UPDATE Removed static nodes list 

        public node(string name)
        {
            this.name = name;
            allNodes.Add(this);
        }
    }

  
}
