using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    public class ValueListSO<TD, TE> : BaseValueListSO, IList<TD>
        where TE : EventSO<TD>
    {
        /// <summary>
        /// Event when adding something to the list.
        /// </summary>
        public TE Added;

        /// <summary>
        /// Event when removing something from the list.
        /// </summary>
        public TE Removed;

        /// <summary>
        /// Get the count of the list.
        /// </summary>
        public int Count => ValueList.Count;

        /// <summary>
        /// Is the list read only.
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        /// Actual `List&lt;T&gt;`.
        /// </summary>
        [SerializeField] private List<TD> list = new List<TD>();

        /// <summary>
        /// Add an item to the list.
        /// </summary>
        /// <param name="item">The item to add</param>
        public void Add(TD item)
        {
            list.Add(item);
            if (Added != null) 
            {
                Added.RaiseEvent(item);
            }
        }

        /// <summary>
        /// Remove an item from the list.
        /// </summary>
        /// <param name="item">The item to remove</param>
        /// <returns></returns>
        public bool Remove(TD item)
        {
            var removed = list.Remove(item);
            if (!removed) return false;
            if (null != Removed)
            {
                Removed.RaiseEvent(item);
            }
            return true;
        }
        
        /// <summary>
        /// Does the list contain the item provided?
        /// </summary>
        /// <param name="item">The item to check if it is contained in the list.</param>
        /// <returns>`true` if the item exists in the list, otherwise `false`.</returns>
        public bool Contains(TD item)
        {
            return list.Contains(item);
        }

        /// <summary>
        /// Get item at index.
        /// </summary>
        /// <param name="i">The index.</param>
        /// <returns>The item if it exists.</returns>
        public TD Get(int i)
        {
            return list[i];
        }

        /// <summary>
        /// The actual `List&lt;T&gt;` as a property.
        /// </summary>
        /// <value>Get or set the value of the list.</value>
        public List<TD> List
        {
            get { return list; }
            set { list = value; }
        }
        
        /// <summary>
        /// Indexer of the list.
        /// </summary>
        /// <value>Get or set an item via index in the list.</value>
        public TD this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }
        
        /// <summary>
        /// Copies the entire List to a compatible one-dimensional array, starting at the specified index of the target array.
        /// </summary>
        /// <param name="array">The one-dimensional Array that is the destination of the elements copied from List. The Array must have zero-based indexing.</param>
        /// <param name="arrayIndex">The zero-based index in `array` at which copying begins.</param>
        public void CopyTo(TD[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }
        
        IEnumerator IEnumerable.GetEnumerator() => list.GetEnumerator();

        /// <summary>
        /// Get an `IEnumerator&lt;T&gt;` of the list.
        /// </summary>
        /// <returns>An `IEnumerator&lt;T&gt;`</returns>
        public IEnumerator<TD> GetEnumerator() => list.GetEnumerator();

        /// <summary>
        /// Returns the index of the specified item.
        /// </summary>
        /// <param name="item">The item to search for.</param>
        /// <returns>The zero-based index of the first occurrence of `item`. If not found it returns -1.</returns>
        public int IndexOf(TD item) => list.IndexOf(item);

        /// <summary>
        /// Remove an item at provided index.
        /// </summary>
        /// <param name="index">The index to remove item at.</param>
        public void RemoveAt(int index)
        {
            var item = list[index];
            list.RemoveAt(index);
            if (null != Removed)
            {
                Removed.RaiseEvent(item);
            }
        }

        /// <summary>
        /// Insert item at index.
        /// </summary>
        /// <param name="index">Index to insert item at.</param>
        /// <param name="item">Item to insert.</param>
        public void Insert(int index, TD item)
        {
            list.Insert(index, item);
            if (Added != null)
            {
                Added.RaiseEvent(item);
            }
        }
        
        protected override IList ValueList { get => List; }
    }
}