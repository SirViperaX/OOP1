namespace _7_03_L
{
    internal interface IStack
    {
        int Count { get; }
        bool Empty { get; }

        int Pop();
        void Push(int value);
    }
}