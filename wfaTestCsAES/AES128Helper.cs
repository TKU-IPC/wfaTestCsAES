using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace wfaTestCsAES
{
    class AES128Helper 
    {
        //const string AES_KEY = "b16920894899c7780b5fc7161560a41";


        public static string getKey(String AES_KEY) // 補足 16 位數
        {
            string strPadding = "1234567890123456";
            try
            {
                AES_KEY = (AES_KEY + "1234567890123456").Substring(0, 16);
            }
            catch
            {
                AES_KEY = strPadding;
            }
            return AES_KEY;
        }

        /// <summary>  
        /// AES加密  
        /// </summary>  
        /// <param name="Text">待加密字符串</param>  
        /// <returns>加密後字符串</returns>  
        public static string AESEncrypt(string Text , String AES_KEY)
        {
            try
            {
                string key = getKey(AES_KEY);
                //分組加密算法  
                AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
                byte[] inputByteArray = Encoding.UTF8.GetBytes(Text);//得到需要加密的字節數組   
                                                                     //設置密鑰及密鑰矢量  
                aes.Key = Encoding.UTF8.GetBytes(key);
                //aes.IV = Encoding.UTF8.GetBytes(key);  
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;
                byte[] cipherBytes = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(inputByteArray, 0, inputByteArray.Length);
                        cs.FlushFinalBlock();
                        cipherBytes = ms.ToArray();//得到加密後的字節數組  
                        cs.Close();
                        ms.Close();
                    }
                }
                return Convert.ToBase64String(cipherBytes);
            }
            catch { }
            return Text;
        }

        /// <summary>  
        /// AES解密  
        /// </summary>  
        /// <param name="Text">待解密字符串</param>  
        /// <returns>解密後字符串</returns>  
        public static string AESDecrypt(string Text,String AES_KEY)
        {
            try
            {
                string key = getKey(AES_KEY);
                byte[] cipherText = Convert.FromBase64String(Text);
                AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
                aes.Key = Encoding.UTF8.GetBytes(key);
                //aes.IV = Encoding.UTF8.GetBytes(key);  
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;
                byte[] decryptBytes = new byte[cipherText.Length];
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        cs.Read(decryptBytes, 0, decryptBytes.Length);
                        cs.Close();
                        ms.Close();
                    }
                }
                return Encoding.UTF8.GetString(decryptBytes).Replace("\0", "");   //將字符串後尾的'\0'去掉  
            }
            catch { }
            return Text;
        }
    }
}
