using Core;

namespace Core
{
    using System;

    public partial class Materialxportableasync
    {
        public static Object GroupSurface(Materialxportableasynccontext value_MATERIALXPORTABLEASYNCCONTEXT)
        {
            Object objectResult = default;

            Object objectValue;

            objectValue = default;

            if (value_MATERIALXPORTABLEASYNCCONTEXT.ShouldTask is true)
            {
                objectValue = GroupTask(value_MATERIALXPORTABLEASYNCCONTEXT);   
            }
            else
                "false".ToString();

            if (value_MATERIALXPORTABLEASYNCCONTEXT.ShouldThread is true)
            {
                objectValue = GroupThread(value_MATERIALXPORTABLEASYNCCONTEXT);
            }
            else
                "false".ToString();

            objectResult = objectValue;

            return objectResult;
        }
    }
}
