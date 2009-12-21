using System;

namespace Specifications.Criterias
{
    public class AsCriteria
    {
        Action<object> assert;

        public AsCriteria(Action<object> assertFunc)
        {
            assert = assertFunc;
        }

        public void As( object expected )
        {
            assert( expected );
        }
    }
}