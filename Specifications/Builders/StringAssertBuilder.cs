using Specifications.Criterias;

namespace Specifications.Builders
{
    public sealed class StringAssertBuilder : ReferenceAssertBuilder<string, StringAssertBuilder>
    {

        public StringAssertBuilder(IAssertionFactory factory, string actual) : base(factory, actual)
        {
        }

        public ToCriteria<string> Equal
        {
            get { return new ToCriteria<string>(factory.String.Equal, factory.String.NotEqual, isNot, actual);  }
        }

        public WithCriteria Starts
        {
            get { return new WithCriteria(factory.String.StartsWith, factory.String.DoesNotStartWith, isNot, actual); }
        }

        public StringAssertBuilder Does
        {
            get { return this; }
        }

        public WithCriteria Start
        {
            get { return Starts; }
        }

        public WithCriteria Ends
        {
            get { return new WithCriteria(factory.String.EndsWith, factory.String.DoesNotEndWith, isNot, actual); }
        }

        public WithCriteria End
        {
            get { return Ends; }
        }

        public void Empty()
        {
            if (isNot)
                factory.String.NotEmpty( actual );
            else
                factory.String.Empty( actual );
        }

        public void Contains( string expected )
        {
            Contain( expected );
        }

        public void Contain( string expected )
        {
            if (isNot)
                factory.String.DoesNotContain( expected, actual );
            else
                factory.String.Contains(expected, actual);
        }

        public void Match(string expected )
        {
            if (isNot)
                factory.String.DoesNotMatch(expected, actual);
            else
                factory.String.Match(expected, actual);

        }
        
        public void Matches( string expected )
        {
            Match( expected );
        }
    }
}