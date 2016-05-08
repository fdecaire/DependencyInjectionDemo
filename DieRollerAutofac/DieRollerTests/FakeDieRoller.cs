using System.Collections.Generic;
using DieRollerLibrary;

namespace DieRollerTests
{
	public class FakeDieRoller : IDieRoller
	{
		private static int _NextDieRoll = 0;
		private static List<int> _SetDieRoll = new List<int>();
		public static int SetDieRoll
		{
			get
			{
				int nextDieRoll = _SetDieRoll[_NextDieRoll];
				_NextDieRoll++;
				if (_NextDieRoll >= _SetDieRoll.Count)
				{
					_NextDieRoll = 0;
				}

				return nextDieRoll;
			}
			set
			{
				_SetDieRoll.Add(value);
			}
		}

		public static void ClearDieRoll()
		{
			_SetDieRoll.Clear();
			_NextDieRoll = 0;
		}

		public int DieRoll()
		{
			return SetDieRoll;
		}
	}
}
