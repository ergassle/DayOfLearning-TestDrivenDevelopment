using Xunit;
using AppService;

namespace App.Test
{
	public class FibanachiTests
	{
		[Theory]
		[InlineData(true, 1)] // is valid
		[InlineData(false, 4)] // not valid
		[InlineData(true, 3)] // is valid
		[InlineData(true, 13)] // is valid
		public void VerifyIsValidSequence(bool expected, int input)
		{
			IFibanachi service = new Fibanachi();
			bool result = service.IsValidSequence(input);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(1, 4)]
		public void VerifyGetPreviousEntryInSequenceWhenInvalid(int expected, int input)
		{
			IFibanachi service = new Fibanachi();
			int previousSequence = service.GetPreviousEntryInSequenceOrReturnOne(input);
			Assert.Equal(expected, previousSequence);
		}

		[Theory]
		[InlineData(3, 5)]
		public void VerifyGetPreviousEntryInSequenceWhenValid(int expected, int input)
		{
			IFibanachi service = new Fibanachi();
			int previousSequence = service.GetPreviousEntryInSequenceOrReturnOne(input);
			Assert.Equal(expected, previousSequence);
		}
	}
}
