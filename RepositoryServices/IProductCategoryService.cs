namespace CP_POS.RepositoryServices
{
	public interface IProductCategoryService
	{
        Task<List<ProductCategory>> Gets();
        Task<ProductCategory> Get(Guid id);
		Task<ProductCategory> Create(ProductCategory oProductCategory);
        Task<ProductCategory> Update(Guid id, ProductCategory oProductCategory);
        Task<string> Delete(Guid id);
	}
}
