using System;
using Xunit;
using AppService;
using Moq;

namespace App.Test
{
	public class FibanachiServiceTests
	{
		[Theory]
		[InlineData(2, 1)]
		[InlineData(3, 2)]
		[InlineData(5, 3)]
		[InlineData(8, 5)]
		[InlineData(13, 8)]
		public void VerifyFibanachieReturnsNextSequence(int expectedResult, int input)
		{
			Mock<IFibanachi> fibanachi = new Mock<IFibanachi>();
			fibanachi.Setup(m => m.IsValidSequence(It.IsAny<int>())).Returns(true);
			fibanachi.Setup(m => m.GetPreviousEntryInSequenceOrReturnOne(It.IsAny<int>())).Returns(expectedResult - input);
			IFibanachiService service = new FibanachiService(fibanachi.Object);
			var result = service.GetNexNumberInSequenceOrReturnInput(input);
			Assert.Equal(expectedResult, result);
		}

		[Theory]
		[InlineData(6)]
		[InlineData(1)]
		[InlineData(8)]
		[InlineData(506)]
		public void VerifyFibanachieReturnsInvalidInput(int input)
		{
			Mock<IFibanachi> fibanachi = new Mock<IFibanachi>();
			fibanachi.Setup(m => m.IsValidSequence(It.IsAny<int>())).Returns(false);
			IFibanachiService service = new FibanachiService(fibanachi.Object);
			var result = service.GetNexNumberInSequenceOrReturnInput(input);
			Assert.Equal(input, result);
		}
	}
}
