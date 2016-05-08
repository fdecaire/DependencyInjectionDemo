using System;

namespace GameLibrary
{
	public class DieRoller : DieRollerBase
	{
		private Random RandomNumberGenerator = new Random(DateTime.Now.Millisecond);

		public override int ReturnDieRoll()
		{
			return RandomNumberGenerator.Next() % 6;
		}
	}
}
