using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.Common
{
    public class ExampleHelper
    {
        /// <summary>
        /// Convert <see cref="Stream"/> to bytes array
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> to be converted</param>
        /// <returns>Bytes array</returns>
        public static byte[] ToBytes(Stream stream)
        {
            if (stream is MemoryStream)
            {
                return ((MemoryStream)stream).ToArray();
            }

            byte[] buffer = new byte[16384]; //16*1024
            using (MemoryStream ms = new MemoryStream())
            {
                stream.Seek(0, SeekOrigin.Begin);
                int read;

                while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }

                return ms.ToArray();
            }
        }
    }
}
