using CP_POS.Models;
using CP_POS.RepositoryServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CP_POS.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
	{
		private readonly IProductCategoryService _oProductCategoryService ;
		public ProductCategoryController(IProductCategoryService iProductCategoryService) 
		{ 
			_oProductCategoryService = iProductCategoryService;
		}
	

		[HttpGet("Gets")]
		public async Task<List<ProductCategory>> Gets()
		{
			var oResult = await _oProductCategoryService.Gets();
			return oResult;
		}

		// GET api/<ProductCategoryController>/5
		[HttpGet("Get")]
		public async Task<ActionResult<ProductCategory>> Get(Guid id)
		{
			var oResult = await _oProductCategoryService.Get(id);
			if (oResult == null)	
				return NotFound("Data Not Found");
			return Ok(oResult);
		}

        [HttpPost("Create")]
        public async Task<ActionResult> Create(ProductCategory value)
		{
			ProductCategory ProductCategory = new ProductCategory();
			try
			{
				ProductCategory = await _oProductCategoryService.Create(value);
			}catch(Exception ex)
			{
				//ProductCategory.ErrorMessage = ex.Message;
                string sErrorMessage = ex.Message;
      
                return Ok(sErrorMessage);
            }
			return Ok(ProductCategory);
		}

		// PUT api/<ProductCategoryController>/5
		[HttpPut("Update")]
        public async Task<ActionResult> Update(Guid id, ProductCategory value)
		{
            var oExistUser = await _oProductCategoryService.Get(id);
            if (oExistUser == null)
            {
                return NotFound();
            }
            var oResult =  await _oProductCategoryService.Update(id, value);

			return Ok(oResult);
		}


		[HttpDelete("Delete")]
		public async Task<string> Delete(Guid id)
		{
			var sresult = await _oProductCategoryService.Delete(id);			

			return sresult;
		}
	}
}
