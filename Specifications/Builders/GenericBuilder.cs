namespace Specifications.Builders
{
    public abstract class GenericBuilder<T> where T : class {

        public T Is
        {
            get { return this as T; }
        }

        public T Must
        {
            get { return this as T;  }
        }
        
        public T Should 
        {
            get { return this as T; }
        }

        public T Be
        {
            get { return this as T; }
        }
    }
}