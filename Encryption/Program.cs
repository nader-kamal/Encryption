using Encryption.Library;
using System;

namespace Encryption
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //We will apply Factory design pattern to make code open for extension for new encrypt types


            string encryptType = string.Empty;
            EncryptFactory encryptFactory = new EncryptFactory();

            //encrypt Type my be configuration but here Allow user to select
            Console.Clear();
            Console.WriteLine("Choose Type Of Encrypt:");
            Console.WriteLine("1) Caesar Cipher");
        //Console.WriteLine("2) Other Type");

        SelectType: Console.Write("\r\nSelect Type: ");
            string type = Console.ReadLine();
            if (Helper.IsValidEncryptType(type))
            {
                switch (type)
                {
                    case "1":
                        encryptType = "CaesarCipher";
                        break;
                        //case "2":
                        //    encryptType = "";
                        //    break;

                }

                EnterInput:Console.Write("\r\nInput: ");
                string input = Console.ReadLine();
                if (Helper.IsValidInput(input))
                {
                    EnterShiftValue: Console.Write("\r\nEnter your shift Value Integer: ");
                    var shiftIsNumeric = int.TryParse(Console.ReadLine(), out int shift);
                    if (shiftIsNumeric)
                    {
                        IEncrypt encrypt = encryptFactory.GetEncrypt(encryptType);

                        Console.WriteLine("Output: " + encrypt.EcreyptText(input, shift));
                        goto SelectType;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Value");
                        goto EnterShiftValue;
                    }

                }
                else
                {
                    goto EnterInput;
                }
            }
            else
            {
                goto SelectType;
            }
            
        }
    }
}
