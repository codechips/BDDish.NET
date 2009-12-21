using System;
using System.Collections.Generic;
using Specifications.Asserts;

namespace Xunit.BDD.Asserts
{
    internal class XunitEnumerableOfTAssert : IGenericEnumerableAssert
    {
        public Action<IEnumerable<T>, T> CollectionContains<T>()
        {
            return (collection, item) => Assert.Contains( item, collection );
        }

        public Action<IEnumerable<T>, T> CollectionDoesNotContain<T>()
        {
            return (collection, item) => Assert.DoesNotContain(item, collection);
        }

        public Action<IEnumerable<T>> CollectionEmpty<T>()
        {
            return Assert.Empty;
        }

        public Action<IEnumerable<T>> CollectionNotEmpty<T>()
        {
            return Assert.NotEmpty;
        }
    }
}