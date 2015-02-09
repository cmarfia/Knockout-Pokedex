using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitJson;

namespace PokedexImport
{
    public static class Extensions
    {
        public static bool Contains(this JsonData data, string key)
        {
            JsonData outData = null;
            return data.TryGetValue(key, out outData);
        }

        public static bool TryGetValue(this JsonData inData, string key, out JsonData outData)
        {
            try
            {
                outData = inData[key];
                return true;
            }
            catch (KeyNotFoundException)
            {
                outData = null;
                return false;
            }
        }
    }
}
