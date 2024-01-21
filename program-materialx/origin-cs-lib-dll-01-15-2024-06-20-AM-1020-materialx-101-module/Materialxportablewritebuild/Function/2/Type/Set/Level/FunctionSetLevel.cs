using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class MaterialxportablewritebuildModule
    {
        public partial class XDouble
        {
            public static IList<MaterialxportablewriteXl_velY> FunctionLevelSet(MaterialxportablewriteX_evelY[] Level_ARRAY)
            {
                ICollection<MaterialxportablewriteXl_velY> collectionResult = default;

                collectionResult = new Collection<MaterialxportablewriteXl_velY>();

                foreach (MaterialxportablewriteX_evelY Level_VALUE in Level_ARRAY)
                {
                    var reflect = (Materialxportablestringarraysafe)(Level_VALUE.Materialxportable.RouteIdentity as Object);

                    var value = 0;

                    value = value + reflect.Value.Length;

                    value = value - 1;

                    MaterialxportablewriteXl_velY level;

                    level = new MaterialxportablewriteXl_velY();

                    level.Ordinal = Level_VALUE.Ordinal;

                    level.Length = value;

                    level.Materialxportable = Level_VALUE.Materialxportable;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<MaterialxportablewriteXl_velY>(collectionResult);
            }
        }
    }
}
