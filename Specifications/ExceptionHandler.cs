using System;

namespace Specifications
{
    public class ExceptionHandler
    {
        Action action;
        IAssertionFactory factory;

        public ExceptionHandler(IAssertionFactory factory, Action action)
        {
            this.factory = factory;
            this.action = action;
        }

        public void Throws<TException>() where TException : Exception
        {
            factory.Throws<TException>( () => action() );
        }
    }
}