using System;
using Autofac;
using Container;
using DieRollerLibrary;

namespace GameLibrary
{
	public class Game
	{
		public int Play()
		{
			using (var scope = IOCContainer.Container.BeginLifetimeScope())
			{
				var die = scope.Resolve<IDieRoller>();

				return die.DieRoll();
			}
		}
	}
}
