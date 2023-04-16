using System;
using System.IO;
using System.Text;

namespace ibf_unpack
{
    static class IbfUnpack
    {

        public static void Unpack(string archivePath, bool rename = false)
        {
            string systemDir = Path.Combine(Path.GetDirectoryName(archivePath), "System");
            Directory.CreateDirectory(systemDir);
            
            Stream stream = File.OpenRead(archivePath);
            int fileNameLength = stream.ReadByte() * 2 - 2;
            while (fileNameLength > 0)
            {
                string fileName = ReadUtf16Le(stream, fileNameLength);
                string filePath = Path.Combine(systemDir, fileName);
                File.WriteAllText(filePath, string.Empty);

                stream.ReadByte();
                stream.ReadByte();

                int chunkSize = 65536;
                int fileLength = BitConverter.ToInt32(ReadBytes(stream, 4), 0);
                for (int i = chunkSize; i < fileLength; i += chunkSize)
                {
                    WriteChunkFromStream(stream, chunkSize, filePath);
                }

                int remained = fileLength - fileLength / chunkSize * chunkSize;
                WriteChunkFromStream(stream, remained, filePath);

                fileNameLength = stream.ReadByte() * 2 - 2;
            }
            stream.Close();

            if (rename) File.Move(archivePath, $"{archivePath}.backup");
        }

        private static byte[] ReadBytes(Stream stream, int length)
        {
            byte[] bytesArray = new byte[length];
            stream.Read(bytesArray, 0, length);
            return bytesArray;
        }

        private static string ReadUtf16Le(Stream stream, int size)
        {
            byte[] bytesArray = ReadBytes(stream, size);
            return Encoding.Unicode.GetString(bytesArray);
        }

        private static void WriteChunkFromStream(Stream stream, int size, string filePath)
        {
            byte[] bytesArray = ReadBytes(stream, size);
            string chunk = Encoding.UTF8.GetString(bytesArray);
            File.AppendAllText(filePath, chunk);
        }

    }
}
