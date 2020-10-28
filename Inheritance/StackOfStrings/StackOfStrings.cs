using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }
        public void AddRange(Stack<String> stack)
        {
            foreach (var item in stack)
            {
                this.Push(item);
            }
        }
    }
}
