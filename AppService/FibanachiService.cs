using System;

namespace AppService
{
	public class FibanachiService : IFibanachiService
	{
		IFibanachi Fibanachi { get; }

		public FibanachiService(IFibanachi fibanachi)
		{
			Fibanachi = fibanachi;
		}

		/// <summary>
		/// We want the next number in a valid fibanachi sequence.
		/// Return the next if valid.
		/// Return the input if not valid.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public int GetNexNumberInSequenceOrReturnInput(int input)
		{
			if (!Fibanachi.IsValidSequence(input))
			{
				return input;
			}

			int previousSequence = Fibanachi.GetPreviousEntryInSequenceOrReturnOne(input);
			return AddInputToPreviousSequenceToGetNextSequence(input, previousSequence);
		}

		private int AddInputToPreviousSequenceToGetNextSequence(int input, int previousSequenc)
		{
			return input + previousSequenc;
		}
	}
}
