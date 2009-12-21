using System.Collections;

namespace Specifications.Builders
{
    public sealed class EnumerableAssertBuilder : ReferenceAssertBuilder<IEnumerable, EnumerableAssertBuilder>
    {
        public EnumerableAssertBuilder( IAssertionFactory factory, IEnumerable collection ) : base( factory, collection )
        {
        }

        public EnumerableAssertBuilder Does
        {
            get { return this; }
        }

        public void Empty()
        {
            var assert = isNot ?
                            factory.Enumerable.IsNotEmpty() :
                            factory.Enumerable.IsEmpty();

            assert( actual );
        }

        public void Contain( object item)
        {
            var assert = isNot ? factory.Enumerable.DoesNotContain() : factory.Enumerable.Contains();
            assert( actual, item );
        }

        public void Contains( object item )
        {
            Contain( item );
        }
    }
}