using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    namespace DataDefintions
    {
        /// <summary>
        /// Linked List
        /// </summary>
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
            public override string ToString()
            {
                string GetElements()
                {
                    StringBuilder sb = new();
                    sb.Append('[');
                    
                    ListNode current = this;
                    while (current != null)
                    {
                        sb.Append(current.val);
                        current = current.next;
                        if (current != null)
                        {
                            sb.Append(", ");
                        }
                    }
                    
                    sb.Append(']');
                    return sb.ToString();

                    //string r = string.Empty;
                    //ListNode current = this;
                    //while (current != null)
                    //{
                    //    r += current.val;
                    //    current = current.next;
                    //    if (current != null)
                    //    {
                    //        r += ", ";
                    //    }
                    //}
                    //return r;

                    //string F(ListNode node)
                    //{
                    //    if (node == null) return "";
                    //    return node.val + (node.next != null ? ", " + F(node.next) : "");
                    //}
                    //return "[" + F(this) + "]";
                }
                string elements = GetElements();
                return elements;
            }
        }
    }
}
