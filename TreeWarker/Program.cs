using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeWarker
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> t = new Tree<int>(1);   //二叉树初始节点  
            t.Insert(2);
            t.Insert(-1);
            t.Insert(3);
            t.Insert(-3);
            t.Insert(-2);
            t.WalkTree();//二叉树的遍历  
            Console.Read();
        }
    }


}
