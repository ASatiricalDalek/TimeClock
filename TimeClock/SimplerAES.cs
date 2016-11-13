using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace TimeClock
{
    public class SimplerAES
    {
        private static byte[] key = { 147, 51, 126, 191, 233, 46, 40, 63, 110, 100, 42, 94, 254, 228, 83, 160, 229, 211, 103, 107, 92, 196, 201, 84, 102, 64, 166, 165, 201, 231, 5, 86 };
        private static byte[] vector = { 120, 55, 84, 10, 155, 155, 210, 144, 227, 93, 180, 196, 118, 240, 69, 219 };
        private ICryptoTransform encryptor, decryptor;
        private UTF8Encoding encoder;

        public SimplerAES()
        {
            RijndaelManaged rm = new RijndaelManaged();
            encryptor = rm.CreateEncryptor(key, vector);
            decryptor = rm.CreateDecryptor(key, vector);
            encoder = new UTF8Encoding();
        }

        public string Encrypt(string unencrypted)
        {
            return Convert.ToBase64String(Encrypt(encoder.GetBytes(unencrypted)));
        }

        public string Decrypt(string encrypted)
        {
            return encoder.GetString(Decrypt(Convert.FromBase64String(encrypted)));
        }

        public byte[] Encrypt(byte[] buffer)
        {
            return Transform(buffer, encryptor);
        }

        public byte[] Decrypt(byte[] buffer)
        {
            return Transform(buffer, decryptor);
        }

        protected byte[] Transform(byte[] buffer, ICryptoTransform transform)
        {
            MemoryStream stream = new MemoryStream();
            using (CryptoStream cs = new CryptoStream(stream, transform, CryptoStreamMode.Write))
            {
                cs.Write(buffer, 0, buffer.Length);
            }
            return stream.ToArray();
        }
    }
}
