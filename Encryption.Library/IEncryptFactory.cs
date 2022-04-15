namespace Encryption.Library
{
    public interface IEncryptFactory
    {
        IEncrypt GetEncrypt(string encryptType);
    }
}
