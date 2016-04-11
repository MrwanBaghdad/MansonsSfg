using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlBonus
{
    class Hanz
    {
        node curNode;
        List<node> stk = new List<node>();
        List<string> loops = new List<string>();
        List<string> forwardPaths= new List<string>();

        //DIFF between String and string???
        Hanz(node n)
        {
            this.curNode = n;
            
            
        }

        //find straight paths


        public void findStraightPaths(node input, node output)
        {
            curNode = input;
            while (curNode != output)
            {

                visit_NextNode();
                int index = exists_before();
                if (index > -1)
                {
                    //Found a loop;
                    string temp = "";
                    for (int i = index; i > stk.Count(); i++)
                    {
                        temp += stk[i].name;
                        temp += " ";
                    }
                    loops.Add(temp);
                    curNode = stk[index - 1];
                }
            }
        }

        void visit_NextNode()
        {
            if (curNode != null)
            {
                if (curNode.next.Count > 1)
                {
                    foreach (node n in curNode.next)
                    {
                        if (n.visited)
                            continue;
                        else
                        {
                            stk.Add(curNode);
                            curNode = n;
                            curNode.visited = true;
                        }
                    }
                }
                else if (curNode.next.Count == 1)
                {
                    curNode = curNode.next[0];
                }
            }
            if (curNode == null)
            {
                throw (new Exception());
            }
        }


        int exists_before()
        {
            int index = 0;
            foreach (node i in stk)
            {

                if (i.name.Equals(curNode.name))
                    return index;
                index++;
            }
            return -1;
        }


       
        
    }
}
