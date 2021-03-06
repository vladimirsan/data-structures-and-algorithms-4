﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_With_Stacks
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// Takes any string value as an argument and adds a new node with that value to the Top of the stack.
        /// </summary>
        /// <param name="value">A unique string value that will be set as the new Top node value</param>
        public void Push(string value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Takes no argument and returns a boolean indicating whether or not the stack is empty. 
        /// </summary>
        /// <returns>A boolean indicating if the stack is empty</returns>
        public bool IsEmpty()
        {
            return Top == null;
        }

        /// <summary>
        /// This method removes the node from the top of the stack,
        /// and returns the node's value
        /// </summary>
        /// <returns>The unique value of the node that is being removed</returns>
        public string Pop()
        {

            if (IsEmpty())
            {
                throw new Exception("Stack is empty");
            }

            Node temp = Top;

            Top = Top.Next;

            temp.Next = null;

            return temp.Value;
        }

        /// <summary>
        /// This method returns the value of the node located on top of the stack,
        /// without removing it from the stack
        /// </summary>
        /// <returns>The unique value of the removed node</returns>
        public string Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty");
            }

            return Top.Value;
        }
    }
}
