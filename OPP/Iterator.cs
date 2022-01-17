using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public interface Iterator
    {
        object GetCurrentItem();
        void Next();
        bool isDone();
    }

    public interface Collection
    {
        Iterator CreateIterator();
    }

    public class ConcreteCollectionA : Collection
    {
        public int a1 = 111;
        public int a2 = 22;
        public int a3 = 3;
        public Iterator CreateIterator()
        {
            return new CollectionA_Iterator(this);
        }
    }

    public class CollectionA_Iterator : Iterator
    {
        int currentElement = 1;
        public CollectionA_Iterator(ConcreteCollectionA collection)
        {
            this.collection = collection;
        }

        public object GetCurrentItem()
        {
            if (currentElement == 1)
                return collection.a1;
            if (currentElement == 2)
                return collection.a2;
            if (currentElement == 3)
                return collection.a3;
            else
                throw new Exception("No current element");
        }

        public bool isDone()
        {
            return currentElement > 3;
        }

        public void Next()
        {
            currentElement++;
        }

        private ConcreteCollectionA collection;
    }
 
}
