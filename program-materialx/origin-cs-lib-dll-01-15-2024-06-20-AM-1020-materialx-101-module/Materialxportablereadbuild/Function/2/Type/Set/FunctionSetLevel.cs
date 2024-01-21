using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class MaterialxportablereadbuildModule
    {
        public partial class XDouble
        {
            public static IList<MaterialxportablereadXl_velY> FunctionLevelSet(MaterialxportablereadX_evelY[] Level_ARRAY, BinaryReader value_BINARYREADER)
            {
                ICollection<MaterialxportablereadXl_velY> collectionResult = default;

                collectionResult = new Collection<MaterialxportablereadXl_velY>();

                using (value_BINARYREADER)
                {
                    foreach (MaterialxportablereadX_evelY Level_VALUE in Level_ARRAY)
                    {
                        Int32 routeDifference, objectDifference, typeDifference;

                        routeDifference = 0;

                        routeDifference = routeDifference + Level_VALUE.RouteEndAddress;
                        
                        routeDifference = routeDifference - Level_VALUE.RouteStartAddress;

                        routeDifference = routeDifference + 1;

                        objectDifference = 0;

                        objectDifference = objectDifference + Level_VALUE.ObjectEndAddress;
                         
                        objectDifference = objectDifference - Level_VALUE.ObjectStartAddress;

                        objectDifference = objectDifference + 1;

                        typeDifference = 0;

                        typeDifference = typeDifference + Level_VALUE.TypeEndAddress;
                        
                        typeDifference = typeDifference - Level_VALUE.TypeStartAddress;

                        typeDifference = typeDifference + 1;

                        if (Object.Equals(Level_VALUE.RouteStartAddress, Level_VALUE.RouteEndAddress) is true)
                        {
                            routeDifference = routeDifference - 1;
                        }
                        else
                            "false".ToString();

                        if (Object.Equals(Level_VALUE.ObjectStartAddress, Level_VALUE.ObjectEndAddress) is true)
                        {
                            objectDifference = objectDifference - 1;
                        }
                        else
                            "false".ToString();

                        if (Object.Equals(Level_VALUE.TypeStartAddress, Level_VALUE.TypeEndAddress) is true)
                        {
                            typeDifference = typeDifference - 1;
                        }
                        else
                            "false".ToString();

                        Byte[] routeByteArray, objectByteArray, typeByteArray;

                        value_BINARYREADER.BaseStream.Seek(Level_VALUE.RouteStartAddress, SeekOrigin.Begin);

                        routeByteArray = value_BINARYREADER.ReadBytes(routeDifference);

                        value_BINARYREADER.BaseStream.Seek(Level_VALUE.ObjectStartAddress, SeekOrigin.Begin);

                        objectByteArray = value_BINARYREADER.ReadBytes(objectDifference);

                        value_BINARYREADER.BaseStream.Seek(Level_VALUE.TypeStartAddress, SeekOrigin.Begin);

                        typeByteArray = value_BINARYREADER.ReadBytes(typeDifference);

                        MaterialxportablereadXl_velY level;

                        level = new MaterialxportablereadXl_velY();

                        level.Ordinal = Level_VALUE.Ordinal;

                        level.Length = Level_VALUE.Length;

                        level.RouteStartAddress = Level_VALUE.RouteStartAddress;

                        level.RouteEndAddress = Level_VALUE.RouteEndAddress;

                        level.ObjectStartAddress = Level_VALUE.ObjectStartAddress;

                        level.ObjectEndAddress = Level_VALUE.ObjectEndAddress;

                        level.TypeStartAddress = Level_VALUE.TypeStartAddress;

                        level.TypeEndAddress = Level_VALUE.TypeEndAddress;

                        level.RouteByteArray = routeByteArray;

                        level.ObjectByteArray = objectByteArray;

                        level.TypeByteArray = typeByteArray;

                        collectionResult.Add(level);

                        continue;
                    }

                    value_BINARYREADER.Close();

                    value_BINARYREADER.Dispose();
                }

                return new List<MaterialxportablereadXl_velY>(collectionResult);
            }
        }
    }
}
