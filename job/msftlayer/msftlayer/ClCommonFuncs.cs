using System;

namespace Msftlayer
{
    public class ClCommonFuncs
    {
        //split string
        public string[] Splitst(string tosplit, string[] splitcharacters)
        {
            return tosplit.Split(splitcharacters, StringSplitOptions.None);
        }
    }
}