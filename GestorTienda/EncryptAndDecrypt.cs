using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorTienda
{
    class EncryptAndDecrypt
    {
        string key;



        public void GenerarKey()
        {
            if (key == null)
            {

            
            int longitud = 7;
            Guid miGuid = Guid.NewGuid();
            string token = Convert.ToBase64String(miGuid.ToByteArray());
            token = token.Replace("=", "").Replace("+", "");
            key = token.Substring(0, longitud);

                try
                {
                    
                                      

                    File.WriteAllText("key.key", key);

                    
                    
                    

                    
                }catch(Exception e)
                {
                    MessageBox.Show(e.GetBaseException().ToString());
                }
                
            }

            
           


        }

        public string Encrypt(string password)
        {

           
           key = File.ReadAllText("key.key");

            byte[] passwdEncrypt = UTF8Encoding.UTF8.GetBytes(password);
            byte[] keyByte = UTF8Encoding.UTF8.GetBytes(key);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            keyByte = md5.ComputeHash(keyByte);

            md5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyByte;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform transform = tdes.CreateEncryptor();

            byte[] passByte = transform.TransformFinalBlock(passwdEncrypt, 0, passwdEncrypt.Length);

            tdes.Clear();

            password = Convert.ToBase64String(passByte, 0, passByte.Length);

            return password;
        }

        public string Decrypt(string password)
        {
            
           key = File.ReadAllText("key.key");

            byte[] passByte = Convert.FromBase64String(password);
            byte[] keyByte;

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            keyByte = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            md5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider
            {
                Key = keyByte,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform transform = tdes.CreateDecryptor();

            byte[] passDecrypt = transform.TransformFinalBlock(passByte, 0, passByte.Length);

            tdes.Clear();

            password = UTF8Encoding.UTF8.GetString(passDecrypt, 0, passDecrypt.Length);

            return password;
        }
    }
}
