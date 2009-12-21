namespace Specifications.Builders
{
    public sealed class BooleanAssertBuilder : NegationGenericBuilder<BooleanAssertBuilder>
    {
        readonly bool condition;
        IAssertionFactory factory;

        public BooleanAssertBuilder(IAssertionFactory factory, bool condition)
        {
            this.condition = condition;
            this.factory = factory;
        }

        public void False()
        {
            if (isNot)
                factory.Equality.True( condition );
            else
                factory.Equality.False( condition );
        }

        public void True()
        {
            if (isNot)
                factory.Equality.False( condition );
            else
                factory.Equality.True( condition );
        }
    }
}