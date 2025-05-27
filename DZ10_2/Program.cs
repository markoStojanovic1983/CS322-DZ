using System;
using System.Collections;

public class CustomStack
{
    private ArrayList items;

    public CustomStack()
    {
        items = new ArrayList();
    }

    public void Push(object item)
    {
        items.Add(item);
    }

    public object Pop()
    {
        if (items.Count == 0)
            throw new InvalidOperationException("Stack is empty");

        object item = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return item;
    }

    public object Peek()
    {
        if (items.Count == 0)
            throw new InvalidOperationException("Stack is empty");

        return items[items.Count - 1];
    }

    public int Count
    {
        get { return items.Count; }
    }

    public void Clear()
    {
        items.Clear();
    }
}

public class CustomQueue
{
    private ArrayList items;

    public CustomQueue()
    {
        items = new ArrayList();
    }

    public void Enqueue(object item)
    {
        items.Add(item);
    }

    public object Dequeue()
    {
        if (items.Count == 0)
            throw new InvalidOperationException("Queue is empty");

        object item = items[0];
        items.RemoveAt(0);
        return item;
    }

    public object Peek()
    {
        if (items.Count == 0)
            throw new InvalidOperationException("Queue is empty");

        return items[0];
    }

    public int Count
    {
        get { return items.Count; }
    }

    public void Clear()
    {
        items.Clear();
    }
}

// Example usage:
public class Program
{
    public static void Main()
    {
        // Testing CustomStack
        CustomStack stack = new CustomStack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine($"Stack count: {stack.Count}");
        Console.WriteLine($"Popped: {stack.Pop()}");
        Console.WriteLine($"Peek: {stack.Peek()}");

        // Testing CustomQueue
        CustomQueue queue = new CustomQueue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine($"Queue count: {queue.Count}");
        Console.WriteLine($"Dequeued: {queue.Dequeue()}");
        Console.WriteLine($"Peek: {queue.Peek()}");
    }
}