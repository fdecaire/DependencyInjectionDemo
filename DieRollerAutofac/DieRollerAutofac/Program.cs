using DieRollerLibrary;
using Autofac;
using Container;
using GameLibrary;

namespace DieRollerAutofac
{
	class Program
	{
		static void Main(string[] args)
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<DieRoller>().As<IDieRoller>();
			IOCContainer.Container = builder.Build();

			Game myGame = new Game();
			myGame.Play();
		}
	}
}
