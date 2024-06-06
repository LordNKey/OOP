using OOP_C_;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Cryptography
{
    public class Cryptography : File_DLL
    {
        public override string settingItem { get => "Шифрование / Дешифрование"; }

        public override string PostSave(string preSave)
        {
            Aes aes = Aes.Create();
            using (var keysInputForm = new KeyInputForm())
            {
                if (keysInputForm.ShowDialog() == DialogResult.OK)
                {
                    aes.Key = Convert.FromHexString(keysInputForm.Key);
                    aes.IV = Convert.FromHexString(keysInputForm.IV);
                }
            }

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(preSave);   
                    }
                }
                byte[] str = msEncrypt.ToArray();
                int len = str.Length;
                return Convert.ToBase64String(str);
            }
        }

        public override string PreOpen(string fileData)
        {
            Aes aes = Aes.Create();
            using (var keysInputForm = new KeyInputForm())
            {
                if (keysInputForm.ShowDialog() == DialogResult.OK)
                {
                    aes.Key = Convert.FromHexString(keysInputForm.Key);
                    aes.IV = Convert.FromHexString(keysInputForm.IV);
                }
            }

            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            byte[] byteData = Convert.FromBase64String(fileData);
            using (MemoryStream msDecrypt = new MemoryStream(byteData))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }
}
