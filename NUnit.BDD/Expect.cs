using System;
using System.Collections;
using System.Collections.Generic;
using Specifications;
using Specifications.Builders;

namespace NUnit.BDD
{
    public static class Expect
    {
        static readonly IAssertionFactory factory = Factory.CreateInstance<NUnitAssertionFactory>();

        public static BooleanAssertBuilder That(bool condition)
        {
            return new BooleanAssertBuilder( factory, condition );    
        }

        public static ObjectAssertBuilder<object> That(object actual)
        {
            return new ObjectAssertBuilder<object>( factory, actual );
        }

        public static ComparableAssertBuilder That(IComparable actual)
        {
            return new ComparableAssertBuilder( factory, actual );
        }

        public static GenericEnumerableAssertBuilder<T> That<T>(IEnumerable<T> collection)
        {
            return new GenericEnumerableAssertBuilder<T>( factory, collection );
        }

        public static StringAssertBuilder That(string actual)
        {
            return new StringAssertBuilder( factory, actual );
        }

        public static EnumerableAssertBuilder That(IEnumerable enumerable)
        {
            return new EnumerableAssertBuilder( factory, enumerable );
        }

        public static ExceptionHandler That( Action action )
        {
           return new ExceptionHandler( factory, action);
        }
    }
}