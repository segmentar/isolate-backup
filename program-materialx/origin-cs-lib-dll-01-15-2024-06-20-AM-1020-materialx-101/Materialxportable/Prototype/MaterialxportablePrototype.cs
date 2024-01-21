using Core;

namespace Core
{
    using System;

    public partial class Materialxportable
    {
        public Materialxportable(Object segmentArrayObject, Materialxportablestringarraysafe routeIdentity, Boolean answer_DEBUG_is)
        {
            this.SegmentArrayObject = segmentArrayObject;

            this.RouteIdentity = routeIdentity;

            if (answer_DEBUG_is is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
