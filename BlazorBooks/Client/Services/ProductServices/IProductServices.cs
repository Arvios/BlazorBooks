namespace BlazorBooks.Client.Services.ProductServices
{
	public interface IProductServices
	{
		List<Product> Products { get; set; }
		Task GetProducts();
		Task<ServiceResponse<Product>> GetProduct(int productId);
	}
}
