namespace IteratorExample
{
    class ConcreteCollection : Collection
    {
        private List<Subject> SubjectList = new List<Subject>();

        public ConcreteIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return SubjectList.Count; }
        }

        public void AddSubject(Subject subject)
        {
            SubjectList.Add(subject);
        }

        public Subject GetSubject(int index)
        {
            return SubjectList[index];
        }
    }
}