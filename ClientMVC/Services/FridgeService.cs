using ClientMVC.Extensions;
using Contracts;
using Entities.DataTransferObjects;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientMVC.Services
{
	public class FridgeService : IFridgeService
	{
		private readonly HttpClient _client;
		public const string BasePath = "/api/fridges";

		public FridgeService(HttpClient client)
		{
			_client = client;
		}

		public async Task<IEnumerable<FridgeDTO>> GetAll()
		{
			var response = await _client.GetAsync(BasePath);

			return await response.ReadContentAsync<List<FridgeDTO>>();
		}
	}
}
