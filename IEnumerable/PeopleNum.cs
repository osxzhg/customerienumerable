using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericIEnumerable
{
    public class PeopleNum : IEnumerator
    {
        private int position = -1;
        private Person[] _people;
        public PeopleNum(Person[] persons)
        {
            _people =persons;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Person Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
