using System;
using System.Collections.Generic;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            LinkedList<int> nums = new LinkedList<int>();
            nums.AddLast(2);
            nums.AddLast(3);
            nums.AddLast(4);
            nums.AddLast(5);
            nums.AddFirst(1);
            nums.AddFirst(0);
            LinkedListNode<int> node = nums.Find(4);
            nums.AddBefore(node, 5);
            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }

        }
    }
}