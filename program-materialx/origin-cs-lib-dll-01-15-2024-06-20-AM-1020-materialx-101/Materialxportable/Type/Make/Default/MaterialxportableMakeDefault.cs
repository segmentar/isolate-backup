using Core;

namespace Core
{
    using System;

    public partial class Materialxportable
    {
        public static Materialxportable MaterialxportableMakeDefault(Materialxportablestringarraysafe RouteIdentity__VALUE, Boolean answer_DEBUG_is)
        {
            Materialxportable materialxportableResult = default;

            var result = new MaterialxportableSequence(RouteIdentity__VALUE, answer_DEBUG_is).Result;

            Materialxportablemagic.MaterialxportablemagicArrayListCastDispenser(MaterialxportablePolicy.MaterialxportableArrayList).Add(result);

            materialxportableResult = result;

            return materialxportableResult;
        }
    }
}
