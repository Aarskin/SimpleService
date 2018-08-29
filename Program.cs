using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;
using System.Threading;

namespace SimpleWebApp
{
	class Program
	{
		public const string BASE_ADDRESS = "http://localhost:8385/";
		static void Main(string[] args)
		{
			using (WebApp.Start<OwinSelfHost>(BASE_ADDRESS))
			{
				Console.WriteLine($"Simple service listening at {BASE_ADDRESS}...");
				Console.WriteLine();

				while (true)
				{
					// Create HttpCient and make a request to api/values 
					HttpClient client = new HttpClient();
					var response = client.GetAsync(BASE_ADDRESS + "api/simple").Result;
					Console.WriteLine(response.Content.ReadAsStringAsync().Result);

					Thread.Sleep(200);
				}
			}
		}
	}
}
