using System;

namespace DieRollerLibrary
{
	public class DieRoller : IDieRoller
	{
		private static Random RandomNumberGenerator = new Random(DateTime.Now.Millisecond);

		public int DieRoll()
		{
			return RandomNumberGenerator.Next() % 6;
		}
	}
}
