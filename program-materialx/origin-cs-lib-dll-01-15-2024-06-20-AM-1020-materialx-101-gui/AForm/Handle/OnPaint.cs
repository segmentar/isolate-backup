using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class AForm
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            PropagatePaintRedirect(this, e);

            if (AFormPrevent.PropagatePaintPrevent)
            {
                return;
            }
            else
            {
                base.OnPaint(e);
            }

            return;
        }
    }
}
