using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientMVC.Services
{
	public class FridgeProductsService
	{
		private readonly HttpClient _client;
		public const string BasePath = "/api/fridges";

		public FridgeProductsService(HttpClient client)
		{
			_client = client;
		}
	}
}
