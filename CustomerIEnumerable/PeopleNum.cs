using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomerIEnumerable
{
    public class PeopleNum : IEnumerator<Person>
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
        private bool disposedValue = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    // Dispose of managed resources.
                }
            }

            this.disposedValue = true;
        }

        ~PeopleNum()
        {
            Dispose(false);
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
