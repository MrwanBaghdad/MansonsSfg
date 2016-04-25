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
        public List<string> stPathsEqu = new List<string>();
        public List<string> loopsEqu = new List<string>();

        //String outside of the function to be allowed to changed via 
        //no need string stack argument recursive instead


        public void travaerse2(node currentNode, node outNode, string st)
        {
            st += " ";
            st += currentNode.name;
            if (!currentNode.Equals(outNode))
            {
                if (currentNode.next.Count > 0)
                {
                    foreach (node noodel in currentNode.next)
                    {
                        //To get loops 
                        /*
                         funciton already return a node
                         */
                        // xx currentNode = NextNode(currentNode);
                        //node temp = NextNode(currentNode, st);
                        node temp = null;
                        if (noodel.visited==false)
                        {
                            noodel.visited = true;
                            temp = noodel;
                        }
                        else
                        {
                            if (st.Contains(noodel.name))
                            {
                                //found a loop
                                int indexOfString = st.IndexOf(noodel.name);
                                string loopName = st.Substring(indexOfString);
                                loops.Add(loopName);
                            }
                        }
                        if (temp != null)
                            travaerse2(temp, outNode, st);
                        //>>Here arrived at end
                        //Change visited to false, so it can be visited by other branches
                    }
                    currentNode.visited = false;
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
                stPaths.Add(st);
                currentNode.visited = false;
                //Console.WriteLine("Arrived to out node");
            }
        }

        public void getEqu()
        {
            // get loops equations
            for (int i = 0; i < loops.Count; i++)
            {
                string s1 = loops[i];
                string[] arr= s1.Split();
                string rel="";
                for (int j = 0; j < arr.Length-1; j++)
                {
                    string rel2 = branch.getRelation(arr[j], arr[j+1]);
                    rel += rel2+" ";
                }
                loopsEqu.Add(rel);
            }
            //Get the st paths equations
            for (int i = 0; i < stPaths.Count; i++)
            {
                string s1 = stPaths[i];
                string[] arr = s1.Split();
                string rel = "";
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    string rel2 = branch.getRelation(arr[j], arr[j+1]);
                    rel += rel2 + " ";
                }
                stPathsEqu.Add(rel);
            }
        }

        public void getNonTouch()
        {
            foreach (string l in loops)
            {

            }
        }

    }

}
