using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeWarker
{
    public class Tree<TItem> where TItem:IComparable<TItem>
    {
        private TItem NodeData;
        private Tree<TItem> LeftTree;  //左孩子  
        private Tree<TItem> RightTree;  //右孩子  
        public Tree(TItem nodeValue)
        {
            this.NodeData = nodeValue;//泛型数据  
            this.LeftTree = null;   //左孩子  
            this.RightTree = null;   //右孩子  
        }

        public void Insert(TItem newItem)    //树的插入操作实现二叉排序树  
        {
            TItem currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new Tree<TItem>(newItem);

                }
                else
                {
                    this.LeftTree.Insert(newItem);
                }

            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new Tree<TItem>(newItem);
                }
                else
                {
                    this.RightTree.Insert(newItem);
                }
            }

        }

        //以下执行左中右的遍历方式  

        public void WalkTree()   //树的遍历  
        {
            if (this.LeftTree != null)
            {
                this.LeftTree.WalkTree();
            }

            Console.WriteLine(this.NodeData.ToString());

            if (this.RightTree != null)
            {
                this.RightTree.WalkTree();
            }
        }
    }
}
