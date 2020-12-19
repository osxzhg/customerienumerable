using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomerIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[3]
            {
            new Person("John", "Smith"),
            new Person("Jim", "Johnson"),
            new Person("Sue", "Rabon"),
            };
            



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


        }
    }
}
