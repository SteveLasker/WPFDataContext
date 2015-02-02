#if false
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ConnectedServices {
    public class LinkCollection : ICollection<LinkItem> {
        protected ArrayList _innerCollection;
        protected bool _isReadOnly;
        public LinkCollection() {
            _innerCollection = new ArrayList();
        }
        public int Count {
            get {
                return _innerCollection.Count ;
            }
        }

        public bool IsReadOnly {
            get {
                return _isReadOnly;
            }
        }

        public void Add(LinkItem item) {
            _innerCollection.Add(item);
        }

        public void Clear() {
            _innerCollection.Clear();
        }

        public bool Contains(LinkItem item) {
            //loop through the inner ArrayList
            foreach (LinkItem obj in _innerCollection) {
                //compare the BusinessObjectBase UniqueId property
                if (obj.Text == item.text) {
                    //if it matches return true
                    return true;
                }
            }
            //no match
            return false;
        }

        public void CopyTo(LinkItem[] array, int arrayIndex) {
            throw new NotImplementedException();
        }

        public IEnumerator<LinkItem> GetEnumerator() {
            return new LinkItem
        }

        public bool Remove(LinkItem item) {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }
    }
}
#endif