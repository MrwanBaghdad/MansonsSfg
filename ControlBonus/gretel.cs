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
        List<string> loops = new List<string>();
        List<string> stPaths= new List<string>();
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
                                //Search for the current node in the stack
                                for (int pl = count; pl < stk.Count(); pl++)
                                {
                                    s += stk[pl].name;
                                    s += " ";
                                }
                                loops.Add(s);
                            }
                            count++;
                        }
                    }
                    return null;
                }
            }
            return null;
        }
        //String outside of the function to be allowed to changed via 
        string s;
        public void travaerse(node currentNode,node outNode,string st)
        {
            if (!currentNode.Equals(outNode))
            {
                node temp=NextNode(currentNode);
                if (currentNode.next.Count > 0 && temp!=null)
                {
                    for (int i = 0; i < currentNode.next.Count(); i++)
                    {
                        st+= currentNode.name;
                        st += " ";
                        //To get loops 
                        stk.Add(currentNode);
                        /*
                         funciton already return a node
                         */
                        currentNode = NextNode(currentNode);
                        travaerse(NextNode(currentNode), outNode,st);
                        //>>Here arrived at end
                        stk.Remove(stk.Last());
                        //Change visited to false, so it can be visited by other branches
                        currentNode.visited = false;
                    }
                    //>>Here Finished all branches 
                }
            }
            else
            {
            //recursive reached outnode here
            Console.WriteLine("Arrived to out node");
            }
        }
    }
}
