using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Generics
{
    internal class MyCollection<T>
        : System.Collections.IEnumerable
    {
        private System.Collections.ArrayList _theItems;

        public MyCollection()
        {
            _theItems = new System.Collections.ArrayList();
        }

        public T this[int indexPosition]
        {
            get
            {
                return (T)this._theItems[indexPosition];            // unbox the item explicitly
            }
        }

        public void Add(T item)
        {
            _theItems.Add(item);                                    // box the item implicitly
        }

        public void RemoveAt(int indexPosition)
        {
            _theItems.RemoveAt(indexPosition);
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            foreach(T item in _theItems)
            {
                yield return item;
            }
        }
    }
}
