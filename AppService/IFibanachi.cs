using System;
using System.Collections.Generic;
using System.Text;

namespace AppService
{
	public interface IFibanachi
	{
		bool IsValidSequence(int input);
		int GetPreviousEntryInSequenceOrReturnOne(int input);
	}
}
