using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton.Concrete
{
#nullable enable
    public sealed class Singleton
    {
        private static Singleton? instance;
        public static Singleton Instance =>
            instance ?? (instance = new Singleton());
    }
#nullable disable
}
