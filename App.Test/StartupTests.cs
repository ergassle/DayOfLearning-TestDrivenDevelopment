using Xunit;
using AppService;

namespace App.Test
{
	public class StartupTests
	{
		[Theory]
		[InlineData(13, 8)]
		[InlineData(21, 13)]
		[InlineData(5, 3)]
		[InlineData("1st argument is not a number", "hello")]
		[InlineData("1st argument is not a number", null)]
		public void VerifyStartupService(object expected, object input)
		{
			string result = Startup.RunService(new string[] { $"{input}" });
			Assert.Contains(expected.ToString(), result);
		}

		[Fact]
		public void VerifyStartupServiceNoArgumentGiven()
		{
			string result = Startup.RunService(new string[0]);
			Assert.Contains("No argument given", result);
		}
	}
}
