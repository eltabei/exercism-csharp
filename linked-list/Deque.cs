using System;

class Deque<T>
{
    private Element<T> first;
    private Element<T> last; 

    public void Push(T item)
    {
        Element<T> e = new Element<T>(item);
        if (first == null)
        {
            first = e;
        }
        if (last != null)
        {
            last.Next = e;
            e.Prev = last;
        }
        last = e;
    }

    public void Unshift(T item)
    {
        Element<T> e = new Element<T>(item);
        if (first != null)
        {
            first.Prev = e;
            e.Next = first;
        }
        first = e;
        if (last == null)
        {
            last = e;
        }
    }

    public T Pop()
    {
        if (last == null)
        {
            throw new Exception("Empty deque");
        }
        T v = last.Value;
        if (last.Prev != null)
        {
            last = last.Prev;
            last.Next = null;
        }
        return v;
    }

    public T Shift()
    {
        if (first == null)
        {
            throw new Exception("Empty deque");
        }
        T v = first.Value;
        if (first.Next != null)
        {
            first = first.Next;
            first.Prev = null;
        }
        return v;
    }
}

class Element<T>
{
    public T Value;
    public Element<T> Next;
    public Element<T> Prev;

    public Element(T value)
    {
        Value = value;
    }
}