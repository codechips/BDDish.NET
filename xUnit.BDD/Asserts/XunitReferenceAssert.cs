using System;
using Specifications.Asserts;

namespace Xunit.BDD.Asserts
{
    internal class XunitReferenceAssert : IReferenceAssert
    {
        public Action<object, object> Same
        {
            get { return Assert.Same;  }
        }

        public Action<object, object> NotSame
        {
            get { return Assert.NotSame; }
        }

        public Action<object> Null
        {
            get { return Assert.Null;  }
        }

        public Action<object> NotNull
        {
            get { return Assert.NotNull; }
        }
    }
}