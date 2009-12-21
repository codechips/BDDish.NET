using System;
using Specifications.Asserts;

namespace Xunit.BDD.Asserts
{
    internal class XunitStringAssert : IStringAssert
    {
        public Action<string, string> Contains
        {
            get { return Assert.Contains;  } 
        }

        public Action<string, string> DoesNotContain
        {
            get { return Assert.DoesNotContain;  }
        }

        public Action<string, string> Match
        {
            get
            {
                return ( expected, actual ) =>
                    Assert.True(StringComparer.CurrentCulture.Compare(actual, expected) == 0, 
                    string.Format("'{0}' does not match '{1}'", actual, expected));
            }
        }

        public Action<string, string> Equal
        {
            get { return Assert.Equal; }
        }

        public Action<string, string> NotEqual
        {
            get { return Assert.NotEqual;  } 
        }

        public Action<string, string> DoesNotMatch
        {
            get {
                return ( expected, actual ) => 
                     Assert.False( StringComparer.CurrentCulture.Compare( expected, actual ) == 0 ,
                     string.Format("'{0}' matches '{1}'", actual, expected)); 
            }
        }

        public Action<string, string> StartsWith
        {
            get { return ( expected, actual ) => Assert.True(actual.StartsWith( expected ),
                    string.Format("'{0}' does not start with '{1}'", actual, expected));
            }
        }

        public Action<string, string> DoesNotStartWith
        {
            get { return ( expected, actual ) => Assert.False(actual.StartsWith(expected),
                    string.Format("'{0}' starts with '{1}'", actual, expected)); }
        }

        public Action<string, string> EndsWith
        {
            get { return ( expected, actual ) => Assert.True(actual.EndsWith(expected),
                    string.Format("'{0}' does not end with '{1}'", actual, expected));
            }
        }

        public Action<string, string> DoesNotEndWith
        {
            get { return (expected, actual) => Assert.False(actual.EndsWith(expected),
                    string.Format("'{0}' ends with '{1}'", actual, expected));
            }
        }

        public Action<string> Empty
        {
            get { return Assert.Empty;  }
        }

        public Action<string> NotEmpty
        {
            get { return Assert.NotEmpty;  }
        }
    }
}