using System.Security.Cryptography;
using System.Text;

namespace Msftlayer
{
    public class ClPwdHash
    {
        //get password
        public string GetMd5Hash(string input)
        {
            var md5Hasher = MD5.Create();
            var data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            var sBuilder = new StringBuilder();
            for (var i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        //password validators
        public bool Validatepassword(string _input)
        {
            bool _output = false;

            if (_input.Contains(" ")) { _output = true; }
            if (_input.Contains("^")) { _output = true; }
            if (_input.Contains("/")) { _output = true; }
            if (_input.Contains("\\")) { _output = true; }
            if (_input.Contains("\"")) { _output = true; }
            if (_input.Contains("\'")) { _output = true; }
            if (_input.Contains(".")) { _output = true; }
            if (_input.Contains(",")) { _output = true; }
            if (_input.Contains("]")) { _output = true; }
            if (_input.Contains("[")) { _output = true; }
            if (_input.Contains("{")) { _output = true; }
            if (_input.Contains("}")) { _output = true; }
            if (_input.Contains("*")) { _output = true; }
            if (_input.Contains("-")) { _output = true; }
            if (_input.Contains("_")) { _output = true; }
            if (_input.Contains("+")) { _output = true; }
            if (_input.Contains("))")) { _output = true; }
            if (_input.Contains("(")) { _output = true; }
            if (_input.Contains("&")) { _output = true; }
            if (_input.Contains(";")) { _output = true; }
            if (_input.Contains(":")) { _output = true; }
            if (_input.Contains("|")) { _output = true; }
            if (_input.Contains("~")) { _output = true; }
            if (_input.Contains("`")) { _output = true; }
            if (_input.Contains("=")) { _output = true; }
            if (_input.Contains("?")) { _output = true; }
            if (_input.Contains(">")) { _output = true; }
            if (_input.Contains("<")) { _output = true; }

            return _output;
        }
    }
}