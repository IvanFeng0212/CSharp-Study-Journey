using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudyJourneyLibrary.Component.LinkedList
{
    public class MyLinkedNode<T>
    {
        public T Value { get; set; }

        public MyLinkedNode<T> Next { get; set; }

        public MyLinkedNode(T value)
        {
            Value = value;
            Next = null;
        }
    }
}