using System;
using System.Collections.Generic;
using System.Text;

namespace singletonAssignment.Simple
{
    /// <summary>
    /// Simple singleton implementation
    /// lazy - creates instance on demand
    /// not thread-safe
    /// </summary>
    public sealed class Singleton
    {
        private static Singleton instance = null;

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        private Singleton() { }
    }
}
