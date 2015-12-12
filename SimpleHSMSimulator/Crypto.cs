using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHSMSimulator
{
    public sealed class Crypto
    {
        private static volatile Crypto instance;
        private static object syncRoot = new object();

        private Crypto() 
        { 
            this.DES_ZERO_INPUT = this.HexToByte("00000000000000000000000000000000");
            this.AES_ZERO_INPUT = this.HexToByte("0000000000000000000000000000000000000000000000000000000000000000");
            this.DES_IV = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            this.AES_IV = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        public static Crypto INSTANCE
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Crypto();
                    }
                }

                return instance;
            }
        }

        private readonly byte[] DES_ZERO_INPUT = null;
        private readonly byte[] AES_ZERO_INPUT = null;
        private readonly byte[] DES_IV = null;
        private readonly byte[] AES_IV = null;

        public bool Generate(string zmkComp1, string zmkComp2, string zmkComp3, string encryptedKeyInString, ref string clearKeyInString, ref string errMessage)
        {
            bool result = true;

            try
            {
                byte[] clearKey = this.DecryptKeyUsingZmk(encryptedKeyInString, zmkComp1, zmkComp2, zmkComp3);
                clearKeyInString = this.ByteToHex(clearKey);
            }
            catch (Exception ex)
            {
                result = false;
                errMessage = "Error Message: " + ex.Message + "\r\n" + "StackTrace: " + ex.StackTrace;
            }

            return result;
        }

        private byte[] DecryptKeyUsingZmk(string encryptedKeyInString, string zmkComp1, string zmkComp2, string zmkComp3)
        { 
            byte[] zmk = this.ZMKCombinedInBytes(zmkComp1, zmkComp2, zmkComp3);
            byte[] encryptedKeyInBytes = this.HexToByte(encryptedKeyInString);
            byte[] decryptedKeyInBytes = null;

            // TripleDes key created
            using (var tripleDes = new TripleDESCryptoServiceProvider())
            {
                tripleDes.Key = zmk;
                tripleDes.IV = DES_IV;
                tripleDes.Padding = PaddingMode.None;
                tripleDes.Mode = CipherMode.ECB;

                // Decrypt with TripleDes
                using (var decrypto = tripleDes.CreateDecryptor())
                {
                    decryptedKeyInBytes = decrypto.TransformFinalBlock(encryptedKeyInBytes, 0, encryptedKeyInBytes.Length);
                }

                tripleDes.Clear();
            }

            return decryptedKeyInBytes;
        }

        private byte[] XOR(byte[] comp1, byte[] comp2)
        {
            byte[] result = new byte[comp1.Length];
            for (int i = 0; i < result.Length; i++)
                result[i] = Convert.ToByte(comp1[i] ^ comp2[i]);

            return result;
        }

        private string ByteToHex(byte[] data)
        {
            return BitConverter.ToString(data).Replace("-", String.Empty);
        }

        private byte[] HexToByte(string hexString)
        {
            byte[] byteArray = new byte[hexString.Length / 2];

            for (int i = 0, j = 0; i < hexString.Length; i += 2, j++)
                byteArray[j] = Convert.ToByte(hexString.Substring(i, 2), 16);

            return byteArray;
        }

        public string ZMKCombinedInString(string zmkComp1, string zmkComp2, string zmkComp3)
        { 
            return this.ByteToHex(ZMKCombinedInBytes(zmkComp1, zmkComp2, zmkComp3));
        }

        public byte[] ZMKCombinedInBytes(string zmkComp1, string zmkComp2, string zmkComp3)
        {
            // ZMK Components
            byte[] comp1 = this.HexToByte(zmkComp1);
            byte[] comp2 = this.HexToByte(zmkComp2);
            byte[] comp3 = this.HexToByte(zmkComp3);

            // ZMK Components XORed
            byte[] zmkCombined = this.XOR(this.XOR(comp1, comp2), comp3);

            return zmkCombined;
        }

        public string CalculateKCVwithDES(string key)
        {
            byte[] keyInBytes = this.HexToByte(key);
            return this.CalculateKCVwithDES(keyInBytes, DES_ZERO_INPUT);
        }

        private string CalculateKCVwithDES(byte[] key, byte[] input)
        {
            string encryptedInputStr;

            // TripleDes key created
            using (var tripleDes = new TripleDESCryptoServiceProvider())
            {
                tripleDes.Key = key;
                tripleDes.IV = DES_IV;
                tripleDes.Padding = PaddingMode.None;
                tripleDes.Mode = CipherMode.ECB;

                // Decrypt with TripleDes
                using (var encrypto = tripleDes.CreateEncryptor())
                {
                    byte[] encryptedInput = encrypto.TransformFinalBlock(input, 0, input.Length);
                    encryptedInputStr = this.ByteToHex(encryptedInput);
                }

                tripleDes.Clear();
            }

            return encryptedInputStr;
        }

        public string CalculateKCVwithAES(string key)
        {
            byte[] keyInBytes = this.HexToByte(key);
            return this.CalculateKCVwithAES(keyInBytes, AES_ZERO_INPUT);
        }

        public string CalculateKCVwithAES(byte[] key, byte[] input)
        {
            string encryptedInputStr;

            using (var aes = new RijndaelManaged())
            {
                aes.KeySize = 256;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.None;
                aes.BlockSize = 128;
                aes.Key = key;
                aes.IV = AES_IV;

                using (var encrypto = aes.CreateEncryptor())
                {
                    byte[] encryptedInput = encrypto.TransformFinalBlock(input, 0, input.Length);
                    encryptedInputStr = this.ByteToHex(encryptedInput);
                }
                
                aes.Clear();
            }

            return encryptedInputStr;
        }
    }
}
