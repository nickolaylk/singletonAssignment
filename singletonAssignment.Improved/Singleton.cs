using System;

namespace singletonAssignment.Improved
{
    /// <summary>
    /// Improved singleton using System.Lazy<T> type
    /// It's implements thread safe lazy instance creating on demand
    /// </summary>
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        private Singleton() { }
    }
}
