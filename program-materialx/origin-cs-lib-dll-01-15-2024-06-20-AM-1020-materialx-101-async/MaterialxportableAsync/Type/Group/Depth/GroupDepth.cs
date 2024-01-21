using Core;

namespace Core
{
    using System;

    public partial class Materialxportableasync
    {
        public static Object GroupDepth(Boolean answer_STA_is, Boolean answer_MTA_is, Boolean VisualStyle_HAS, Boolean answer_TASK_should, Boolean answer_THREAD_should)
        {
            Object objectResult = default;

            Materialxportableasynccontext materialxportableasynccontext;

            materialxportableasynccontext = new Materialxportableasynccontext();

            if (answer_STA_is is true)
            {
                materialxportableasynccontext.IsSTA = true;
            }
            else
                "false".ToString();

            if (answer_MTA_is is true)
            {
                materialxportableasynccontext.IsMTA = true;
            }
            else
                "false".ToString();

            if (VisualStyle_HAS is true)
            {
                materialxportableasynccontext.HasVisualStyle = true;
            }
            else
                "false".ToString();

            if (answer_TASK_should is true)
            {
                materialxportableasynccontext.ShouldTask = true;
            }
            else
                "false".ToString();

            if (answer_THREAD_should is true)
            {
                materialxportableasynccontext.ShouldThread = true;
            }
            else
                "false".ToString();

            objectResult = GroupSurface(materialxportableasynccontext);

            return objectResult;
        }
    }
}
