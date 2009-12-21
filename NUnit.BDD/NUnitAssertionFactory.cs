using System;
using NUnit.BDD.Asserts;
using NUnit.Framework;
using Specifications;
using Specifications.Asserts;

namespace NUnit.BDD
{
    public class NUnitAssertionFactory : IAssertionFactory
    {
        readonly IStringAssert stringAssert;
        readonly IComparableAssert comparableAssert;
        readonly IEnumerableAssert enumerableAssert;
        readonly IGenericEnumerableAssert genericEnumerableAssert;
        readonly IEqualityAssert equalityAssert;
        readonly IReferenceAssert referenceAssert;

        public NUnitAssertionFactory()
        {
            stringAssert = new NUnitStringAssert();
            comparableAssert = new NUnitComparableAssert();
            enumerableAssert = new NUnitEnumerableAssert();
            genericEnumerableAssert = new NUnitGenericEnumerableAssert();
            equalityAssert = new NUnitEqualityAssert();
            referenceAssert = new NUnitReferenceAssert();
        }

        public IComparableAssert Comparable
        {
            get { return comparableAssert; }
        }

        public IEnumerableAssert Enumerable
        {
            get { return enumerableAssert; }
        }

        public IGenericEnumerableAssert GenericEnumerable
        {
            get { return genericEnumerableAssert; }
        }

        public IEqualityAssert Equality
        {
            get { return equalityAssert; }
        }

        public IStringAssert String
        {
            get { return stringAssert; }
        }

        public IReferenceAssert Reference
        {
            get { return referenceAssert; }
        }

        public void Throws<TException>( Action action ) where TException : Exception
        {
            Assert.Throws<TException>( () => action() );
        }
    }
}