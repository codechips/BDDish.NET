using System;

namespace Specifications.Criterias
{
    public class ToCriteria<T>
    {
        Action<T, T> assert;
        T actual;

        public ToCriteria(Action<T, T> positiveAssert, Action<T, T> negativeAssert, bool isInvert, T actual)
        {
            assert = isInvert ? negativeAssert : positiveAssert;
            this.actual = actual;
        }
        public void To(T expected )
        {
            assert( actual, expected );
        }
    }
}