namespace Encryption.Library
{
    public interface IEncrypt
    {
        char EcreyptChar(char ch, int shift);
        string EcreyptText(string input, int shift);
    }
}
