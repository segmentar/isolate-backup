using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class MaterialxportablewritebuildModule
    {
        public partial class XSingle
        {
            public static IList<MaterialxportablewriteX_evelY> FunctionLevelSet(Materialxportable[] array_MATERIALXPORTABLE)
            {
                ICollection<MaterialxportablewriteX_evelY> collectionResult = default;

                collectionResult = new Collection<MaterialxportablewriteX_evelY>();

                var ordinal = 1;

                foreach (Materialxportable value_MATERIALXPORTABLE in array_MATERIALXPORTABLE)
                {
                    MaterialxportablewriteX_evelY level;

                    level = new MaterialxportablewriteX_evelY();

                    level.Ordinal = ordinal;

                    level.Materialxportable = value_MATERIALXPORTABLE;

                    collectionResult.Add(level);

                    ordinal = ordinal + 1;

                    continue;
                }

                return new List<MaterialxportablewriteX_evelY>(collectionResult);
            }
        }
    }
}
