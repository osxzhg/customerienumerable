using GenericIEnumerable;
using System.Collections;
using System.Collections.Generic;

namespace GenericIEnumerable
{
    public class People : IEnumerable<Person>
    {
        private Person[] _people;
        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
            // return (IEnumerator) GetEnumerator();
        }
        public IEnumerator<Person> GetEnumerator()
        {
            return new PeopleNum(_people);
        }


    }
}
