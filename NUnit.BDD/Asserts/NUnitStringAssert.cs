using System;
using NUnit.Framework;
using Specifications.Asserts;

namespace NUnit.BDD.Asserts
{
    internal class NUnitStringAssert : IStringAssert
    {
        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<string, string> Contains
        {
            get { return StringAssert.Contains; }
        }

        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<string, string> DoesNotContain
        {
            get { return StringAssert.DoesNotContain; }
        }
        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<string, string> Match
        {
            get { return StringAssert.StartsWith; }
        }
        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<string, string> Equal
        {
            get { return StringAssert.AreEqualIgnoringCase; }
        }
        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<string, string> NotEqual
        {
            get { return StringAssert.AreNotEqualIgnoringCase; }
        }

        /// <summary>
        /// pattern, actual
        /// </summary>
        public Action<string, string> DoesNotMatch
        {
            get { return StringAssert.DoesNotMatch; }
        }

        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<string, string> StartsWith
        {
            get { return StringAssert.StartsWith; }
        }
        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<string, string> DoesNotStartWith
        {
            get { return StringAssert.DoesNotStartWith; }
        }

        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<string, string> EndsWith
        {
            get { return StringAssert.EndsWith; }
        }

        /// <summary>
        /// expected, actual
        /// </summary>
        public Action<string, string> DoesNotEndWith
        {
            get { return StringAssert.DoesNotEndWith; }
        }

        public Action<string> Empty
        {
            get { return a => Assert.That(a, Is.Empty); }
        }

        public Action<string> NotEmpty
        {
            get { return a => Assert.That(a, Is.Not.Empty); }
        }

    }
}
