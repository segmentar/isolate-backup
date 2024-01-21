using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;

    public partial class Materialxportableremotein
    {
        public static void GroupObject(Materialxportable value_MATERIALXPORTABLE)
        {
            Boolean isDefaultCheck, shouldReturnCheck;

            isDefaultCheck = (value_MATERIALXPORTABLE.ObjectIdentity == default).Equals(true);

            shouldReturnCheck = isDefaultCheck is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            using (memoryStream)
            {
                IFormatter formatter;

                formatter = new BinaryFormatter();

                formatter.Serialize(memoryStream, value_MATERIALXPORTABLE.ObjectIdentity);

                var array = memoryStream.ToArray();

                value_MATERIALXPORTABLE.RemoteArrayObject = array;

                memoryStream.Close();

                memoryStream.Dispose();
            }

            return;
        }
    }
}
