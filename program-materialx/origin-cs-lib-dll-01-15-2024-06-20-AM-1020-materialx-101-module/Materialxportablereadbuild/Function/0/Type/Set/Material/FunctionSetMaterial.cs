using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class MaterialxportablereadbuildModule
    {
        public partial class XZeroth
        {
            public static IList<Materialxportable> FunctionMaterialSet(MaterialxportablereadXlev_lY[] Level_ARRAY)
            {
                ICollection<Materialxportable> collectionResult = default;

                collectionResult = new Collection<Materialxportable>();

                foreach (MaterialxportablereadXlev_lY Level_VALUE in Level_ARRAY)
                {
                    var result = Level_VALUE.Materialxportable;

                    collectionResult.Add(result);

                    continue;
                }

                return new List<Materialxportable>();
            }
        }
    }
}
