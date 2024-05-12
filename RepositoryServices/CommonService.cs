using CP_POS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;


namespace CP_POS.RepositoryServices
{

    public class CommonService 
    {
        #region declaration
        private readonly IMemoryCache _Memorycash;
        #endregion

        public CommonService(IMemoryCache ? memoryCache )
        {

            _Memorycash = memoryCache;

        }


        public void SetCacheData(string key, object data)
        {
            _Memorycash.Set(key, data, TimeSpan.FromMinutes(2)); // Cache for 30 minutes
        }

        public object GetCashData(string key)
        {
            return _Memorycash.Get(key);
        } 
        public void ResetCash(string key)
        {
            //return _Memorycash.Get(key);
            _Memorycash.Remove(key);
        }
    }

}
