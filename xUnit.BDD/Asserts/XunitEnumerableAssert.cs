using System;
using System.Collections;
using Specifications.Asserts;

namespace Xunit.BDD.Asserts
{
    internal class XunitEnumerableAssert : IEnumerableAssert
    {
        public Action<IEnumerable, object> Contains()
        {
            return (collection, item) => Assert.True( CollectionContains(collection, item), 
                string.Format( "Collection does not contain item '{0}'", item ) );
        }

        static bool CollectionContains(IEnumerable collection, object item)
        {
            bool contains = false;
            foreach (var obj in collection)
            {
                if (obj.Equals(item))
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

        public Action<IEnumerable, object> DoesNotContain()
        {
            return (collection, item) => Assert.False(CollectionContains(collection, item), 
                string.Format("Collection contains item '{0}'", item));
        }

        public Action<IEnumerable> IsEmpty()
        {
            return ( collection ) => Assert.False( collection.GetEnumerator().MoveNext() );
        }

        public Action<IEnumerable> IsNotEmpty()
        {
            return ( collection ) => Assert.True( collection.GetEnumerator().MoveNext() );
        }
    }
}