using System;
using Specifications;
using Specifications.Asserts;
using Xunit.BDD.Asserts;

namespace Xunit.BDD
{
    public class XunitAssertionFactory : IAssertionFactory
    {
        readonly IStringAssert stringAssert;
        readonly IComparableAssert comparableAssert;
        readonly IEnumerableAssert enumerableAssert;
        readonly IGenericEnumerableAssert genericEnumerableAssert;
        readonly IEqualityAssert equalityAssert;
        readonly IReferenceAssert referenceAssert;

        public XunitAssertionFactory()
        {
            stringAssert = new XunitStringAssert();
            comparableAssert = new XunitComparableAssert();
            enumerableAssert = new XunitEnumerableAssert();
            genericEnumerableAssert = new XunitEnumerableOfTAssert();
            equalityAssert = new XunitEqualityAssert();
            referenceAssert = new XunitReferenceAssert();
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

        public void Throws<TException>(Action action) where TException : Exception
        {
            Assert.Throws<TException>(() => action());
        }
    }
}