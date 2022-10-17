using ClientMVC.Extensions;
using Contracts;
using Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
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

		public async Task<FridgeProductsDTO> GetFridge(Guid id)
		{
			var response = await _client.GetAsync(BasePath + "/" + id.ToString());
			return await response.ReadContentAsync<FridgeProductsDTO>();
		}

		public async Task<bool> EditFridge(Guid id, FridgeToUpdateDTO fridge)
		{
			var response = await _client.PutAsJsonAsync(BasePath + "/" + id.ToString(), fridge);
			if (!response.IsSuccessStatusCode)
				return false;
			return true;
		}
	}
}
