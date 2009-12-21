using System;
using NUnit.Framework;
using Specifications.Asserts;

namespace NUnit.BDD.Asserts
{
    internal class NUnitEqualityAssert : IEqualityAssert
    {
        public Action<bool> True
        {
            get { return Assert.True; }
        }

        public Action<bool> False
        {
            get { return Assert.False; }
        }
    }
}
