using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.CreationalPatterns.Singleton
{
    /// <summary>
    /// this Applicationcache singleton implementation is to show how to create only one object in respective scenarios
    /// if you are using the singleton in Web applications or multi-threaded systems
    /// make sure you made the thread safety while creating instances
    /// </summary>
    public sealed class ApplicationCache
    {
        //private constructor, so that client cannot create an instance of this class
        ApplicationCache() { }

        //private object instantiated with private constructor
        static readonly ApplicationCache instance = new ApplicationCache();

        //public static property to get the instance
        public static ApplicationCache UniqueInstance {
            get { return instance; }
        }
    }
}
