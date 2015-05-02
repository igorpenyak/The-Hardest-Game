using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHardestGame.ConsoleUI
{
	// Review remark from IP:
    // оскільки даний клас використовується фактично лише для допоміжних потреб (синхронізації),
    // то цілком логічно було б оформити його в окрему підпапку проекту (наприклад, "Utils")
    internal static class Syncronization
	{
		private static readonly object _sync = new object();

		public static object SyncObj
		{
			get { return _sync; }
		}
	}
}
