using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablereadfileModule
    {
        public partial class XSingle
        {
            public static XSingle ForgeLevel(String Filename_VALUE)
            {
                XSingle xsingleResult = default;

                FileStream fileStream;

                fileStream = File.OpenRead(Filename_VALUE);

                MemoryStream memoryStream;

                memoryStream = new MemoryStream();

                fileStream.CopyTo(memoryStream);

                memoryStream.Position = 0;

                var array = memoryStream.ToArray();

                XSingle xsingle;

                xsingle = new XSingle(fileStream, memoryStream, array);

                xsingleResult = xsingle;

                return xsingleResult;
            }
        }
    }
}
