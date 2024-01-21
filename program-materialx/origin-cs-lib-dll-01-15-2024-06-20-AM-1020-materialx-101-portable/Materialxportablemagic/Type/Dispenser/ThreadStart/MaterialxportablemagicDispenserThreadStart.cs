using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class Materialxportablemagic
    {
        public static Thread MaterialxportablemagicThreadStart(Object reflect_OBJECT, Int32 Linger_VALUE)
        {
            Thread threadResult = default;

            var reflect = (Thread)(reflect_OBJECT as Object);

            reflect.Start();

            reflect.Join(Linger_VALUE);

            var result = reflect;

            threadResult = result;

            return threadResult;
        }
    }
}
