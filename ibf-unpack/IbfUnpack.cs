using System;
using System.Collections.Generic;
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

        public static void UnpackV2(string archivePath)
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

                List<byte> file = new List<byte>();
                byte prevB = byte.MaxValue;
                while (true)
                {
                    byte b = ReadBytes(stream, 1)[0];
                    if ((prevB == 0x0D || prevB == 0x5B) && b == 0x0)
                    {
                        file.Add(prevB);
                        file.Add(b);
                        break;
                    }
                    prevB = b;
                }

                while (true)
                {
                    byte[] symbol = ReadBytes(stream, 2);
                    if (symbol[0] == 0x0 && symbol[1] == 0x0)
                    {
                        WriteBytes(file.ToArray(), filepath);
                        break;
                    }
                    file.AddRange(symbol);
                }

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
            File.WriteAllText(archivePath, string.Empty);
            foreach (string file in files)
            {
                string filename = Path.GetFileName(file);
                byte[] fullFilenameLengthBytes = BitConverter.GetBytes(filename.Length + 1);
                byte[] shortFilenameLengthBytes = new byte[1];
                shortFilenameLengthBytes[0] = fullFilenameLengthBytes[0];
                WriteBytes(shortFilenameLengthBytes, archivePath); // write filename length

                List<byte> filenameBytes = new List<byte>();
                for (int i = 0; i < filename.Length; i++)
                {
                    filenameBytes.AddRange(BitConverter.GetBytes(filename[i]));
                }
                filenameBytes.Add(0); // filename.Length + 1
                filenameBytes.Add(0);
                WriteBytes(filenameBytes.ToArray(), archivePath); // write filename

                Stream stream = File.OpenRead(file);
                int fileLength = Convert.ToInt32(stream.Length);
                byte[] realFileLengthBytes = BitConverter.GetBytes(fileLength);
                byte[] shortFileLengthBytes = new byte[4];
                for (int i = 0; i < 4; i++)
                {
                    shortFileLengthBytes[i] = realFileLengthBytes[i];
                }
                WriteBytes(shortFileLengthBytes, archivePath); // write body length

                int chunkSize = 65536;
                for (int i = chunkSize; i < stream.Length; i += chunkSize)
                {
                    ReadAndWriteBytes(stream, chunkSize, archivePath); // write body
                }
                int remained = fileLength - fileLength / chunkSize * chunkSize;
                ReadAndWriteBytes(stream, remained, archivePath); // write remainder
            }
        }
    }
}
