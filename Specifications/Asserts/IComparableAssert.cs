using System;

namespace Specifications.Asserts
{
    public interface IComparableAssert
    {
        Action<IComparable, IComparable> Equal { get; }
        Action<IComparable, IComparable> NotEqual { get; }
        Action<IComparable, IComparable> Greater { get; }
        Action<IComparable, IComparable> Less { get; }
        Action<IComparable, IComparable> GreaterOrEqual { get; }
        Action<IComparable, IComparable> LessOrEqual { get; }
    }
}