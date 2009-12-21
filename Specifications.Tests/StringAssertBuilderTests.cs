using Specifications.Builders;

namespace Specifications.Tests
{
    public class StringAssertBuilderTests
    {
        IAssertionFactory factory;

        public StringAssertBuilderTests(IAssertionFactory factory)
        {
            this.factory = factory;   
        }

        StringAssertBuilder Ensure(string actual)
        {
            return new StringAssertBuilder( factory, actual );
        }
        
        public void Run()
        {
            Ensure("abc").Is.Equal.To("abc");
            Ensure("abc").Equals("abc");
            Ensure("abc").Is.Not.Equal.To("aac");
            Ensure(string.Empty).Is.Empty();
            Ensure("abc").Is.Not.Empty();
            Ensure("abc").Must.Not.Be.Empty();
            Ensure("abc").Should.Not.Be.Empty();
            Ensure(string.Empty).Should.Be.Empty();
            Ensure(string.Empty).Must.Be.Empty();
            Ensure("abc").Starts.With("a");
            Ensure("abc").Does.Start.With("a");
            Ensure("abc").Does.Not.Start.With("c");
            Ensure("abc").Ends.With("c");
            Ensure("abc").Does.End.With("c");
            Ensure("abc").Does.Not.End.With("a");
            Ensure("abc").Does.Not.Contain("d");
            Ensure("abc").Does.Contain("a");
            Ensure("abc").Contains("b");
            Ensure("abc").Matches("abc");

            string test = null;
            Ensure(test).Is.Null();
            Ensure("test").Is.Not.Null();
            Ensure("test").And("test").Are.The.Same();
            Ensure("test").And("hey").Are.Not.The.Same();
        }
    }
}
