using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._9
{
    class MyBinaryTree
    {
        public NodeForMyBT Root { get; set; }

        public void Add(int value)
        {
            NodeForMyBT before = null, after = Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data)
                    after = after.LeftNode;
                else if (value > after.Data)
                    after = after.RightNode;
            }
            NodeForMyBT newNodeForMyBT = new NodeForMyBT();
            newNodeForMyBT.Data = value;

            if (Root == null)
                Root = newNodeForMyBT;
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNodeForMyBT;
                else
                    before.RightNode = newNodeForMyBT;
            }
        }
        //https://csharpexamples.com/c-binary-search-tree-implementation/
    }
}
