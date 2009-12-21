using System;
using NUnit.Framework;
using Specifications.Asserts;

namespace NUnit.BDD.Asserts
{
    internal class NUnitReferenceAssert : IReferenceAssert
    {
        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<object, object> Same
        {
            get { return Assert.AreSame; }
        }

        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<object, object> NotSame
        {
            get { return Assert.AreNotSame; }
        }

        public Action<object> Null
        {
            get { return Assert.Null; }
        }

        public Action<object> NotNull
        {
            get { return Assert.NotNull; }
        }

    }
}
