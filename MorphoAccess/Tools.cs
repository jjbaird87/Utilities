using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MorphoAccess
{
    class Tools
    {
        public static void SaveFile(byte[] template, string filename, string title, string extension, string extFilter)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.AddExtension = false;

            dlg.FileName = filename;
            dlg.Title = title;
            dlg.DefaultExt = extension;
            dlg.AddExtension = true;
            dlg.Filter = extFilter;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                WriteBinaryFile(template, dlg.FileName);
            }
        }

        public static void WriteBinaryFile(byte[] blob, string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(blob, 0, blob.Length);
                fs.Close();
            }
        }


        public static byte[] ReadTemplate(string uri)
        {
            if (String.IsNullOrEmpty(uri)) { return new byte[0]; }
            if (uri.StartsWith(URI_HEXADECIMAL_STRING, true, System.Globalization.CultureInfo.InvariantCulture))
            {
                return HexadecimalStringToByteArray(uri.Substring(URI_HEXADECIMAL_STRING.Length));
            }
            else
            {
                return ReadBinaryFile(uri);
            }
        }


        public static byte[] ReadBinaryFile(string filename)
        {
            if (!File.Exists(filename)) { return new byte[0]; }
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] blob = new byte[fs.Length];
                fs.Read(blob, 0, (int)fs.Length);
                return blob;
            }
        }


        public static string ToUTF8String(byte[] src)
        {
            return System.Text.UTF8Encoding.UTF8.GetString(src);
        }


        public static string ToHexadecimalString(byte[] src)
        {
            string dst = String.Empty;
            if (null == src) { return dst; }
            for (int i = 0; i < src.Length; ++i)
            {
                dst = String.Concat(dst, Convert.ToString(src[i], HEXADECIMAL_BASE));
            }
            return dst;
        }


        public static bool ToBoolean(byte[] src)
        {
            int len = (null == src) ? 0 : src.Length;
            if (len != 1)
            {
                throw new InvalidDataException(String.Format("Received array of {0} bytes instead of 1 for boolean conversion.", len));
            }
            return (src[0] != 0);
        }

        public static byte ToByte(byte[] src)
        {
            int len = (null == src) ? 0 : src.Length;
            if (len != 1)
            {
                throw new InvalidDataException(String.Format("Received array of {0} bytes instead of 1 for byte conversion.", len));
            }
            return src[0];
        }

        public static short ToShort(byte[] src)
        {
            // Use network byte order (big endian)
            int len = (null == src) ? 0 : src.Length;
            if (len != 2)
            {
                throw new InvalidDataException(String.Format("Received array of {0} byte{1} instead of 2 for short conversion.", len, (len == 1) ? "" : "s"));
            }
            // The << operator only takes int, no short!
            int bigger = ((((short)src[0]) << BYTE_NB_BITS) + (int)src[1]);
            return (short)(bigger & SHORT_MASK);
        }


        public static byte[] UTF8StringToByteArray(string src)
        {
            return System.Text.UTF8Encoding.UTF8.GetBytes(src);
        }

        public static byte[] HexadecimalStringToByteArray(string src)
        {
            // if length is odd, last hexadecimal character will be dropped silently !
            int len = src.Length / 2;
            byte[] bytes = new byte[len];
            using (var sr = new StringReader(src))
            {
                for (int i = 0; i < len; i++)
                {
                    bytes[i] = Convert.ToByte(new string(new char[2] { (char)sr.Read(), (char)sr.Read() }), 16);
                }
            }
            return bytes;
        }

        public static byte[] ToByteArray(bool value)
        {
            if (value)
            {
                return new byte[] { 0x01 };
            }
            else
            {
                return new byte[] { 0x00 };
            }
        }


        public static byte[] ToByteArray(byte value)
        {
            return new byte[] { value };
        }


        public static byte[] ToByteArray(short value)
        {
            // Use network byte order (big endian)
            return new byte[2] { (byte)(value & BYTE_MASK), (byte)((value >> BYTE_NB_BITS) & BYTE_MASK) };
        }


        public static byte[] ToByteArray(ushort value)
        {
            // Use network byte order (big endian)
            return new byte[2] { (byte)(value & BYTE_MASK), (byte)((value >> BYTE_NB_BITS) & BYTE_MASK) };
        }



        public static byte[] ToByteArray(int value)
        {
            byte[] output = new byte[] { 0x00, 0x00, 0x00, 0x00 };
            int i = 0;
            while (value != 0)
            {
                output[i++] = (byte)(value & BYTE_MASK);
                value >>= BYTE_NB_BITS;
            }
            return output;
        }


        public static byte[] ToByteArray(uint value)
        {
            byte[] output = new byte[] { 0x00, 0x00, 0x00, 0x00 };
            int i = 0;
            while (value != 0)
            {
                output[i++] = (byte)(value & BYTE_MASK);
                value >>= BYTE_NB_BITS;
            }
            return output;
        }

        public static byte BYTE_MASK = 0xFF;
        public static int SHORT_MASK = 0xFFFF;
        public static byte BYTE_NB_BITS = 8;
        public static int HEXADECIMAL_BASE = 16;
        public static string URI_HEXADECIMAL_STRING = "hex:";
    }
}
