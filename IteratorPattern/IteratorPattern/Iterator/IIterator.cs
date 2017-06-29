namespace IteratorPattern.Iterator
{
    public interface IIterator
    {
        object Current { get; }

        bool MoveNext();
    }
}