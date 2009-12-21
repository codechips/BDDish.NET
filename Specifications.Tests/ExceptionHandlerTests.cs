using System;

namespace Specifications.Tests
{
    public class ExceptionHandlerTests
    {
        IAssertionFactory factory;

        public ExceptionHandlerTests(IAssertionFactory factory)
        {
            this.factory = factory;
        }

        ExceptionHandler Ensure(Action action)
        {
            return new ExceptionHandler( factory, action);
        }

        public void Run()
        {
            Ensure(() => ThrowException()).Throws<DivideByZeroException>();
        }

        static int ThrowException()
        {
            throw new DivideByZeroException();
        }
    }
}
