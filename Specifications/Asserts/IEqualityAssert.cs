using System;

namespace Specifications.Asserts
{
    public interface IEqualityAssert
    {
        Action<bool> True { get; }
        Action<bool> False { get; }
    }
}