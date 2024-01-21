using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    public partial class MaterialxportablewritebuildModule
    {
        public partial class XTriple
        {
            public static IList<MaterialxportablewriteXle_elY> FunctionLeveLSet(MaterialxportablewriteXl_velY[] Level_ARRAY)
            {
                ICollection<MaterialxportablewriteXle_elY> collectionResult = default;

                collectionResult = new Collection<MaterialxportablewriteXle_elY>();

                foreach (MaterialxportablewriteXl_velY Level_VALUE in Level_ARRAY)
                {
                    var reflect = (Materialxportablestringarraysafe)(Level_VALUE.Materialxportable.RouteIdentity as Object);

                    var value = 0;

                    value = value + reflect.Value.Length;

                    value = value - 1;

                    var array = new String[value];

                    Array.Copy(reflect.Value, 1, array, 0, value);

                    var join = String.Join(((Char)Materialxportableascii.EntityNull).ToString(), array);

                    MaterialxportablewriteXle_elY level;

                    level = new MaterialxportablewriteXle_elY();

                    level.Ordinal = Level_VALUE.Ordinal;

                    level.Length = Level_VALUE.Length;

                    level.Route = join;

                    level.Materialxportable = Level_VALUE.Materialxportable;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<MaterialxportablewriteXle_elY>(collectionResult);
            }
        }
    }
}
