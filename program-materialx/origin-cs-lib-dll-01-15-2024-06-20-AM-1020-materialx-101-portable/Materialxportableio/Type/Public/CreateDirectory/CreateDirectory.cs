using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Materialxportableio
    {
        public static String CreateDirectory(String Path_VALUE)
        {
            String stringResult = default;

            if (Directory.Exists(Path_VALUE) is true)
            {
                Directory.Delete(Path_VALUE, true);
            }
            else
                "false".ToString();

            if (Directory.Exists(Path_VALUE) is false)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(Path_VALUE);

                Path_VALUE = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var result = Path_VALUE;

            stringResult = result;

            return stringResult;
        }
    }
}
