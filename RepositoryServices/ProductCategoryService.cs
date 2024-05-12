using CP_POS.Models;
using CP_POS.RepositoryServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Caching.Memory;
namespace CP_POS.RepositoryServices
{
	public class ProductCategoryService : IProductCategoryService
	{
        #region Declaration
        private CpPosContext _CpPosContext;
        private CommonService _oCommonService  = new CommonService(null);
        #endregion
        public ProductCategoryService(CpPosContext CpPosContext, CommonService oCommonService)
		{
			_CpPosContext = CpPosContext;
            _oCommonService = oCommonService;

        }

		#region Interface implementation
		public async Task<ProductCategory> Create(ProductCategory oProductCategory)
		{
        
            await _CpPosContext.ProductCategories.AddAsync(new ProductCategory
            {
                Name = oProductCategory.Name,
                DbuserId = oProductCategory.DbuserId,

            });
            await _CpPosContext.SaveChangesAsync();
            //_Memorycash.Remove("ProductCategories");
            _oCommonService.ResetCash("ProductCategories");
            return oProductCategory;
		}

		public async Task<string> Delete(Guid id)
		{
			var ofindOb = await _CpPosContext.ProductCategories.Where(x => x.Id == id).FirstOrDefaultAsync();
             _CpPosContext.ProductCategories.Remove(ofindOb);

            await _CpPosContext.SaveChangesAsync();
            return "Deleted";
		}

		public async Task<ProductCategory> Get(Guid id)
		{
			return  await _CpPosContext.ProductCategories.Where(x => x.Id == id).FirstOrDefaultAsync();
		}

		public async Task<List<ProductCategory>> Gets()
		{
            if (_oCommonService.GetCashData("ProductCategories")!=null)
            {
                //_Memorycash.TryGetValue("ProductCategories", out List<ProductCategory> cachedData);
                dynamic cachedData = _oCommonService.GetCashData("ProductCategories");
                return await cachedData;
            }
            else
            {
                var oResult = _CpPosContext.ProductCategories.ToListAsync();
                _oCommonService.SetCacheData("ProductCategories", oResult);
                //_Memorycash.Set("ProductCategories", oResult, TimeSpan.FromMinutes(2));
                return await oResult;
            }
	

        }

     

        public async Task<ProductCategory> Update(Guid id, ProductCategory oProductCategory)
		{
			var ofinProductCategory= await _CpPosContext.ProductCategories.Where(x => x.Id == id).FirstOrDefaultAsync();
			if (ofinProductCategory != null)
			{
				ofinProductCategory.Name = oProductCategory.Name;
				ofinProductCategory.Id = oProductCategory.Id;
			}
            _CpPosContext.Entry(ofinProductCategory).CurrentValues.SetValues(oProductCategory);

            // Save the changes
            await _CpPosContext.SaveChangesAsync();

            ofinProductCategory = await _CpPosContext.ProductCategories.Where(x => x.Id == id).FirstOrDefaultAsync();
            return ofinProductCategory;
		}
	

		#endregion
	}
}
