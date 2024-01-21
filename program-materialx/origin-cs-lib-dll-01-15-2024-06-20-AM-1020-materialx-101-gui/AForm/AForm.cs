using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class AForm : Form,
Materialxportableinterface.IExposable<AForm>,
Materialxportableinterface.IAccessorder,
Materialxportableinterface.IStyleorder<AForm>,
Materialxportableinterface.IEventorder<AForm>,
Materialxportableinterface.ITimeorder<AForm>
    {
        public static AForm Instance { get; set; } = default;

        public AForm()
        {
            Accessorder();

            return;
        }

        ~AForm()
        {
            CleanInstance();

            return;
        }

        public void Accessorder()
        {
            ExposeInstance().Styleorder().Eventorder().Timeorder();

            return;
        }

        public AForm Styleorder()
        {
            this.Text = Immutable.Text;

            this.ShowIcon = Immutable.ShowIcon;

            this.WindowState = Immutable.FormWindowState;

            return this;
        }

        public AForm Eventorder()
        {
            this.Load += PropagateLoadRedirect;

            this.Paint += PropagatePaintRedirect;

            return this;
        }

        public AForm Timeorder()
        {
            Timer timer;

            timer = new Timer();

            timer.Interval = 500;

            timer.Tick += Tick;

            timer.Start();
            
            return this;
        }

        public AForm ExposeInstance()
        {
            Instance = this;

            return this;
        }

        public AForm CleanInstance()
        {
            Instance = null;

            return this;
        }
    }
}
