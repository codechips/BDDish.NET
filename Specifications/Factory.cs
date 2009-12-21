namespace Specifications
{
    public static class Factory
    {
        static IAssertionFactory factory;

        public static IAssertionFactory CreateInstance<T>() where T: IAssertionFactory, new()
        {
            if (factory == null)
                factory = new T();
            return factory;
        }
    }
}
