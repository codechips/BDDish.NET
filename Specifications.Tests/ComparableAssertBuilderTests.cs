using System;
using Specifications.Builders;

namespace Specifications.Tests
{
    public class ComparableAssertBuilderTests
    {
        IAssertionFactory factory;

        public ComparableAssertBuilderTests(IAssertionFactory factory)
        {
            this.factory = factory;
        }

        ComparableAssertBuilder Ensure(IComparable actual)
        {
            return new ComparableAssertBuilder( factory, actual );
        }

        public void Run()
        {
            Ensure(1 + 1).Must.Be.Equal.To(2);
            Ensure(1 + 1).Is.NotEqual.To(1);
            Ensure(1 + 1).Must.Be.Greater.Than(1);
            Ensure(1 + 1).Should.Be.Greater.Than(1);
            Ensure(1 + 1).Is.Greater.Than(1);
            Ensure(1 + 1).Is.GreaterOrEqual.To(2);
            Ensure(3).Is.GreaterOrEqual.To(2);
            Ensure(1 + 1).Must.Be.Less.Than(3);
            Ensure(1 + 1).Should.Be.Less.Than(3);
            Ensure(1).Should.Be.LessOrEqual.To(2);
            Ensure(1 + 1).Should.Be.LessOrEqual.To(2);
            Ensure(1 + 1).Must.Be.LessOrEqual.To(2);
        }
    }
}
