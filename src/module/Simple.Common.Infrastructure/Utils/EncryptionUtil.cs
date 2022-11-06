using System.Security.Cryptography;
using System.Text;
using Token.Module.Helpers;

namespace Simple.Common.Infrastructure.Utils;

public static class EncryptionUtil
{
    /// <summary>
    /// 密钥
    /// </summary>
    private const string Key = "s!4%s_2,";
    /// <summary>
    /// 加密
    /// </summary>
    /// <param name="pToEncrypt"></param>
    /// <returns></returns>
    public static string? DesEncrypt(this string? pToEncrypt)
    {
        if (pToEncrypt.IsNullOrEmpty())
            return default;

        var des = DES.Create("des");
        byte[] inputByteArray = Encoding.Default.GetBytes(pToEncrypt);
        des!.Key = Encoding.ASCII.GetBytes(Key);
        des.IV = Encoding.ASCII.GetBytes(Key);
        MemoryStream ms = new MemoryStream();
        CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
        cs.Write(inputByteArray, 0, inputByteArray.Length);
        cs.FlushFinalBlock();
        StringBuilder ret = new StringBuilder();
        foreach (var b in ms.ToArray())
        {
            ret.AppendFormat("{0:X2}", b);
        }
        return ret.ToString();
    }
    /// <summary>
    /// 解密
    /// </summary>
    /// <param name="pToDecrypt"></param>
    /// <returns></returns>
    public static string? DesDecrypt(this string? pToDecrypt)
    {
        if (pToDecrypt.IsNullOrEmpty())
            return default;

        var des = DES.Create("des");

        byte[] inputByteArray = new byte[pToDecrypt.Length / 2];
        for (int x = 0; x < pToDecrypt.Length / 2; x++)
        {
            int i = (Convert.ToInt32(pToDecrypt.Substring(x * 2, 2), 16));
            inputByteArray[x] = (byte)i;
        }
        des!.Key = Encoding.ASCII.GetBytes(Key);
        des.IV = Encoding.ASCII.GetBytes(Key);
        MemoryStream ms = new MemoryStream();
        CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
        cs.Write(inputByteArray, 0, inputByteArray.Length);
        cs.FlushFinalBlock();
        return Encoding.Default.GetString(ms.ToArray());
    }
}
