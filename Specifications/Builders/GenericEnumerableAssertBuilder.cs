using System;
using System.Collections.Generic;

namespace Specifications.Builders
{
    public sealed class GenericEnumerableAssertBuilder<T> : ReferenceAssertBuilder<IEnumerable<T>, GenericEnumerableAssertBuilder<T>>
    {
        public GenericEnumerableAssertBuilder(IAssertionFactory factory, IEnumerable<T> collection) : base(factory, collection)
        {
        }

        public GenericEnumerableAssertBuilder<T> Does
        {
            get { return this; }
        }

        public void Contains( T item )
        {
            Contain( item );
        }

        public void Contain( T item )
        {
            var assert = isNot ?
                            factory.GenericEnumerable.CollectionDoesNotContain<T>() :
                            factory.GenericEnumerable.CollectionContains<T>();
            assert( actual, item );
        }

        public void Empty()
        {
            Action<IEnumerable<T>> assert = isNot ? 
                factory.GenericEnumerable.CollectionNotEmpty<T>() : 
                factory.GenericEnumerable.CollectionEmpty<T>();

            assert( actual );
        }
     
    }
}