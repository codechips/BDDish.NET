using System;
using System.Collections;
using NUnit.Framework;
using Specifications.Asserts;

namespace NUnit.BDD.Asserts
{
    internal class NUnitEnumerableAssert : IEnumerableAssert
    {
        public Action<IEnumerable, object> Contains()
        {
            return CollectionAssert.Contains;
        }

        public Action<IEnumerable, object> DoesNotContain()
        {
            return CollectionAssert.DoesNotContain;
        }

        public Action<IEnumerable> IsEmpty()
        {
            return CollectionAssert.IsEmpty;
        }

        public Action<IEnumerable> IsNotEmpty()
        {
            return CollectionAssert.IsNotEmpty;
        }
    }
}
