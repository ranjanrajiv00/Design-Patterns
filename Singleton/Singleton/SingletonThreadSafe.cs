namespace Singleton
{
    /// <summary>
    /// The lock keyword marks a statement block as a critical section by obtaining the mutual-exclusion lock for a given object, executing a statement, and then releasing the lock
    /// Performance concern
    /// </summary>
    public class SingletonThreadSafe
    {
        private static SingletonThreadSafe _instance = null;
        private static readonly object threadSafe = new object();

        private SingletonThreadSafe()
        {
        }

        public static SingletonThreadSafe Instance
        {
            get
            {
                lock (threadSafe)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonThreadSafe();
                    }
                    return _instance;
                }
            }
        }
    }
}