using System;
using System.Configuration;
using Mysqllayer;

namespace Memorylayer
{
    public class MlLanguage
    {
        public object Getlanguage()
        {
            var clman = new MLMemCached();
            //try
            //{
            //    clman.Fireservers();
            //}
            //catch (Exception e)
            //{
            //    Console.Write(e.Message);
            //}

            object msal = null;
            msal = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetlangs");

            if (msal != null)
            {
                return msal;
            }

            else
            {
                var slang = new SlLanguage();
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetlangs", slang.Getlanguage());
                msal = slang.Getlanguage();
                return msal;
            }

            //return null;
        }
    }
}