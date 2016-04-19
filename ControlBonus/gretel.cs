using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlBonus
{
    class gretel
    {
        //stack to check for loops
        List<node> stk = new List<node>();
        List<node> loops = new List<node>();
        public node NextNode(node n){
            if (n.next.Count() > 0)
            {
                //Therefore exists next nodes
                foreach (node i in n.next)
                {
                    if (i.visited==false)
                    {
                        stk.Add(n);
                        i.visited = true;
                        return i;
                    }
                    else
                    {
                        int count =0;
                        foreach (node sNode in stk)
                        {
                           
                            if (sNode.Equals(i))
                            {
                                //Found a loop
                                string s = "";
                                for (int pl = count; pl < stk.Count(); pl++)
                                {
                                    s += stk[pl].name;
                                }
                                
                            }
                            count++;
                        }
                    }
                    return null;
                }
            }
            return null;
        }
        public void travaerse(node currentNode,node outNode)
        {
            if (!currentNode.Equals(outNode))
            {
                if (currentNode.next.Count > 0)
                {
                    for (int i = 0; i < currentNode.next.Count(); i++)
                    {
                        currentNode = NextNode(currentNode);
                        travaerse(currentNode, outNode);
                    } 
                }
            }
            
        }
    }
}
