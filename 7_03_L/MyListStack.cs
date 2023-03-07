using _7_03_L;

class Node
{
    public int value;
    public Node? next;
}

internal class MyListStack : IStack
{
    int size;
    Node? first = null;
    public MyListStack()
    {
        size = 0;
        this.first = null;
    }
    public int Count => size;

    public bool Empty => size == 0;

    public int Pop()
    {
        
        if(size > 0 && first != null)
        {
            int ret = first.value;
            first = first.next;
            size--;
            return ret;
        }
        else 
            throw new StackEmptyException("Stack empty.");
    }

    public void Push(int value)
    {
        Console.Write($"Try to push {value}...");
        Node node = new Node();
        node.value = value;
        node.next = first;
        first = node;
        size++;
        Console.WriteLine(" Succes.");
    }
}