using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;

namespace SistemaCifradoMensajes;

public class CifradoAES : Cifrado
{
    private string Clave;

    public CifradoAES(string MensajeOriginal) : base(MensajeOriginal)
    {
        this.Clave = "";

    }

    public override void Cifrar()
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Encoding.UTF8.GetBytes(this.Clave);
            aesAlg.IV = new byte[16];

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(getMensajeOriginal());
                        //Console.WriteLine("encriprado "+swEncrypt);
                    }
                    setMensajeOriginal(Convert.ToBase64String(msEncrypt.ToArray()));
                }
            }
        }
    }

    public override void Descifrar()
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Encoding.UTF8.GetBytes(Clave);
            aesAlg.IV = new byte[16];

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(getMensajeOriginal())))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        setMensajeOriginal(srDecrypt.ReadToEnd());
                        //Console.WriteLine(srDecrypt);
                    }
                }
            }
        }
    }

    public string getClave()
    {
        return this.Clave;
    }
    public string setClave(string clave)
    {
        return this.Clave = clave;
    }

}
