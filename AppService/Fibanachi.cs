using System;
using System.Collections.Generic;
using System.Text;

namespace AppService
{
	public class Fibanachi : IFibanachi
	{
		public Fibanachi()
		{

		}

		public int GetPreviousEntryInSequenceOrReturnOne(int input)
		{
			if (!IsValidSequence(input))
			{
				return 1;
			}
			return lastInSequence;
		}

		int lastInSequence { get; set; }
		public bool IsValidSequence(int input)
		{
			lastInSequence = 1;
			int current = 1;
			while(current < input)
			{
				int toAdd = lastInSequence;
				lastInSequence = current;
				current = current + toAdd;
			}
			return current == input;
		}
	}
}
