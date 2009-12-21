using System;
using System.Collections.Generic;
using NUnit.Framework;
using Specifications.Asserts;

namespace NUnit.BDD.Asserts
{
    internal class NUnitGenericEnumerableAssert : IGenericEnumerableAssert
    {
        public Action<IEnumerable<T>, T> CollectionDoesNotContain<T>()
        {
            return (collection, entity) => CollectionAssert.DoesNotContain(collection, entity);
        }

        public Action<IEnumerable<T>> CollectionEmpty<T>()
        {
            return c => CollectionAssert.IsEmpty(c);
        }

        public Action<IEnumerable<T>> CollectionNotEmpty<T>()
        {
            return c => CollectionAssert.IsNotEmpty(c);
        }
        
        public Action<IEnumerable<T>, T> CollectionContains<T>()
        {
            return (collection, entity) => CollectionAssert.Contains(collection, entity);
        }
       
    }
}
