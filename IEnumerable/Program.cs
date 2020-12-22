using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenericIEnumerable
{
    class Program
    {
        private string name;
        public string LastName
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value), $"Name cannot be null");
            //set => name = value ?? throw new ArgumentNullException(nameof(value), $"{nameof(Name)} cannot be null");
        }
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
            foreach (Person p in peopleList)
                outStr=p.firstName + " " + p.lastName;


            IEnumerable peopleIEnumealeNormal = new People(peopleArray);
            foreach(Person p in peopleIEnumealeNormal)
                outStr= p.firstName + " " + p.lastName;


            IEnumerator peopleIEnumeratorNormal = peopleIEnumealeNormal.GetEnumerator();
            while(peopleIEnumeratorNormal.MoveNext())
            {
                outStr=((Person) peopleIEnumeratorNormal.Current).firstName + " " +((Person) peopleIEnumeratorNormal.Current).lastName ; 
            }

            

        }
    }
    
    
}
