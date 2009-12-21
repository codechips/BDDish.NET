using Specifications.Builders;

namespace Specifications.Tests
{
    public class BooleanAssertBuilderTests
    {
        IAssertionFactory factory;
 
        public BooleanAssertBuilderTests(IAssertionFactory factory)
        {
            this.factory = factory;   
        }

        BooleanAssertBuilder Ensure(bool condition)
        {
            return new BooleanAssertBuilder( factory, condition );
        }
        
        public void Run()
        {
            Ensure(1 == 1).Is.True();
            Ensure(1 == 1).Is.Not.False();
            Ensure(1 == 1).Should.Be.True();
            Ensure(1 == 1).Should.Not.Be.False();
            Ensure(1 == 1).Must.Be.True();
            Ensure(1 == 1).Must.Not.Be.False();

            Ensure(1 == 0).Is.False();
            Ensure(1 == 0).Is.Not.True();
            Ensure(1 == 0).Must.Be.False();
            Ensure(1 == 0).Must.Not.Be.True();
            Ensure(1 == 0).Should.Be.False();
            Ensure(1 == 0).Should.Not.Be.True();
        }
    }
}