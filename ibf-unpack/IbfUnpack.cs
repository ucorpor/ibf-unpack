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
            int filenameLength = stream.ReadByte() * 2;
            while (filenameLength > 0)
            {
                string filename = ReadString(stream, filenameLength).Replace("\0", string.Empty);
                string filepath = Path.Combine(systemDir, filename);
                File.WriteAllText(filepath, string.Empty);

                int chunkSize = 65536;
                int fileLength = BitConverter.ToInt32(ReadBytes(stream, 4), 0);
                for (int i = chunkSize; i < fileLength; i += chunkSize)
                {
                    ReadAndWriteBytes(stream, chunkSize, filepath);
                }

                int remained = fileLength - fileLength / chunkSize * chunkSize;
                ReadAndWriteBytes(stream, remained, filepath);

                filenameLength = stream.ReadByte() * 2;
            }
            stream.Close();
        }

        private static byte[] ReadBytes(Stream stream, int length)
        {
            byte[] bytes = new byte[length];
            stream.Read(bytes, 0, length);
            return bytes;
        }

        private static string ReadString(Stream stream, int length)
        {
            byte[] bytes = ReadBytes(stream, length);
            return Encoding.Unicode.GetString(bytes);
        }

        private static void WriteBytes(byte[] bytes, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Append);
            stream.Write(bytes, 0, bytes.Length);
            stream.Close();
        }

        private static void ReadAndWriteBytes(Stream stream, int length, string path)
        {
            byte[] bytes = ReadBytes(stream, length);
            WriteBytes(bytes, path);
        }

        public static void Make(string[] files, string archivePath)
        {

        }
    }
}
