using Microsoft.Owin.Hosting;
using System;

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

				Console.ReadKey();
			}
		}
	}
}
