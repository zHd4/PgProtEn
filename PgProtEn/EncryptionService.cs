using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PgProtEn
{
    public class EncryptionService
    {
        public static string[] CreateKeys()
        {
            var cryptoServiceProvider = new RSACryptoServiceProvider(2048);

            var publicKey = cryptoServiceProvider.ExportParameters(false);
            var privateKey = cryptoServiceProvider.ExportParameters(true);

            string[] pair = { GetKeyString(publicKey), GetKeyString(privateKey) };

            return pair;
        }

        private static string GetKeyString(RSAParameters Key)
        {

            var stringWriter = new StringWriter();
            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xmlSerializer.Serialize(stringWriter, Key);
            return stringWriter.ToString();
        }


        public static string Encrypt(string textToEncrypt, string publicKeyString)
        {
            var bytesToEncrypt = Encoding.UTF8.GetBytes(textToEncrypt);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    rsa.FromXmlString(publicKeyString.ToString());
                    var encryptedData = rsa.Encrypt(bytesToEncrypt, true);
                    var base64Encrypted = Convert.ToBase64String(encryptedData);
                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        public static string Decrypt(string textToDecrypt, string privateKeyString)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    rsa.FromXmlString(privateKeyString);

                    var resultBytes = Convert.FromBase64String(textToDecrypt);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    return decryptedData.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }
    }
}
