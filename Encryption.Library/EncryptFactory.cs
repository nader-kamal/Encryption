namespace Encryption.Library
{
    public class EncryptFactory : IEncryptFactory
    {
        public IEncrypt GetEncrypt(string encryptType)
        {
            switch (encryptType)
            {
                case "CaesarCipher":return new CaesarCipher();
                
                //add other types if exists
                
            }
            return null;
        }
    }
}
