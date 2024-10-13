using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_01
{
    internal class Cabinet<T> where T : class
    {
        private T?[] _shelfs;

        public Cabinet(int numberOfShelfs)
        {
            if (numberOfShelfs < 0)
            {
                throw new ArgumentException("Number of shelfs in a cabinet cannot be 0 or less");
            }

            _shelfs = new T[numberOfShelfs];
        }

        public void AddItem(T item, int position)
        {
            if (position < 0 || position >= _shelfs.Length)
            {
                throw new ArgumentOutOfRangeException("position", "Trying to add item to a shelf that is out of bounds of the cabinet size.");
            }

            if (_shelfs[position] != null)
            {
                throw new ArgumentException($"The shelf on position {position} is already taken.");
            }

            _shelfs[position] = item;
        }

        public T? RemoveItem(int position)
        {
            if (position < 0 || position >= _shelfs.Length)
            {
                throw new ArgumentOutOfRangeException("position", "Trying to remove an item from a shelf that is out of bounds of the cabinet size.");
            }

            T? item = _shelfs[position];
            _shelfs[position] = null;

            return item;
        }

        public T? ViewItem(int position)
        {
            return _shelfs[position];
        }

    }
}
