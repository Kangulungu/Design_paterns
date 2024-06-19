using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class MemoryCache
    {
        private Dictionary<string, object> _cacheObject;
        private static Lazy<MemoryCache> _cache = new Lazy<MemoryCache>(() => new MemoryCache());
        public static MemoryCache Instance {
            get {
                return _cache.Value;
            }
        }
        private MemoryCache()
        {
            _cacheObject = new Dictionary<string, object>();
        }

        public void Add(string key, object value)
        {
            _cacheObject.Add(key, value);
        }
        public object Get(string key)
        {
            if(_cacheObject.ContainsKey(key))
             return _cacheObject[key];
            
            return null;
        }
    }
}
