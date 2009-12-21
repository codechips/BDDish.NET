using Specifications.Builders;

namespace Specifications.Tests
{
    public class ObjectAssertBuilderTests
    {
        IAssertionFactory factory;

        public ObjectAssertBuilderTests(IAssertionFactory factory)
        {
            this.factory = factory;   
        }

        ObjectAssertBuilder<T> Ensure<T>(T actual)
        {
            return new ObjectAssertBuilder<T>(factory, actual);
        }

        public void Run()
        {
            var a = new object();
            var b = new object();

            Ensure( a ).Should.Not.Be.Null();
            Ensure( a ).Must.Not.Be.Null();
            Ensure( a ).Is.Not.Null();

            Ensure( a ).Should.Be.Same.As( a );
            Ensure( a ).Should.Not.Be.Same.As( b );
            Ensure( a ).And( a ).Are.Same();
            Ensure( a ).And( a ).Are.The.Same();
            Ensure( a ).And( b ).Are.Not.The.Same();
            Ensure( a ).And( b ).Are.Not.Same();
            Ensure( a ).And( b ).Is.Not.The.Same();
            Ensure( a ).And( a ).Is.The.Same();
            Ensure( a ).And( b ).Is.Not.Same();

            b = null;

            Ensure( b ).Is.Null();
            Ensure( b ).Must.Be.Null();
            Ensure( b ).Should.Be.Null();
        }
    }
}
