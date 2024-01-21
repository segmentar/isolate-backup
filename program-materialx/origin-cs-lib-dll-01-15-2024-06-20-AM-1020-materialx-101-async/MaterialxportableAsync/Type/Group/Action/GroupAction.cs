using Core;

namespace Core
{
    using System;

    public partial class Materialxportableasync
    {
        public static Action GroupAction(Materialxportableasynccontext value_MATERIALXPORTABLEASYNCCONTEXT)
        {
            Action actionResult = default;

            Action action;

            action = default;

            if (value_MATERIALXPORTABLEASYNCCONTEXT.IsSTA)
            {
                action = new Action(() => { GroupSTA(value_MATERIALXPORTABLEASYNCCONTEXT); });
            }
            else
                "false".ToString();

            if (value_MATERIALXPORTABLEASYNCCONTEXT.IsMTA)
            {
                action = new Action(() => { GroupMTA(value_MATERIALXPORTABLEASYNCCONTEXT); });
            }
            else
                "false".ToString();

            actionResult = action;

            return actionResult;
        }
    }
}
