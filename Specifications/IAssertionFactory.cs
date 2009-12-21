using System;
using Specifications.Asserts;

namespace Specifications
{
    public interface IAssertionFactory
    {
        IComparableAssert Comparable { get; }
        IEnumerableAssert Enumerable { get; }
        IGenericEnumerableAssert GenericEnumerable { get; }
        IEqualityAssert Equality { get; }
        IStringAssert String { get; }
        IReferenceAssert Reference { get; }
        void Throws<TException>( Action action ) where TException : Exception;
    }
}