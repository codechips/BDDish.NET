namespace Specifications.Builders
{
    public abstract class NegationGenericBuilder<T> : GenericBuilder<T> where T : class
    {
        protected bool isNot;

        public T Not
        {
            get
            {
                isNot = !isNot;
                return this as T;
            }
        }
    }
}