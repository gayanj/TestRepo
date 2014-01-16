using System;
using Memorylayer.memcachedlib;

namespace Msftlayer
{
    public class CLMemCached
    {
        //pool sizes
        private const uint Poolminsz = 1;
        private const uint Poolmaxsz = 200;

        public void Fireservers()
        {
            MemcachedClient.Setup("Serv1", new[] { "localhost" });
        }

        public void Addmemcarray(string keyp, string[,] memitem)
        {
            MemcachedClient cache = MemcachedClient.GetInstance("Serv1");
            //MemcachedClient configFileCache = MemcachedClient.GetInstance("MyConfigFileCache");
            cache.SendReceiveTimeout = 35000;
            cache.ConnectTimeout = 35000;
            cache.MinPoolSize = Poolminsz;
            cache.MaxPoolSize = Poolmaxsz;

            cache.Set(keyp, memitem);
        }

        public string[,] Getmemcarray(string keyp)
        {
            try
            {
                MemcachedClient cache = MemcachedClient.GetInstance("Serv1");

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
                MemcachedClient cache = MemcachedClient.GetInstance("Serv1");

                cache.Delete(keyp);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        public void Addmemcobj(string keyp, object memitem)
        {
            MemcachedClient cache = MemcachedClient.GetInstance("Serv1");
            cache.SendReceiveTimeout = 35000;
            cache.ConnectTimeout = 35000;
            cache.MinPoolSize = Poolminsz;
            cache.MaxPoolSize = Poolmaxsz;

            cache.Set(keyp, memitem);
        }

        public object Getmemcobj(string keyp)
        {
            try
            {
                MemcachedClient cache = MemcachedClient.GetInstance("Serv1");

                return cache.Get(keyp);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            return null;
        }
    }
}