using Specifications;
using Specifications.Tests;
using Xunit;

namespace NUnit.BDD.Tests
{
    class BuilderTests
    {
        IAssertionFactory factory;

        public BuilderTests()
        {
            factory = new NUnitAssertionFactory();
        }

        [Fact]
        public void RunBooleanBuilderTests()
        {
            new BooleanAssertBuilderTests(factory).Run();
        }

        [Fact]
        public void RunStringAssertBuilderTests()
        {
            new StringAssertBuilderTests(factory).Run();
        }

        [Fact]
        public void RunObjectAssertBuilderTests()
        {
            new ObjectAssertBuilderTests(factory).Run();
        }

        [Fact]
        public void RunComparableAssertBuilderTests()
        {
            new ComparableAssertBuilderTests(factory).Run();
        }

        [Fact]
        public void RunCollectionAssertBuilderTests()
        {
            new CollectionAssertBuilderTests(factory).Run();
        }

        [Fact]
        public void RunEnumerableAssertBuilderTests()
        {
            new EnumerableAssertBuilderTests(factory).Run();
        }

        [Fact]
        public void RunExceptionHandlerTests()
        {
            new ExceptionHandlerTests(factory).Run();
        }

    }
}