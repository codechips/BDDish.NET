namespace Specifications.Criterias
{
    public class SameCriteria
    {
        bool isInvert;
        object actual;
        object expected;
        IAssertionFactory factory;

        public SameCriteria(IAssertionFactory factory, object actual, object expected)
        {
            this.actual = actual;
            this.expected = expected;
            this.factory = factory;
        }

        public SameCriteria Is
        {
            get { return this; }
        }

        public SameCriteria Are
        {
            get { return this; }
        }

        public SameCriteria The
        {
            get { return this; }
        }

        public SameCriteria Not
        {
            get
            {
                isInvert = !isInvert;
                return this;
            }
        }

        public void Same()
        {
            if (isInvert)
                factory.Reference.NotSame( actual, expected );
            else
                factory.Reference.Same(actual, expected);
        }
    }
}