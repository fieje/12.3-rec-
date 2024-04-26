using System;

public class ListNode
{
    public int Value { get; set; }
    public ListNode Next { get; set; }

    public ListNode(int val)
    {
        Value = val;
        Next = null;
    }
}

public class LinkedList
{
    public ListNode Head { get; set; }

    public LinkedList()
    {
        Head = null;
    }

    public void Add(int val)
    {
        ListNode newNode = new ListNode(val);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            ListNode current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public int SumOfPositiveValues_Recursive()
    {
        return SumOfPositiveValuesRecursive(Head);
    }

    private int SumOfPositiveValuesRecursive(ListNode node)
    {
        if (node == null)
        {
            return 0;
        }

        int sum = SumOfPositiveValuesRecursive(node.Next);
        if (node.Value > 0)
        {
            sum += node.Value;
        }
        return sum;
    }


    public void Print()
    {
        PrintRecursive(Head);
        Console.WriteLine();
    }

    private void PrintRecursive(ListNode node)
    {
        if (node != null)
        {
            Console.Write(node.Value + " ");
            PrintRecursive(node.Next);
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.Add(2);
        list.Add(-5);
        list.Add(10);
        list.Add(7);
        list.Add(-3);

        Console.WriteLine("List:");
        list.Print();

        int sumOfPositives = list.SumOfPositiveValues_Recursive(); 
        Console.WriteLine("Sum of positive values: " + sumOfPositives);

        Console.ReadLine();

    }
}
