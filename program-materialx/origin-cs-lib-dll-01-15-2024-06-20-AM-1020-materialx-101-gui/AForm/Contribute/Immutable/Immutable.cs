using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class AForm
    {
        public partial class Immutable
        {
            public static String Text;

            public static Boolean ShowIcon;

            public static FormWindowState FormWindowState;

            static Immutable()
            {
                Text = AFormDefault.TextDefault;

                ShowIcon = AFormDefault.ShowIconDefault;

                FormWindowState = AFormDefault.FormWindowStateDefault;

                return;
            }
        }
    }
}
