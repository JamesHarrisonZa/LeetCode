using System.Numerics;

namespace LeetCode
{
     public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int val=0, ListNode next=null) {
             this.val = val;
             this.next = next;
         }
     }
     

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var num1 = GetNumber(l1);
            var num2 = GetNumber(l2);

            var sum = num1 + num2;

            var sumNode = CreateNode(sum);

            return sumNode;
        }
        
        private BigInteger GetNumber(ListNode l1)
        {
            var nums = new List<int>();

            var currentNode = l1;
            while (currentNode.next != null)
            {
                nums.Add(currentNode.val);
                currentNode = currentNode.next;
            }
            nums.Add(currentNode.val);

            nums.Reverse();

            var numStr = String.Join("", nums);
            return BigInteger.Parse(numStr);
        }

        private int GetIntFromChar(char c)
        {
            return (int)Char.GetNumericValue(c);
        }

        private ListNode CreateNode(BigInteger sum)
        {
            var arr = sum
                .ToString()
                .Select(c => GetIntFromChar(c))
                .ToList();

            arr.Reverse();

            var firstNode = new ListNode(arr[0]);
            var currentNode = firstNode;

            for (int i = 1; i < arr.Count; i++)
            {
                var num = arr[i];
                var node = new ListNode(num);
                currentNode.next = node;
                currentNode = node;
            }
            return firstNode;
        }

    }
}