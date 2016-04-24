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
        public List<string> loops = new List<string>();
        public List<string> stPaths= new List<string>();
        public node NextNode(node n, string st){
            if (n.next.Count() > 0)
            {
                //Therefore exists next nodes
                foreach (node i in n.next)
                {
                    if (i.visited==false)
                    {
                        /*no need for stak
                         * recursive stack is fine 
                         */
                        st += i.name;
                        i.visited = true;
                        return i;
                    }
                    else
                    {
                        // >> Node.visited == false
                        
                        if(st.Length>0) //check for the stack not empty
                        if (st.Contains(i.name) )
                        {
                            //>>found a loop

                            int indexOfString=st.IndexOf(i.name);
                            string loopName = st.Substring(indexOfString);
                            loops.Add(loopName);
                        }
                    }
                    return null;
                }
            }
            return null;
        }
        //String outside of the function to be allowed to changed via 
        //no need string stack argument recursive instead
        public void travaerse(node currentNode,node outNode,string st)
        {
            if (!currentNode.Equals(outNode))
            {

                if (currentNode.next.Count > 0)
                {
                    for (int i = 0; i <currentNode.next.Count(); i++)
                    {
                        st+= currentNode.name;
                        st += " ";
                        //To get loops 
                        /*
                         funciton already return a node
                         */
                        // xx currentNode = NextNode(currentNode);
                        node temp = NextNode(currentNode, st);
                        if(temp!= null)
                            travaerse(temp, outNode,st);
                        //>>Here arrived at end
                        //Change visited to false, so it can be visited by other branches
                        currentNode.visited = false;
                    }
                    //>>Here Finished all branches 
                }
                else
                {
                    //>> current node can't reach output
                    currentNode.visited = false;
                }
            }
            else
            {
            //recursive reached outnode here
                st += currentNode.name;
                stPaths.Add(st);
                currentNode.visited = false;
                Console.WriteLine("Arrived to out node");
            }
        }
    }
}
