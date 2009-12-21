using System;
using System.Collections.Generic;

namespace Specifications.Asserts
{
    public interface IGenericEnumerableAssert
    {
        Action<IEnumerable<T>, T> CollectionContains<T>();
        Action<IEnumerable<T>, T> CollectionDoesNotContain<T>();
        Action<IEnumerable<T>> CollectionEmpty<T>();
        Action<IEnumerable<T>> CollectionNotEmpty<T>();
    }
}