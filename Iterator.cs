namespace IteratorExample
{
    interface Iterator
    {
        Subject First();
        Subject Next();
        bool isDone{get; }
    }
}