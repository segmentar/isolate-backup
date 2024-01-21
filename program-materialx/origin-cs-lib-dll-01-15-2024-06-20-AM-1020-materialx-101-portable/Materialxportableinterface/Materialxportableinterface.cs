using Core;

namespace Core
{
    using System;

    public partial class Materialxportableinterface
    {
        public interface IExposable
        {
            void ExposeInstance();

            void CleanInstance();
        }
        
        public interface IExposable<T>
        {
            T ExposeInstance();

            T CleanInstance();
        }
    }
}

namespace Core
{
    using System;

    public partial class Materialxportableinterface
    {
        public interface IExposer
        {
            void ExposePage();

            void CleanPage();
        }

        public interface IExposer<T>
        {
            T ExposePage();

            T CleanPage();
        }
    }
}

namespace Core
{
    using System;

    public partial class Materialxportableinterface
    {
        public interface IAccessorder
        {
            void Accessorder();
        }
    }
}

namespace Core
{
    using System;

    public partial class Materialxportableinterface
    {
        public interface IStyleorder
        {
            void Styleorder();
        }

        public interface IStyleorder<T>
        {
            T Styleorder();
        }
    }
}

namespace Core
{
    using System;

    public partial class Materialxportableinterface
    {
        public interface IEventorder
        {
            void Eventorder();
        }

        public interface IEventorder<T>
        {
            T Eventorder();
        }
    }
}

namespace Core
{
    using System;

    public partial class Materialxportableinterface
    {
        public interface ITimeorder
        {
            void Timeorder();
        }

        public interface ITimeorder<T>
        {
            T Timeorder();
        }
    }
}
