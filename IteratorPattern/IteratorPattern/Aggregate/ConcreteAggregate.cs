using IteratorPattern.Iterator;
using System.Collections;

namespace IteratorPattern.Aggregate
{
    public class ConcreteAggregate : IAggregate
    {
        private ArrayList items = new ArrayList();

        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public object this[int index]
        {
            get
            {
                return items[index];
            }

            set
            {
                items.Insert(index, value);
            }
        }

        public int Count
        {
            get { return items.Count; }
        }
    }
}