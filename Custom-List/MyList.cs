using System;
using System.Collections;

namespace Custom_List
{
    class MyList<T> : IEnumerable
    {
        public int Count { get; set; }
        public int Capacity { get; set; }
        private T[] _arr;
        private int index = 0;


        public MyList(int capacity)
        {
            Capacity = capacity;
            _arr = new T[capacity];
        }

        public void Add(T value)
        {
            if (Count < Capacity)
            {
                Array.Resize(ref _arr, Capacity);
                _arr[index] = value;
                index++;
            }
            else if (Count > Capacity || Count == Capacity)
            {
                Capacity = Capacity * 2;
                Array.Resize(ref _arr, Capacity);
                _arr[index] = value;
                index++;
            }
            Count++;
        }


        public void AddRange(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Array.Resize(ref _arr, _arr.Length + 1);
                _arr[_arr.Length - 1] = array[i];
            }
        }


        public void Remove(object value)
        {
            int valindex = Array.IndexOf(_arr, value);
            int index = 0;
            while (index != valindex)
            {
                index++;
            }
            while (index < _arr.Length - 1)
            {
                _arr[index] = _arr[index + 1];
                index++;
            }
            valindex--;
        }


        public void RemoveAt(int removedindex)
        {
            int index = 0;
            while (index != removedindex)
            {
                index++;
            }
            while (index < _arr.Length - 1)
            {
                _arr[index] = _arr[index + 1];
                index++;
            }
            removedindex--;
        }

        public void Clear()
        {
            _arr = new T[Capacity];
            Count = 0;
        }

        public void Insert(int valueindex, T item)
        {
            for (int i = Count; i > valueindex; i--)
            {
                _arr[i] = _arr[i - 1];
            }
            _arr[valueindex] = item;
            Count++;
        }


        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _arr[i];
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}
