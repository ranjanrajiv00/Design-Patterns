namespace Singleton
{
    /// <summary>
    /// Static constructors in C# are specified to execute only when an instance of the class is created or a static member is referenced, and to execute only once per AppDomain
    /// It's not as lazy as the other implementations. In particular, if you have static members other than Instance, the first reference to those members will involve creating the instance. This is corrected in the next implementation
    /// </summary>
    public class SingletonThreadSafeWithoutLock
    {
        private static readonly SingletonThreadSafeWithoutLock instance = new SingletonThreadSafeWithoutLock();

        private SingletonThreadSafeWithoutLock()
        {
        }

        private static SingletonThreadSafeWithoutLock Instance
        {
            get
            {
                return instance;
            }
        }        
    }
}