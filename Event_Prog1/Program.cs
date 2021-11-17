using System;

public delegate void MyDelegate();

namespace Event_Prog1
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public event MyDelegate MyEvent;

        public void UpdateLastName(string lastName)
        {
            LastName = lastName;

            if (MyEvent != null)
                MyEvent();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { FirstName = "Meenaakshi", LastName = "Ambati" };

            person.MyEvent += Person_MyEvent;

            person.UpdateLastName("Shaik");
        }

        private static void Person_MyEvent()
        {
            Console.WriteLine("Person LastName Updated");
        }
    }
}
