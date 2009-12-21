using System;

namespace Specifications.Criterias
{
    public class ThanCriteria
    {
        readonly Action<IComparable> assert;

        public ThanCriteria(Action<IComparable> assert)
        {
            this.assert = assert;
        }

        public void Than( IComparable expected )
        {
            assert( expected );
        }
    }
}