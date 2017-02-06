using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher_Shift
{
    class Program
    {
        static void Main(string[] args)
        {
            CeasarCypher("Zwddg ogjdv!", 8);

            Console.ReadKey();
        }

        public static string CeasarCypher(string input, int key)
        {            
            char[] alphabet = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            var strInput = input.ToArray();
            
            string decrypted = string.Empty;

            for (int i = 0; i < strInput.Length; i++)
            {
                char encryptedChar = strInput[i];
                char current = (char)(((Char.ToLower(encryptedChar) - 'a' + key) % 26) + 'a');

                for (int y = 0; y < alphabet.Length;)
                {
                    if (!Char.IsUpper(encryptedChar))
                    {
                        decrypted += current.ToString();
                        break;
                    }
                        decrypted += Char.ToUpper(current).ToString();
                        break;
                }
            }

            return decrypted.Replace("\\", " ").Replace("]", "!");
        }
    }
}
