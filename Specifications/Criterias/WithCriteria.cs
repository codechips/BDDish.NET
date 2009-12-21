using System;

namespace Specifications.Criterias
{
    public class WithCriteria
    {
        readonly Action<string,string> assert;
        string actual;

        public WithCriteria(Action<string, string> positiveAssert, Action<string,string> negativeAssert, bool isInvert, string actual)
        {
            assert = isInvert ? negativeAssert : positiveAssert;
            this.actual = actual;
        }

        public void With(string expected)
        {
            assert( expected, actual );
        }
    }
}