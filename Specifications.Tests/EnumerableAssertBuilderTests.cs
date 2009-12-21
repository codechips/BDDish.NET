using System.Collections;
using Specifications.Builders;

namespace Specifications.Tests
{
    public class EnumerableAssertBuilderTests
    {
        IAssertionFactory factory;

        public EnumerableAssertBuilderTests(IAssertionFactory factory)
        {
            this.factory = factory;
        }

        EnumerableAssertBuilder Ensure(IEnumerable enumerable)
        {
            return new EnumerableAssertBuilder( factory, enumerable );
        }

        public void Run()
        {
            var list = new ArrayList();

            Ensure(list).Is.Empty();
            Ensure(list).Is.Not.Null();
            Ensure(list).Does.Not.Contain(1);

            list.Add(1);
            
            Ensure(list).Is.Not.Empty();
            Ensure(list).Should.Contain(1);
            Ensure(list).Does.Not.Contain("bogus");

            var stringArray = new string[] { "hello", "world" };
            Ensure( stringArray ).Contains( "hello" );
            Ensure( stringArray ).Contains( "world" );

        }
    }
}
