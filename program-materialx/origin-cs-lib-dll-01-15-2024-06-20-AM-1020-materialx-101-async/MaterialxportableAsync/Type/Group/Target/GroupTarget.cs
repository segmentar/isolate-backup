using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Materialxportableasync
    {
        public static void GroupTarget(Materialxportableasynccontext value_MATERIALXPORTABLEASYNCCONTEXT)
        {
            if (value_MATERIALXPORTABLEASYNCCONTEXT.HasVisualStyle)
            {
                Application.EnableVisualStyles();
            }
            else
                "false".ToString();

            Form form;

            form = new AForm();

            ApplicationContext applicationContext;

            applicationContext = new AApplicationContext(form);

            Application.Run(applicationContext);

            return;
        }
    }
}
