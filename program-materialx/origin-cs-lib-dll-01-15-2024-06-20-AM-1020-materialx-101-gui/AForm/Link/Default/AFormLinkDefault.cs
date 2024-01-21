using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class AFormDefault
    {
        public static String TextDefault;

        public static Boolean ShowIconDefault;

        public static FormWindowState FormWindowStateDefault;

        static AFormDefault()
        {
            TextDefault = "Overlap";

            ShowIconDefault = false;

            FormWindowStateDefault = FormWindowState.Maximized;

            return;
        }
    }
}
