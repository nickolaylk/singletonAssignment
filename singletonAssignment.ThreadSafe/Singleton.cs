using System;

namespace singletonAssignment.ThreadSafe
{
    /// <summary>
    /// Thread-safe singleton
    /// Only one (first) thread will create an instance
    /// Cons: after the instance was created, each call will make redundant lock (performance) 
    /// </summary>
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object locker = new object();

        public static Singleton Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        private Singleton() { }
    }
}
