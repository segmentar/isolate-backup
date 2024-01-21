using Core;

namespace Core
{
    using System;

    public partial class AForm
    {
        protected override void OnLoad(EventArgs e)
        {
            PropagateLoadRedirect(this, e);

            if (AFormPrevent.PropagateLoadPrevent)
            {
                return;
            }
            else
            {
                base.OnLoad(e);
            }

            return;
        }
    }
}
