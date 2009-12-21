using NUnit.Framework;
using Specifications;
using Specifications.Tests;

namespace Xunit.BDD.Tests
{
    [TestFixture]
    class BuilderTests
    {
        IAssertionFactory factory;

        [TestFixtureSetUp]
        public void FixtureSetup()
        {
            factory = new XunitAssertionFactory();            
        }

        [Test]
        public void RunBooleanBuilderTests()
        {
            new BooleanAssertBuilderTests(factory).Run();
        }

        [Test]
        public void RunStringAssertBuilderTests()
        {
            new StringAssertBuilderTests(factory).Run();
        }

        [Test]
        public void RunObjectAssertBuilderTests()
        {
            new ObjectAssertBuilderTests(factory).Run();
        }

        [Test]
        public void RunComparableAssertBuilderTests()
        {
            new ComparableAssertBuilderTests(factory).Run();
        }

        [Test]
        public void RunCollectionAssertBuilderTests()
        {
            new CollectionAssertBuilderTests(factory).Run();
        }

        [Test]
        public void RunEnumerableAssertBuilderTests()
        {
            new EnumerableAssertBuilderTests(factory).Run();
        }

        [Test]
        public void RunExceptionHandlerTests()
        {
            new ExceptionHandlerTests(factory).Run();
        }
    }
}