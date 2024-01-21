using Core;

namespace Core
{
    using System;

    using System.Threading;
    using System.Threading.Tasks;

    public partial class Materialxportableasync
    {
        public static Task GroupTask(Materialxportableasynccontext value_MATERIALXPORTABLEASYNCCONTEXT)
        {
            Task taskResult = default;

            Task task;

            task = new Task(GroupAction(value_MATERIALXPORTABLEASYNCCONTEXT));

            taskResult = task;

            return taskResult;
        }
    }
}
