using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class Materialxportableasync
    {
        public static Thread GroupThread(Materialxportableasynccontext value_MATERIALXPORTABLEASYNCCONTEXT)
        {
            Thread threadResult = default;

            ThreadStart threadStart;

            threadStart = new ThreadStart(GroupAction(value_MATERIALXPORTABLEASYNCCONTEXT));

            Thread thread;

            thread = new Thread(threadStart);

            threadResult = thread;

            return threadResult;
        }
    }
}
