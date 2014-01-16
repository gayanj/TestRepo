using System;
using Memorylayer.memcachedlib;

namespace Memorylayer
{
    public class MLMemCached
    {
        private const int Isendtimeout = 35000;
        private const int Iconnecttimeout = 35000;
        private const int Iminpoolsize = 1;
        private const int Imaxpoolsize = 200;
        private const string Server1 = "Serv1";
        private const string ServerIp = "localhost";

        public void Fireservers()
        {
            MemcachedClient.Setup(Server1, new[] { ServerIp });
        }

        public void Addmemcarray(string keyp, string[,] memitem)
        {
            var cache = MemcachedClient.GetInstance(Server1);
            cache.SendReceiveTimeout = Isendtimeout;
            cache.ConnectTimeout = Iconnecttimeout;
            cache.MinPoolSize = Iminpoolsize;
            cache.MaxPoolSize = Imaxpoolsize;
            cache.Set(keyp, memitem);
        }

        public string[,] Getmemcarray(string keyp)
        {
            try
            {
                var cache = MemcachedClient.GetInstance(Server1);

                return cache.Get(keyp) as string[,];
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            return null;
        }

        public void Revmemc(string keyp)
        {
            try
            {
                var cache = MemcachedClient.GetInstance(Server1);

                cache.Delete(keyp);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        public void Addmemcobj(string keyp, object memitem)
        {
            var cache = MemcachedClient.GetInstance(Server1);
            cache.SendReceiveTimeout = Isendtimeout;
            cache.ConnectTimeout = Iconnecttimeout;
            cache.MinPoolSize = Iminpoolsize;
            cache.MaxPoolSize = Imaxpoolsize;
            cache.Set(keyp, memitem);
        }

        public object Getmemcobj(string keyp)
        {
            try
            {
                var cache = MemcachedClient.GetInstance(Server1);

                return cache.Get(keyp);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            return null;
        }

        public void Addmemcstr(string keyp, string strvalue)
        {
            var cache = MemcachedClient.GetInstance(Server1);
            cache.SendReceiveTimeout = Isendtimeout;
            cache.ConnectTimeout = Iconnecttimeout;
            cache.MinPoolSize = Iminpoolsize;
            cache.MaxPoolSize = Imaxpoolsize;
            cache.Set(keyp, strvalue);
        }

        public string Getmemcstr(string keyp)
        {
            try
            {
                var cache = MemcachedClient.GetInstance(Server1);

                return cache.Get(keyp) as string;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            return null;
        }
    }
}