using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BF.Util
{
    static class IDictionaryExtensions
    {
        public static V TryGetValue<K, V>(this IDictionary<K, V> dictionary, K key)
        {
            V result;
            dictionary.TryGetValue(key, out result);
            return result;
        }
    }
}
