using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class ArrayList<T> : IEnumerable<object>, IEnumerator<object>, IDisposable
    {
        private T[] array;
        int position = -1;

        public ArrayList()
        {
            array = new T[0];
        }
        public void Add(T item)
        {

            T[] temp = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
            }
            temp[array.Length] = item;
            array = temp;

        }

        public void Clear()
        {
            array = new T[0];
        }

        public T this[int index]
        {
            get { return array[index]; }
        }

        public int Amount
        {
            get { return array.Length; }
        }

        public object Current
        {
            get
            {
                return $"{array[position]}";
            }
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < array.Length; i++)
            {
                str += array[i] + " ";
            }
            return str;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public void Dispose()
        {
            Reset();
        }

        public bool MoveNext()
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator<object> IEnumerable<object>.GetEnumerator()
        {
            return this;
        }
    }
}
