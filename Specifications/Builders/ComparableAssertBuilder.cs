using System;
using Specifications.Criterias;

namespace Specifications.Builders
{
    public sealed class ComparableAssertBuilder : GenericBuilder<ComparableAssertBuilder>
    {
        readonly IComparable actual;
        IAssertionFactory factory;

        public ComparableAssertBuilder(IAssertionFactory factory, IComparable actual)
        {
            this.actual = actual;
            this.factory = factory;
        }

        ThanCriteria CreateThan(Action<IComparable, IComparable> assert)
        {
            return new ThanCriteria( expected => assert( actual, expected ) );    
        }

        public ToCriteria<IComparable> Equal
        {
            get { return CreateTo(factory.Comparable.Equal); }
        }
        public ToCriteria<IComparable> NotEqual
        {
            get { return CreateTo(factory.Comparable.NotEqual); }
        }

        public ToCriteria<IComparable> GreaterOrEqual
        {
            get { return CreateTo(factory.Comparable.GreaterOrEqual); }
        }

        public ToCriteria<IComparable> LessOrEqual
        {
            get { return CreateTo(factory.Comparable.LessOrEqual); }
        }

        ToCriteria<IComparable> CreateTo(Action<IComparable, IComparable> action)
        {
            return new ToCriteria<IComparable>(action, action, true, actual);
        }

        public ThanCriteria Greater
        {
            get { return CreateThan( factory.Comparable.Greater ); }
        }
        
        public ThanCriteria Less
        {
            get { return CreateThan( factory.Comparable.Less ); }
        }
    }
}