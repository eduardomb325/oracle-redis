using System;
using StackExchange.Redis;

namespace SubsTrainingRedis
{
    class Program
    {
        static void Main(string[] args)
        {
            var connString = "localhost";

            var redisConnection = ConnectionMultiplexer.Connect(connString);

            IDatabase db = redisConnection.GetDatabase();

            var pub = redisConnection.GetSubscriber();

            pub.Publish("net15", "helloooo");
        }
    }
}
