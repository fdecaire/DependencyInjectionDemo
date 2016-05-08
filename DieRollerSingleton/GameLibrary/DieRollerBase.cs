namespace GameLibrary
{
	public abstract class DieRollerBase
	{
		public static DieRollerBase _Instance;
		public static DieRollerBase Instance
		{
			get
			{
				if (_Instance == null)
				{
					_Instance = new DieRoller();
				}

				return _Instance;
			}
			set
			{
				_Instance = value;
			}
		}

		public static int DieRoll()
		{
			return Instance.ReturnDieRoll();
		}

		public abstract int ReturnDieRoll();
	}
}
