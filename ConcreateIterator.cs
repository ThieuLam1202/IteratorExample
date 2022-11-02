namespace IteratorExample
{
    class ConcreteIterator : Iterator
    {
        private ConcreteCollection collection;
        private int current = 0;
        private int step = 1;

        public ConcreteIterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }

        public Subject First()
        {
            current = 0;
            return collection.GetSubject(current);
        }

        public Subject Next()
        {
            current += step;
            if (!isDone)
            {
                return collection.GetSubject(current);
            }
            else
            {
                return null!;
            }
        }

        public bool isDone
        {
            get {return current >= collection.Count; }
        }
    }
}