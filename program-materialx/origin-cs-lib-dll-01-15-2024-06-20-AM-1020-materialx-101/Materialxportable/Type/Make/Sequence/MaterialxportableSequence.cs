using Core;

namespace Core
{
    using System;

    public partial class MaterialxportableSequence
    {
        public Materialxportable Result { get; set; } = default;

        public MaterialxportableSequence(Materialxportablestringarraysafe RouteIdentity__VALUE, Boolean answer_DEBUG_is)
        {
            Debug(RouteIdentity__VALUE, answer_DEBUG_is);

            Materialxportable[] materialxportableArray;

            materialxportableArray = new Materialxportable[6];

            Materialxportable materialxportable;

            materialxportable = new Materialxportable(materialxportableArray, RouteIdentity__VALUE, answer_DEBUG_is);

            materialxportable.View = materialxportable;

            this.Result = materialxportable;

            return;
        }

        ~MaterialxportableSequence()
        {
            return;
        }
    }
}
