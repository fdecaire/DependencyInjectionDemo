using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLibrary;

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
			DieRoller.Instance = new FakeDieRoller();
			FakeDieRoller.SetDieRoll = 5;
			FakeDieRoller.SetDieRoll = 2;
			FakeDieRoller.SetDieRoll = 7;

			var game = new Game();
			int result = game.Play();
			Assert.AreEqual(5, result);

			result = game.Play();
			Assert.AreEqual(2, result);

			result = game.Play();
			Assert.AreEqual(7, result);
		}
	}
}
