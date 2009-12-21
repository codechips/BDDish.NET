using System;

namespace Specifications.Asserts
{
    public interface IReferenceAssert
    {
        Action<object, object> Same { get; }
        Action<object, object> NotSame { get; }
        Action<object> Null { get; }
        Action<object> NotNull { get; }
    }
}
