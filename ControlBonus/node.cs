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
        public string relation;
        const List<node> allNodes= new List<node>();
        public node(string name)
        {
            this.name = name;
        }
    }

  
}
