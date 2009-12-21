using System;
using NUnit.Framework;
using Specifications.Asserts;

namespace NUnit.BDD.Asserts
{
    internal class NUnitComparableAssert : IComparableAssert
    {
        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<IComparable, IComparable> Equal
        {
            get { return Assert.AreEqual; }
        }

        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<IComparable, IComparable> NotEqual
        {
            get { return Assert.AreNotEqual; }
        }

        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<IComparable, IComparable> Greater
        {
            get { return Assert.Greater; }
        }
        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<IComparable, IComparable> GreaterOrEqual
        {
            get { return Assert.GreaterOrEqual; }
        }
        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<IComparable, IComparable> Less
        {
            get { return Assert.Less; }
        }
        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<IComparable, IComparable> LessOrEqual
        {
            get { return Assert.LessOrEqual; }
        }
    }
}
