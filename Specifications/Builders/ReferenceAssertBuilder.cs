using Specifications.Criterias;

namespace Specifications.Builders
{
    public class ReferenceAssertBuilder<TType, TBuilder> : NegationGenericBuilder<TBuilder> where TBuilder : class
    {
        protected IAssertionFactory factory;
        protected TType actual;

        public ReferenceAssertBuilder(IAssertionFactory factory, TType actual)
        {
            this.factory = factory;
            this.actual = actual;
        }

        public SameCriteria And(TType expected)
        {
            return new SameCriteria(factory, actual, expected);
        }

        public AsCriteria Same
        {
            get { return CreateCriteria(); }
        }

        AsCriteria CreateCriteria()
        {
            var assert = isNot ? factory.Reference.NotSame : factory.Reference.Same;
            return new AsCriteria((expected) => assert(actual, expected));
        }

        public void Null()
        {
            var assert = isNot ? factory.Reference.NotNull : factory.Reference.Null;
            assert(actual);
        }
    }
}