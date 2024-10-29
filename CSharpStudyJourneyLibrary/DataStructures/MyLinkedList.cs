using CSharpStudyJourneyLibrary.Component.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudyJourneyLibrary.DataStructures
{
    public class MyLinkedList
    {
        public void Run()
        {
            MyLinkedList<int> linkedList = new MyLinkedList<int>();
            linkedList.AddFirst(0);
            linkedList.AddLast(1);
            linkedList.AddAfter(1, 2);
            linkedList.AddLast(4);
            linkedList.AddBefore(4, 3);
            linkedList.Remove(2);
            linkedList.Remove(1);

            var listResult = linkedList.GetAllValue();
            Console.WriteLine(string.Join(",", listResult));
        }
    }
}