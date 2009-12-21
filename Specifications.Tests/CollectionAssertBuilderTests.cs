using System.Collections.Generic;
using Specifications.Builders;

namespace Specifications.Tests
{
    public class CollectionAssertBuilderTests
    {
        IAssertionFactory factory;

        public CollectionAssertBuilderTests(IAssertionFactory factory)
        {
            this.factory = factory;
        }

        GenericEnumerableAssertBuilder<T> Ensure<T>(IEnumerable<T> collection) 
        {
            return new GenericEnumerableAssertBuilder<T>( factory, collection );
        }

        public void Run()
        {
            var list = new List<int>();
            list.Add(1);

            Ensure(list).Contains(1);
            Ensure(list).Does.Contain(1);
            Ensure(list).Must.Contain(1);
            Ensure(list).Should.Contain(1);

            Ensure(list).Does.Not.Contain(2);
            Ensure(list).Must.Not.Contain(2);
            Ensure(list).Should.Not.Contain(2);

            Ensure(list).Is.Not.Empty();
            Ensure(list).Must.Not.Be.Empty();
            Ensure(list).Should.Not.Be.Empty();

            var empty = new List<string>();

            Ensure(empty).Is.Empty();
            Ensure(empty).Must.Be.Empty();
            Ensure(empty).Should.Be.Empty();

            Ensure(empty).And(empty).Are.The.Same();
            Ensure(empty).And(new List<string>()).Are.Not.The.Same();

            Ensure(empty).Is.Not.Null();

            empty = null;

            Ensure(empty).Is.Null();
        }
    }
}
