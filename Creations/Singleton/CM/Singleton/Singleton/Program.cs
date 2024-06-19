// See https://aka.ms/new-console-template for more information
using Singleton;

var cache =  MemoryCache.Instance;
var cache2 =  MemoryCache.Instance;

cache.Add("DHeure", DateTime.Now);

Console.WriteLine(cache2.Get("DHeure"));

Console.WriteLine( object.ReferenceEquals(cache, cache2));
