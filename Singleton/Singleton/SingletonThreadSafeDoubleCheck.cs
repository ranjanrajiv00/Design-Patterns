namespace Singleton
{
    /// <summary>
    /// attempted thread-safety using double-check locking
    /// Performance concern
    /// </summary>
    public class SingletonThreadSafeDoubleCheck
    {
        private static SingletonThreadSafeDoubleCheck _instance = null;
        private static readonly object threadSafe = new object();

        private SingletonThreadSafeDoubleCheck()
        {
        }

        public static SingletonThreadSafeDoubleCheck Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (threadSafe)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonThreadSafeDoubleCheck();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}