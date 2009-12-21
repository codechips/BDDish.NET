namespace Specifications.Builders
{
    public sealed class ObjectAssertBuilder<T> : ReferenceAssertBuilder<T, ObjectAssertBuilder<T>>
    {
        public ObjectAssertBuilder(IAssertionFactory factory, T actual) : base(factory, actual)
        {
        }
    }

  
}