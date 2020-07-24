using AppService;
using System;

namespace TestDrivenDevelopmentSample
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Startup.RunService(args));
		}
	}
}
