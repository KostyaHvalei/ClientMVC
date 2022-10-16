using ClientMVC.Extensions;
using Contracts;
using Entities.DataTransferObjects;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientMVC.Services
{
	public class FridgeModelService : IFridgeModelService
	{
		private readonly HttpClient _client;
		public const string BasePath = "/api/models";

		public FridgeModelService(HttpClient client)
		{
			_client = client;
		}

		public async Task<IEnumerable<FridgeModelDTO>> GetAll()
		{
			var response = await _client.GetAsync(BasePath);

			return await response.ReadContentAsync<List<FridgeModelDTO>>();
		}
	}
}
