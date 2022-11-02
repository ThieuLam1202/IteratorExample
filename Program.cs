using System;

namespace IteratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCollection collection = new ConcreteCollection();

            collection.AddSubject(new Subject("SE005", "Introduction to Software Engineering"));
            collection.AddSubject(new Subject("IT002", "Object-oriented programming"));
            collection.AddSubject(new Subject("IT008", "Visual programming"));
            collection.AddSubject(new Subject("SE104", "Software engineering"));
            collection.AddSubject(new Subject("SE100", "Object-oriented software development methodology"));
            collection.AddSubject(new Subject("SE400", "Seminar on software programming"));
            collection.AddSubject(new Subject("SE401", "Software design pattern"));
            collection.AddSubject(new Subject("SE405", "Mobile pervasive computing"));

            ConcreteIterator iterator = collection.CreateIterator();

            Console.WriteLine("List of software engineering subjects:");
            for (Subject subject = iterator.First(); !iterator.isDone; subject = iterator.Next())
            {
                Console.WriteLine($"ID: {subject.SubjectID}, Name: {subject.SubjectName}");
                Thread.Sleep(1000);
            }

            Console.Read();
        }
    }
}