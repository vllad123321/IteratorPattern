namespace IteratorPattern.Interfaces
{
    internal interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
