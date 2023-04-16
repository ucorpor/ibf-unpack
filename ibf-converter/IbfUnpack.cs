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

                byte[] fileLengthBytes = new byte[4];
                stream.Read(fileLengthBytes, 0, fileLengthBytes.Length);
                int fileLenght = BitConverter.ToInt32(fileLengthBytes, 0);

                int chunkSize = 1024;
                for (int i = chunkSize; i < fileLenght; i += chunkSize)
                {
                    WriteChunk(stream, chunkSize, filePath);
                }

                int remained = fileLenght - fileLenght / chunkSize * chunkSize;
                WriteChunk(stream, remained, filePath);

                fileNameLength = stream.ReadByte();
            }
            stream.Close();
        }

        private static void WriteChunk(Stream stream, int size, string filePath)
        {
            byte[] chunkBytes = new byte[size];
            stream.Read(chunkBytes, 0, chunkBytes.Length);
            string chunk = Encoding.UTF8.GetString(chunkBytes);
            File.AppendAllText(filePath, chunk);
        }

    }
}
