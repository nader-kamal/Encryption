using System;
using System.Text.RegularExpressions;

namespace Encryption.Library
{
    public static class Helper
    {
        /// <summary>
        /// Check input text is uppercase Letters only no number ,no space and no symbols
        /// </summary>
        /// <param name="input">text to check</param>
        /// <returns></returns>
        public static bool IsValidInput(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                if (!(Regex.IsMatch(input, @"^[A-Z]+$")))
                {
                    Console.Write("Only A-Z supported.");
                    return false;
                }
            }
            else
            {
                Console.Write("There is no text.");
                return false;
            }

            return true;
        }

        public static bool IsValidEncryptType(string encryptType)
        {
            if (encryptType=="1"/*|| encryptType=="2"*/)
            {
                return true;
            }
            else
            {
                Console.Write("wrong select");
                return false;
            }
        }
    }
}
