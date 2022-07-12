using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton.Concrete
{
#nullable enable
    public sealed class SingletonLock
    {
        private static SingletonLock? _instance;
        private static readonly object padLock = new object();

        public static SingletonLock Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padLock)
                    {
                        if (_instance == null)
                            _instance = new SingletonLock();
                    }
                }

                return _instance;
            }
        }
    }
#nullable disable
}
