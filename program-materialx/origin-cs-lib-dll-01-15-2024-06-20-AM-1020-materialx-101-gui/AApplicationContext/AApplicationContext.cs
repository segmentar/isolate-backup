using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class AApplicationContext : ApplicationContext
    {
        public AApplicationContext(Form form) : base(form)
        {
            return;
        }

        ~AApplicationContext()
        {
            return;
        }
    }
}
