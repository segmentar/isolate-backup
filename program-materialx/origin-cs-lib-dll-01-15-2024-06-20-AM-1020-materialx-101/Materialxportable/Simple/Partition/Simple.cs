using Core;

namespace Core
{
    using System;

    public partial class MaterialxportableSimple
    {
        public Materialxportable Result { get; set; } = default;

        public MaterialxportableSimple()
        {
            return;
        }

        ~MaterialxportableSimple()
        {
            return;
        }
    }
}


namespace Core
{
    using System;

    public partial class MaterialxportableSimple
    {
        public MaterialxportableSimple(params String[] array_STRING)
        {
            var value = Materialxportablestringarraysafe.ForgeDefault(array_STRING);

            var result = Materialxportable.MaterialxportableMakeDefaultSurface(value);

            this.Result = result;

            return;
        }
    }
}