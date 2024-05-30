using OOP_C_;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Cryptography
{
    public class Cryptography : File_DLL
    {
        public string settingItem { get => "Шифрование / Дешифрование"; }
        

        public string PostSave(string preSave)
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
            aes.
        }
        public string PreOpen(string fileData)
        {

        }
    }
}
