using System;
using System.Collections;
using System.Collections.Generic;

namespace RogueLike.Items
{
    class Inventory : IList<Item>
    {
        public Inventory(int cap)
        {
            Cap = cap;
            _innerList.Capacity = cap;
        }

        private List<Item> _innerList = new List<Item>();

        private int Cap { get; set; }
        public int Count { get { return _innerList.Count; } }
        public bool IsReadOnly { get; }

        public Item this[int index]
        {
            get { return _innerList[index]; }
            set { _innerList[index] = value; }
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

        public void Add(Item item)
        {
            _innerList.Add(item);
        }

        // Not implemented

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