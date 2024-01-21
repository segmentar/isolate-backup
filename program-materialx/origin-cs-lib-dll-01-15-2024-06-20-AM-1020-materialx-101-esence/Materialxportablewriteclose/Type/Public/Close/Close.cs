using Core;

namespace Core
{
    using System;

    public partial struct Materialxportablewriteclose
    {
        public static void Close(Materialxportablewriteclose value_MATERIALXPORTABLEWRITECLOSE, Object[] array_OBJECT)
        {
            if (value_MATERIALXPORTABLEWRITECLOSE.FlushShould is true)
            {
                ((MaterialxportablewritefileModule)array_OBJECT[2]).MaterialxportablewritefilePortxy.FileStream.Flush();
            }
            else
                "false".ToString();

            if (value_MATERIALXPORTABLEWRITECLOSE.FileStreamCloseShould is true)
            {
                using (var stream = ((MaterialxportablewritefileModule)array_OBJECT[2]).MaterialxportablewritefilePortxy.FileStream)
                {
                    stream.Close();

                    stream.Dispose();
                }
            }

            if (value_MATERIALXPORTABLEWRITECLOSE.HeaderTableMemoryStreamCloseShould is true)
            {
                using (var stream = ((MaterialxportablewritestreamModule)array_OBJECT[1]).MaterialxportablewritestreamPortxy.HeaderTableMemoryStream)
                {
                    stream.Close();

                    stream.Dispose();
                }
            }
            else
                "false".ToString();

            if (value_MATERIALXPORTABLEWRITECLOSE.SubjectTableMemoryStreamCloseShould is true)
            {
                using (var stream = ((MaterialxportablewritestreamModule)array_OBJECT[1]).MaterialxportablewritestreamPortxy.SubjectTableMemoryStream)
                {
                    stream.Close();

                    stream.Dispose();
                }
            }
            else
                "false".ToString();

            if (value_MATERIALXPORTABLEWRITECLOSE.ObjectTableMemoryStreamCloseShould is true)
            {
                using (var stream = ((MaterialxportablewritestreamModule)array_OBJECT[1]).MaterialxportablewritestreamPortxy.ObjectTableMemoryStream)
                {
                    stream.Close();

                    stream.Dispose();
                }
            }
            else
                "false".ToString();

            return;
        }
    }
}
