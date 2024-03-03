PriorityQueue Implementation
This repository contains a simple implementation of a priority queue in C# using a generic class. The priority queue is designed to hold elements of any type that implements the IComparable<T> interface.

Usage:

Creating a Priority Queue
To create an instance of the priority queue, use the following code:

public class PriorityQueue<T> where T : IComparable<T>
{
    private List<T> _list;

    public PriorityQueue()
    {
        _list = new List<T>();
    }
}

---------------------------------------------------------------------------------------------------------

Enqueuing an Item
To add an item to the priority queue, use the Enqueue method:

public void Enqueue(T item)
{
    _list.Add(item);
    _list.Sort();
}

---------------------------------------------------------------------------------------------------------

Dequeuing an Item
To remove and retrieve the highest-priority item from the queue, use the Dequeue method:

public T Dequeue()
{
    if (IsEmpty())
    {
        throw new InvalidOperationException("Queue is empty");
    }

    T item = _list[0];
    _list.RemoveAt(0);
    return item;
}

---------------------------------------------------------------------------------------------------------

Checking if the Queue Is Empty
You can verify whether the queue is empty using the IsEmpty method:

public bool IsEmpty()
{
    return _list.Count == 0;
}

---------------------------------------------------------------------------------------------------------

Getting the Minimum and Maximum Items
To get the minimum and maximum items in the queue, use the Min and Max methods:

public T Min()
{
    if (IsEmpty())
    {
        throw new InvalidOperationException("Queue is empty");
    }

    return _list[0];
}

public T Max()
{
    if (IsEmpty())
    {
        throw new InvalidOperationException("Queue is empty");
    }

    return _list[_list.Count - 1];
}

---------------------------------------------------------------------------------------------------------

Peeking at the Front Item
To peek at the front (highest-priority) item without removing it, use the Peek method:

public T Peek()
{
    if (IsEmpty())
    {
        throw new InvalidOperationException("Queue is empty");
    }

    return _list[0];
}

---------------------------------------------------------------------------------------------------------

This code is provided under the MIT License. Feel free to use and modify it for your own projects.
