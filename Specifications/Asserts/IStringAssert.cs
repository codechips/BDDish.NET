using System;

namespace Specifications.Asserts
{
    public interface IStringAssert
    {
        Action<string, string> Contains { get; }
        Action<string, string> DoesNotContain { get; }
        Action<string, string> Match { get; }
        Action<string, string> Equal { get; }
        Action<string, string> NotEqual { get; }
        Action<string, string> DoesNotMatch { get; }
        Action<string, string> StartsWith { get; }
        Action<string, string> DoesNotStartWith { get; }
        Action<string, string> EndsWith { get; }
        Action<string, string> DoesNotEndWith { get; }
        Action<string> Empty { get; }
        Action<string> NotEmpty { get; }
    }
}