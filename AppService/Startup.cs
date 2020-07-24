using Microsoft.Extensions.DependencyInjection;

namespace AppService
{
	public class Startup
	{
		public static string RunService(string[] input)
		{
			if (input.Length == 0)
			{
				return "Invalid Input: No argument given";
			}
			if (!int.TryParse(input[0], out int number))
			{
				return "Invalid Input: 1st argument is not a number";
			}
			Startup startup = new Startup();
			IServiceCollection service = startup.GetConfiguredServices();
			using (ServiceProvider provider = service.BuildServiceProvider())
			{
				IFibanachiService fibanachiService = provider.GetService<IFibanachiService>();
				int result = fibanachiService.GetNexNumberInSequenceOrReturnInput(number);

				return $"The result is {result}";
			}
		}

		private Startup()
		{
		}

		private IServiceCollection GetConfiguredServices()
		{
			ServiceCollection services = new ServiceCollection();
			services.AddTransient<IFibanachiService, FibanachiService>();
			services.AddTransient<IFibanachi, Fibanachi>();
			return services;
		}
	}
}
