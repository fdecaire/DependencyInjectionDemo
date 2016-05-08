using Microsoft.VisualStudio.TestTools.UnitTesting;
using DieRollerLibrary;
using Autofac;
using GameLibrary;
using Container;

namespace DieRollerTests
{
	[TestClass]
	public class DieRollerTests
	{
		[TestInitialize]
		public void Initialize()
		{
			FakeDieRoller.ClearDieRoll();
		}

		[TestMethod]
		public void TestDieRoll()
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<FakeDieRoller>().As<IDieRoller>();
			IOCContainer.Container = builder.Build();

			FakeDieRoller.SetDieRoll = 5;
			FakeDieRoller.SetDieRoll = 2;
			FakeDieRoller.SetDieRoll = 7;

			var game = new Game();
			var result = game.Play();

			Assert.AreEqual(5, result);

			result = game.Play();
			Assert.AreEqual(2, result);

			result = game.Play();
			Assert.AreEqual(7, result);
		}
	}
}
