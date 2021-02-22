using System;
using System.Collections;
using System.Collections.Generic;

namespace RogueLike.Items
{
    class Inventory : IList<Item>
    {
        /*
         * The inventory class is used in every situation where one or multiple items need to be stored for future use.
         */

        // Creates a list of Items with Cap size
        public Inventory(int cap)
        {
            Cap = cap;
            _innerList = new List<Item>(cap);
        }

        private List<Item> _innerList { get; set; } // Contains the base list methods

        public int Cap { get; private set; } // Size of the Inventory
        public int Count { get { return _innerList.Count; } } // Returns the amount of items on the Inventory

        // Indexer of the Inventory
        public Item this[int index]
        {
            get
            {
                // Checks to see if the index is within the range of existing items
                if (index < 0 || index > Count - 1) return new Item("");
                return _innerList[index];
            }
            set
            {
                _innerList[index] = value;
            }
        }

        public void Add(Item item)
        {
            _innerList.Add(item);
        }

        public int IndexOf(Item item)
        {
            return _innerList.IndexOf(item);
        }

        public void RemoveAt(int index)
        {
            if (index > Cap) return;
            _innerList.RemoveAt(index);
        }

        // Not implemented

        public bool IsReadOnly { get; }

        public void Insert(int index, Item item)
        {
            throw new NotSupportedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Item item)
        {
            throw new NotSupportedException();
        }

        public void CopyTo(Item[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Item item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Item> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}