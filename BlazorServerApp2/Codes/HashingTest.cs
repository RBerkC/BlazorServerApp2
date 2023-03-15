using System.Security.Cryptography;
using BCrypt.Net;
namespace BlazorServerApp2.Codes;

public class HashingTest
{
    public string CreateMD5Hash()
    {
        string textToHash = "1Berk0";
        string salt = "idjfkdflkjsalj";
        MD5 md5 = MD5.Create();
        byte[] myPasswordHash = System.Text.Encoding.UTF8.GetBytes(textToHash + salt);
        byte[] hashedPasswordAsbyteArray = md5.ComputeHash(myPasswordHash);
        return Convert.ToBase64String(hashedPasswordAsbyteArray);
    }

    public string CreateBcryptHast()
    {
        string textToHash = "1Berk0";
        string salt = BCrypt.Net.BCrypt.GenerateSalt();
        string bcrypt = BCrypt.Net.BCrypt.HashPassword(textToHash, salt);

        return bcrypt;
    }


}
