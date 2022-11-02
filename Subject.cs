namespace IteratorExample
{
    class Subject
    {
        public string SubjectID {get; set; }
        public string SubjectName {get; set; }
        public Subject(string id, string name)
        {
            SubjectID = id;
            SubjectName = name;
        }
    }
}