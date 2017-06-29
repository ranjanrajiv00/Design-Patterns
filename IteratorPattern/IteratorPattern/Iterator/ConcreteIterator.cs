using IteratorPattern.Aggregate;

namespace IteratorPattern.Iterator
{
    public class ConcreteIterator : IIterator
    {
        private ConcreteAggregate _aggregate;
        private int index;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
            index = -1;
        }

        public object Current
        {
            get
            {
                return this._aggregate[index];
            }
        }

        public bool MoveNext()
        {
            index++;
            return index < _aggregate.Count;
        }
    }
}