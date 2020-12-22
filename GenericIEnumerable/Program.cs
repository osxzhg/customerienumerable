using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenericIEnumerable
{
    interface IInterface
    {
        void method1(int num1);
    }
    interface IInterface2
    {
        void method2();
    }
    class MyClass : IInterface, IInterface2
    {
        public int MyProperty { get; set; }
        public void method1(int num1)
        {
            Console.WriteLine(MyProperty);
        }

        public void method2()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            IInterface obj1 = new MyClass() { MyProperty=13};
            obj1.method1(2);

           
           

            Person[] peopleArray = new Person[3]
            {
            new Person("John", "Smith"),
            new Person("Jim", "Johnson"),
            new Person("Sue", "Rabon"),
            };
            // Covariance.
            IEnumerable<string> strings = new List<string>();
            
            
            // An object that is instantiated with a more derived type argument
            // is assigned to an object instantiated with a less derived type argument.
            // Assignment compatibility is preserved.
            IEnumerable<object> objects = strings;


 


            string outStr = "";

            People peopleList = new People(peopleArray);
            foreach (var p in peopleList)
                outStr = p.firstName + " " + p.lastName;

            IEnumerable<Person> people = new People(peopleArray);
            foreach (var p in people)
                outStr = p.firstName + " " + p.lastName;


            IEnumerator<Person> peopleIEnumerator = people.GetEnumerator();
            while (peopleIEnumerator.MoveNext())
            {
                outStr = peopleIEnumerator.Current.firstName + "" + peopleIEnumerator.Current.lastName;
            }

            IEnumerable peopleIEnumerable = new People(peopleArray);
            foreach (Person item in peopleIEnumerable)
            {
                outStr=item.firstName;

            }


        }
    }
}
