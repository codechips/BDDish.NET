using System;
using Specifications.Asserts;

namespace Xunit.BDD.Asserts
{
    internal class XunitComparableAssert : IComparableAssert
    {
        public Action<IComparable, IComparable> Equal
        {
            get { return Assert.Equal; }
        }

        public Action<IComparable, IComparable> NotEqual
        {
            get { return Assert.NotEqual; }
        }

        public Action<IComparable, IComparable> Greater
        {
            get { return ( actual, expected ) => Assert.True(actual.CompareTo(expected) > 0, 
                string.Format("'{0}' is not greater than '{1}'", actual, expected)); }
        }

        public Action<IComparable, IComparable> Less
        {
            get { return (actual, expected) => Assert.True(actual.CompareTo(expected) < 0,
                 string.Format("'{0}' is not less than '{1}'", actual, expected));}
        }

        public Action<IComparable, IComparable> GreaterOrEqual
        {
            get { return (actual, expected) => Assert.True(actual.CompareTo(expected) >= 0,
                 string.Format("'{0}' is not greater or equal to '{1}'", actual, expected)); }
        }

        public Action<IComparable, IComparable> LessOrEqual
        {
            get { return (actual, expected) => Assert.True(actual.CompareTo(expected) <= 0,
                 string.Format("'{0}' is not less or equal to '{1}'", actual, expected));}
        }
    }
}
