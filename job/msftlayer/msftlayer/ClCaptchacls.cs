using System;
using System.Text;

namespace Msftlayer
{
    public class ClCaptchacls
    {
        //generate random strings here
        private readonly Random _random = new Random((int)DateTime.Now.Ticks); //thanks to McAden

        //captch builder
        public string RandomcapString(int size)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                char ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * _random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
    }
}