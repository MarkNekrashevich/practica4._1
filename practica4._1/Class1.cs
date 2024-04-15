using System;
using System.Text;

namespace practica4._1
{
    public class ListNode
    {
        public double Value { get; set; }
        public ListNode? Next { get; set; } // Добавляем вопросительный знак, чтобы допустить значение null

        public ListNode(double value)
        {
            Value = value;
            Next = null;
        }
    }

    public class LinkedList
    {
        public ListNode? Head { get; private set; } // Добавляем вопросительный знак, чтобы допустить значение null

        public LinkedList()
        {
            Head = null;
        }

        public void Add(double value)
        {
            ListNode newNode = new ListNode(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                ListNode? current = Head; // Добавляем вопросительный знак
                while (current?.Next != null) // Изменяем проверку на null
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void RemoveBeforeFirstPositive()
        {
            if (Head == null || Head.Next == null)
            {
                return; // Нечего удалять
            }

            ListNode? current = Head;
            ListNode? previous = null;

            // Поиск первого положительного числа
            while (current != null && current.Value <= 0)
            {
                previous = current;
                current = current.Next;
            }

            // Если найдено положительное число
            if (current != null && previous != null)
            {
                // Удаляем все элементы до первого положительного числа
                Head = current;
            }
            else if (current != null && previous == null && current.Value <= 0)
            {
                // Если первый элемент положительный, а следующий - отрицательный
                Head = current;
            }
        }















        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            ListNode? current = Head; // Добавляем вопросительный знак
            while (current != null)
            {
                sb.Append(current.Value).Append(" -> ");
                current = current.Next;
            }
            sb.Append("null");
            return sb.ToString();
        }
    }
}
