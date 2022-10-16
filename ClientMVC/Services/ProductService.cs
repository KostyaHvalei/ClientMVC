using ClientMVC.Extensions;
using Contracts;
using Entities.DataTransferObjects;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientMVC.Services
{
	public class ProductService : IProductService
	{
		private readonly HttpClient _client;
		public const string BasePath = "/api/products";

		public ProductService(HttpClient client)
		{
			_client = client;
		}

		public async Task<IEnumerable<ProductDTO>> GetAll()
		{
			var response = await _client.GetAsync(BasePath);

			return await response.ReadContentAsync<List<ProductDTO>>();
		}
	}
}
