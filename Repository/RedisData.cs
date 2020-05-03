using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RedisData
    {
        public void RedisConnectionMultiplexer(string key, string value)
        {
            var redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase data = redis.GetDatabase();
            data.StringSet(key, value);
        }

        public string Redis(string key)
        {
            var redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase data = redis.GetDatabase();
            var datas = data.StringGet(key);
            return datas;
        }
    }
}
