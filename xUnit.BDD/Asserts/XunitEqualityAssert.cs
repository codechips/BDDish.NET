using System;
using Specifications.Asserts;

namespace Xunit.BDD.Asserts
{
    internal class XunitEqualityAssert : IEqualityAssert
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