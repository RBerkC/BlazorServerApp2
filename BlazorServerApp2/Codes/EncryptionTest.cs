using Microsoft.AspNetCore.DataProtection;

namespace BlazorServerApp2.Codes;

public class EncryptionTest
{
    private readonly IDataProtector _dataProtector;

    public EncryptionTest(IDataProtectionProvider dataProtector)
    {
        _dataProtector = dataProtector.CreateProtector("BlazorServerApp2.Codes.EncryptionTest.BerkCatal");
    }
    public string Protect(string valueToEncrypt) => _dataProtector.Protect(valueToEncrypt);


    public string UnProtect(string valueToEncrypt) => _dataProtector.Unprotect(valueToEncrypt);
}
