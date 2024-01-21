using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablewritefileModule
    {
        public partial class XDouble
        {
            public static XDouble ForgeLevel(Materialxportablelayout value_MATERIALXPORTABLELAYOUT, MaterialxportablewritestreamPort value_MATERIALXPORTABLEWRITESTREAMPORT)
            {
                XDouble xdoubleResult = default;

                MemoryStream memoryStream;

                memoryStream = new MemoryStream();

                memoryStream.Write(value_MATERIALXPORTABLEWRITESTREAMPORT.HeaderTableByteArray, 0, value_MATERIALXPORTABLEWRITESTREAMPORT.HeaderTableByteArray.Length);

                memoryStream.Seek(value_MATERIALXPORTABLELAYOUT.StartAddressSubjectTable, SeekOrigin.Begin);

                memoryStream.Write(value_MATERIALXPORTABLEWRITESTREAMPORT.SubjectTableByteArray, 0, value_MATERIALXPORTABLEWRITESTREAMPORT.SubjectTableByteArray.Length);

                memoryStream.Seek(value_MATERIALXPORTABLELAYOUT.StartAddressObjectTable, SeekOrigin.Begin);

                memoryStream.Write(value_MATERIALXPORTABLEWRITESTREAMPORT.ObjectTableByteArray, 0, value_MATERIALXPORTABLEWRITESTREAMPORT.ObjectTableByteArray.Length);

                XDouble xdouble;

                xdouble = new XDouble(memoryStream);

                xdoubleResult = xdouble;

                return xdoubleResult;
            }
        }
    }
}
