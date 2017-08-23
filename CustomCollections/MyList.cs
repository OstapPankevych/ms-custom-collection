using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    public class MyList<T> : ICollection<T>
    {
        protected int defaultElements = 10;

        private const int StartCount = 0;

        private int _count = StartCount; 
        private T[] _elements;

        public MyList()
        {
            Init();
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            if (_elements.Length <= _count)
            {
                _elements = _elements.Concat(new T[defaultElements]).ToArray();
            }

            _elements[_count++] = item;
        }

        public void Clear()
        {
            Init();
        }

        public bool Contains(T item)
        {
            foreach (var x in _elements)
            {
                if (!item.Equals(x)) continue;
                return true;                
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _elements.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < _count; i++)
            {
                yield return _elements[i];        
            }
        }

        public bool Remove(T item)
        {
            var indexOf = Array.IndexOf(_elements, item);
            if (indexOf == -1) return false;
            for (var i = indexOf; i <= _count - 1; i++)
            {
                _elements[i] = _elements[i + 1];
            }
            _count--;
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void Init()
        {
            _elements = new T[defaultElements];
            _count = StartCount;
        }
    }
}
