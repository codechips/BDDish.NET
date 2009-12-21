using System;
using System.Collections;

namespace Specifications.Asserts
{
    public interface IEnumerableAssert
    {
        Action<IEnumerable, object> Contains();
        Action<IEnumerable, object> DoesNotContain();
        Action<IEnumerable> IsEmpty();
        Action<IEnumerable> IsNotEmpty();
    }
}