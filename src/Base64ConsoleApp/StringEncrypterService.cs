using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncrypter
{
    internal class StringEncrypterService
    {
        private string EncodeToBase64(string input)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);

            return Convert.ToBase64String(inputBytes);
        }

        private string DecodeToString(string input)
        {
            var inputBytes = Convert.FromBase64String(input);

            return Encoding.UTF8.GetString(inputBytes);
        }

        public string EncryptDecode(string method, string input) => method switch
        {
            "e" => EncodeToBase64(input),
            "d" => DecodeToString(input),
            _ => throw new Exception()
        };
    }
}