using System.Text;

namespace Encryption.Library
{
    public class CaesarCipher : IEncrypt
    {
        public char EcreyptChar(char ch, int shift)
        {
            int shifted = (ch +shift - 65) % 26 + 65;

            return (char)shifted;
        }

        public string EcreyptText(string input, int shift)
        {
            //use StringBuilder instead of string to improve performance of use RAM
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                output = output.Append(EcreyptChar(input[i], shift));
            }
            return output.ToString();
        }
    }
}
