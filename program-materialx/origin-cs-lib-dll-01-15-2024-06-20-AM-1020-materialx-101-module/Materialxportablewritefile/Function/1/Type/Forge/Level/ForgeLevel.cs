using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablewritefileModule
    {
        public partial class XSingle
        {
            public static XSingle ForgeLevel(String Filename_VALUE)
            {
                XSingle xsingleResult = default;

                FileStream fileStream;

                fileStream = File.Create(Filename_VALUE);

                XSingle xsingle;

                xsingle = new XSingle(fileStream);

                xsingleResult = xsingle;

                return xsingleResult;
            }
        }
    }
}
