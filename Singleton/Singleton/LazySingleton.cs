using System;

namespace Singleton
{
    /// <summary>
    /// Here, instantiation is triggered by the first reference to the static member of the nested class, which only occurs in Instance. This means the implementation is fully lazy, but has all the performance benefits of the previous one
    /// </summary>
    public class LazySingleton
    {
        private LazySingleton()
        {
        }

        public static LazySingleton Instance
        {
            get
            {
                return Nested.Instance;
            }
        }

        private class Nested
        {
            static Nested()
            {
            }

            public static LazySingleton Instance = new LazySingleton();
        }

        public void InstanceInfo()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}