using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudyJourneyLibrary.Component.LinkedList
{
    public class MyLinkedList<T>
    {
        private MyLinkedNode<T> head;

        public void AddFirst(T value)
        {
            MyLinkedNode<T> newNode = new MyLinkedNode<T>(value);
            newNode.Next = head;
            head = newNode;
        }

        public void AddAfter(T target, T newValue)
        {
            if (head == null) return;

            MyLinkedNode<T> newNode = new MyLinkedNode<T>(newValue);
            if (head.Value.Equals(target))
            {
                head.Next = newNode;
                return;
            }

            MyLinkedNode<T> current = head;
            while (current != null && (!current.Value.Equals(target)))
            {
                current = current.Next;
            }

            if (current != null)
            {
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public void AddBefore(T target, T newValue)
        {
            if (head == null) return;

            MyLinkedNode<T> newNode = new MyLinkedNode<T>(newValue);
            if (head.Value.Equals(target))
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            MyLinkedNode<T> current = head;
            while (current != null && current.Next != null && (!current.Next.Value.Equals(target)))
            {
                current = current.Next;
            }

            if (current != null)
            {
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public void AddLast(T value)
        {
            MyLinkedNode<T> newNode = new MyLinkedNode<T>(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                MyLinkedNode<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public void Remove(T target)
        {
            if (head == null) return;

            MyLinkedNode<T> current = head;
            if (current.Value.Equals(target))
            {
                head = current.Next;
                return;
            };

            while (current != null && current.Next != null && (!current.Next.Value.Equals(target)))
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        public void RemoveFirst()
        {
            if (head == null) return;

            MyLinkedNode<T> current = head;
            if (current != null)
            {
                head = current.Next;
            };
        }

        public void RemoveLast()
        {
            if (head == null) return;

            MyLinkedNode<T> current = head;
            if (current != null && current.Next != null)
            {
                while (current.Next != null && current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
            else
            {
                head = null;
            }
        }

        public T[] GetAllValue()
        {
            MyLinkedNode<T> current = head;
            if (current == null)
            {
                return new T[0];
            };

            var result = new List<T>() { current.Value };
            while (current.Next != null)
            {
                current = current.Next;
                result.Add(current.Value);
            }

            return result.ToArray();
        }
    }
}