using System;
using System.IO;
using System.Text;

namespace ibf_unpack
{
    static class IbfUnpack
    {

        public static void Unpack(string archivePath)
        {
            string systemDir = Path.Combine(Path.GetDirectoryName(archivePath), "System");
            Directory.CreateDirectory(systemDir);
            
            Stream stream = File.OpenRead(archivePath);
            int fileNameLength = stream.ReadByte();
            while (fileNameLength > 0)
            {
                string fileName = string.Empty;
                for (int i = 0; i < fileNameLength; i++)
                {
                    int currentByte = stream.ReadByte();
                    if (currentByte > 0)
                    {
                        fileName += Convert.ToChar(currentByte);
                    }
                    stream.ReadByte();
                }

                string filePath = Path.Combine(systemDir, fileName);
                File.WriteAllText(filePath, string.Empty);

                int chunkSize = 2048;
                int fileLength = BitConverter.ToInt32(ReadBytes(stream, 4), 0);
                for (int i = chunkSize; i < fileLength; i += chunkSize)
                {
                    WriteChunkFromStream(stream, chunkSize, filePath);
                }

                int remained = fileLength - fileLength / chunkSize * chunkSize;
                WriteChunkFromStream(stream, remained, filePath);

                fileNameLength = stream.ReadByte();
            }
            stream.Close();
        }

        private static byte[] ReadBytes(Stream stream, int length)
        {
            byte[] bytesArray = new byte[length];
            stream.Read(bytesArray, 0, length);
            return bytesArray;
        }

        private static void WriteChunkFromStream(Stream stream, int size, string filePath)
        {
            byte[] bytesArray = ReadBytes(stream, size);
            string chunk = Encoding.UTF8.GetString(bytesArray);
            File.AppendAllText(filePath, chunk);
        }

    }
}
